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
                var item = new ListViewItem(p.Title ?? "");
                item.SubItems.Add(p.Genre ?? "");
                item.SubItems.Add(p.Status ?? "");
                item.SubItems.Add(p.StartDate?.ToString("dd/MM/yyyy") ?? "");
                item.SubItems.Add(p.Deadline?.ToString("dd/MM/yyyy") ?? "");
                listViewProjects.Items.Add(item);
            }
        }

        // ── unused auto-generated handlers ──────────────────────────────
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void materialMultiLineTextBox22_Click(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void txtBudget_Click(object sender, EventArgs e) { }
        private void materialMultiLineTextBox21_Click(object sender, EventArgs e) { }
        private void materialLabel3_Click(object sender, EventArgs e) { }
        private void materialLabel4_Click(object sender, EventArgs e) { }
        private void materialLabel5_Click(object sender, EventArgs e) { }
        private void materialLabel6_Click(object sender, EventArgs e) { }
    }
}