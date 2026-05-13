using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace game_development_studio
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshProjectList();
        }

        private void btnADDPROJECT_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                string budgetText = txtBudget.Text.Trim();
                string status = txtStatus.Text.Trim();
                string genre = txtGenre.Text.Trim();
                DateTime startDate = dtpStartDate.Value;
                DateTime deadline = dtpDeadline.Value;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MaterialMessageBox.Show("Please enter a project title.");
                    txtTitle.Focus();
                    return;
                }

                if (!decimal.TryParse(budgetText, out decimal budget) || budget <= 0)
                {
                    MaterialMessageBox.Show("Please enter a valid budget (positive number).");
                    txtBudget.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(status))
                {
                    MaterialMessageBox.Show("Please enter a project status.");
                    txtStatus.Focus();
                    return;
                }

                if (deadline <= startDate)
                {
                    MaterialMessageBox.Show("Deadline must be after the Start Date.");
                    return;
                }

                var project = new Project
                {
                    Id = Guid.NewGuid(),
                    Title = title,
                    Genre = genre,
                    Budget = budget,
                    StartDate = startDate,
                    Deadline = deadline,
                    Status = status,
                    Producer = null,
                    Publisher = null,
                    DevelopmentTeam = null
                };

                FileManager.Add(project);
                DataManager<Project>.Add(project);

                txtTitle.Clear();
                txtBudget.Clear();
                txtStatus.Clear();
                txtGenre.Clear();

                RefreshProjectList();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error: {ex.Message}");
            }
            RefreshProjectList();
            CalculateStatistics();
            MaterialMessageBox.Show("Project added successfully");
        }

        private void RefreshProjectList()
        {
            List<Project> projects = FileManager.LoadAll<Project>().ToList();

            foreach (var p in projects)
            {
                if (!DataManager<Project>.Entities.Any(e => e.Id == p.Id))

                    DataManager<Project>.Add(p);
            }

            Paginate();
            CalculateStatistics();
        }


        // ── unused auto-generated handlers ──────────────────────────────
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count == 0)
                return;

            var selectedTitle = listViewProjects.SelectedItems[0].Text;

            var data = DataManager<Project>.Entities
                .Where(p => p.Title == selectedTitle)
                .Select(p => $"Ttile: {p.Title} | Genre: {p.Genre} | Budget: {p.Budget:F2}")
                .FirstOrDefault();

            if (!string.IsNullOrEmpty(data))
                MaterialMessageBox.Show(data);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void materialMultiLineTextBox22_Click(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void txtBudget_Click(object sender, EventArgs e) { }
        private void materialMultiLineTextBox21_Click(object sender, EventArgs e) { }
        private void materialLabel3_Click(object sender, EventArgs e) { }
        private void materialLabel4_Click(object sender, EventArgs e) { }
        private void materialLabel5_Click(object sender, EventArgs e) { }
        private void materialLabel6_Click(object sender, EventArgs e) { }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager<Project>.Entities.Any())
                    return;

                listViewProjects.Items.Clear();

                decimal.TryParse(budgetFromTextBox.Text, out decimal from);
                decimal.TryParse(budgetToTextBox.Text, out decimal to);

                var foundEntities = DataManager<Project>.Entities.Where(e =>
                    (string.IsNullOrEmpty(searchTextBox.Text) || e.Search(searchTextBox.Text)) &&
                    (string.IsNullOrEmpty(budgetFromTextBox.Text) || e.Budget >= from) &&
                    (string.IsNullOrEmpty(budgetToTextBox.Text) || e.Budget <= to)
                );

                foreach (var project in foundEntities)
                {
                    var item = new ListViewItem(project.Title ?? "");
                    item.SubItems.Add(project.Genre ?? "");
                    item.SubItems.Add(project.Status ?? "");
                    item.SubItems.Add(project.StartDate?.ToString("dd/MM/yyyy") ?? "");
                    item.SubItems.Add(project.Deadline?.ToString("dd/MM/yyyy") ?? "");
                    item.SubItems.Add(project.Budget.ToString("F2"));
                    listViewProjects.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Helper method to display a list of projects in the ListView
        private void DisplayProjects(IEnumerable<Project> projects)
        {
            listViewProjects.Items.Clear();
            foreach (var project in projects)
            {
                var item = new ListViewItem(project.Title ?? "");
                item.SubItems.Add(project.Genre ?? "");
                item.SubItems.Add(project.Status ?? "");
                item.SubItems.Add(project.StartDate?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(project.Deadline?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(project.Budget.ToString("F2"));
                listViewProjects.Items.Add(item);
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            var sorted = DataManager<Project>.Entities.OrderBy(p => p.Title).ThenBy(p => p.Genre);
            DisplayProjects(sorted);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var sorted = DataManager<Project>.Entities.OrderByDescending(p => p.Title).ThenByDescending(p => p.Genre);

            DisplayProjects(sorted);
        }

        private const int PAGE_LIMIT = 5;
        private int currentPage = 0;

        private void Paginate()
        {
            listViewProjects.Items.Clear();

            var data = DataManager<Project>.Entities
                .OrderBy(p => p.Title)
                .ThenByDescending(p => p.Deadline)
                .Skip(currentPage * PAGE_LIMIT)
                .Take(PAGE_LIMIT)
                .ToList();

            data.ForEach(p =>
            {
                var item = new ListViewItem(p.Title ?? "");
                item.SubItems.Add(p.Genre ?? "");
                item.SubItems.Add(p.Status ?? "");
                item.SubItems.Add(p.StartDate?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(p.Deadline?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(p.Budget.ToString("F2"));
                listViewProjects.Items.Add(item);
            });

            pageNumberTextBox.Text = (currentPage + 1).ToString();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paginate();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                Paginate();
            }
        }

        private void pageNumberTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CalculateStatistics()
        {
            var projectCount = DataManager<Project>.Entities.Count();

            var maxBudget = DataManager<Project>.Entities.Any()
                ? DataManager<Project>.Entities.Max(p => p.Budget)
                : 0;

            countTextBox.Text = projectCount.ToString();
            maxBudgetTextBox.Text = maxBudget.ToString("F2");
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void loadSourceButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Load projects from the selected file
                var otherProjects = FileManager.LoadAll<Project>(openFileDialog.FileName);

                // Get the IDs of projects we already have
                var currentIds = DataManager<Project>.Entities.Select(p => p.Id);

                // ExceptBy removes any projects from otherProjects whose ID already exists
                // This prevents duplicates when merging the two sources
                var uniqueNewProjects = otherProjects.ExceptBy(currentIds, p => p.Id);

                // Concat merges the two collections together
                foreach (var p in uniqueNewProjects)
                    DataManager<Project>.Add(p);

                Paginate();
                CalculateStatistics();
            }
        }
    }
}