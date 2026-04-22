using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                DataManager.Add(project);

                txtTitle.Clear();
                txtBudget.Clear();
                txtStatus.Clear();
                txtGenre.Clear();

                RefreshProjectList();
                MaterialMessageBox.Show("Project added successfully!");
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RefreshProjectList()
        {
            listViewProjects.Items.Clear();

            List<Project> projects = FileManager.LoadAll<Project>();

            foreach (var p in projects)
            {
                if (!DataManager.Entities.Contains(p))

                    DataManager.Add(p);
            }

            foreach (var p in projects)
            {
                var item = new ListViewItem(p.Title ?? "");
                item.SubItems.Add(p.Genre ?? "");
                item.SubItems.Add(p.Status ?? "");
                item.SubItems.Add(p.StartDate?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(p.Deadline?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(p.Budget.ToString("F2"));
                listViewProjects.Items.Add(item);
            }
        }


        // ── unused auto-generated handlers ──────────────────────────────
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count == 0)
                return;

            var selectedTitle = listViewProjects.SelectedItems[0].Text;

            var project = DataManager.Entities
                .OfType<Project>()
                .FirstOrDefault(p => p.Title == selectedTitle);

            if (project != null)
            {
                IEntity entity = project;
                MaterialMessageBox.Show(
                    $"Accessed via indexer:\n" +
                    $"[0] Title: {entity[0]}\n" +
                    $"[1] Genre: {entity[1]}\n" +
                    $"[2] Status: {entity[2]}\n" +
                    $"[3] Budget: {entity[3]}"
                );
            }
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
                if (!DataManager.Entities.Any())
                    return;

                listViewProjects.Items.Clear();

                IEnumerable<IEntity> foundEntities;

                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    foundEntities = DataManager.Entities;
                }
                else
                {
                    foundEntities = DataManager.Search(searchTextBox.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    var project = entity as Project;
                    if (project != null)
                    {
                        var item = new ListViewItem(project.Title ?? "");
                        item.SubItems.Add(project.Genre ?? "");
                        item.SubItems.Add(project.Status ?? "");
                        item.SubItems.Add(project.StartDate?.ToString("dd/MM/yyyy") ?? "");
                        item.SubItems.Add(project.Deadline?.ToString("dd/MM/yyyy") ?? "");
                        listViewProjects.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error: {ex.Message}");
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

        private bool FilterProjectsByBudget(IEntity entity)
        {
            if (!decimal.TryParse(budgetFromTextBox.Text, out decimal from))
                from = decimal.MinValue;
            if (!decimal.TryParse(budgetToTextBox.Text, out decimal to))
                to = decimal.MaxValue;

            if (entity is Project project && project.Budget > 0)
                return project.Budget >= from && project.Budget <= to;

            return false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager.Entities.Any())
                    return;

                listViewProjects.Items.Clear();

                IEnumerable<IEntity> filteredEntities;

                if (string.IsNullOrEmpty(budgetFromTextBox.Text) ||
                    string.IsNullOrEmpty(budgetToTextBox.Text))
                {
                    filteredEntities = DataManager.Entities;
                }
                else
                {
                    //filteredEntities = DataManager.Filter(FilterProjectsByBudget);

                    ////Anonymous method
                    //filteredEntities = DataManager.Filter(
                    //    delegate (IEntity entity)
                    //    {
                    //        if (!decimal.TryParse(budgetFromTextBox.Text, out decimal from))
                    //            from = decimal.MinValue;
                    //        if (!decimal.TryParse(budgetToTextBox.Text, out decimal to))
                    //            to = decimal.MaxValue;

                    //        if (entity is Project project && project.Budget > 0)
                    //            return project.Budget >= from && project.Budget <= to;
                    //        return false;
                    //    });


                    //lambda
                    filteredEntities = DataManager.Filter(entity =>
                    {
                        if (!decimal.TryParse(budgetFromTextBox.Text, out decimal from))
                            from = decimal.MinValue;
                        if (!decimal.TryParse(budgetToTextBox.Text, out decimal to))
                            to = decimal.MaxValue;
                        if (entity is Project project && project.Budget > 0)
                            return project.Budget >= from && project.Budget <= to;
                        return false;
                    });
                }

                foreach (IEntity entity in filteredEntities)
                {
                    if (entity is Project p)
                    {
                        var item = new ListViewItem(p.Title ?? "");
                        item.SubItems.Add(p.Genre ?? "");
                        item.SubItems.Add(p.Status ?? "");
                        item.SubItems.Add(p.StartDate?.ToString("dd/MM/yyyy") ?? "");
                        item.SubItems.Add(p.Deadline?.ToString("dd/MM/yyyy") ?? "");
                        item.SubItems.Add(p.Budget.ToString("F2"));
                        listViewProjects.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}