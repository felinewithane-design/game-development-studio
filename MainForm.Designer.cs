namespace game_development_studio
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewProjects = new MaterialSkin.Controls.MaterialListView();
            Title = new ColumnHeader();
            Genre = new ColumnHeader();
            Status = new ColumnHeader();
            StartDate = new ColumnHeader();
            Deadline = new ColumnHeader();
            txtBudget = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtTitle = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            dtpDeadline = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnADDPROJECT = new MaterialSkin.Controls.MaterialButton();
            txtStatus = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtGenre = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // listViewProjects
            // 
            listViewProjects.AutoSizeTable = false;
            listViewProjects.BackColor = Color.FromArgb(255, 255, 255);
            listViewProjects.BorderStyle = BorderStyle.None;
            listViewProjects.Columns.AddRange(new ColumnHeader[] { Title, Genre, Status, StartDate, Deadline });
            listViewProjects.Depth = 0;
            listViewProjects.FullRowSelect = true;
            listViewProjects.Location = new Point(6, 77);
            listViewProjects.MinimumSize = new Size(200, 100);
            listViewProjects.MouseLocation = new Point(-1, -1);
            listViewProjects.MouseState = MaterialSkin.MouseState.OUT;
            listViewProjects.Name = "listViewProjects";
            listViewProjects.OwnerDraw = true;
            listViewProjects.Size = new Size(655, 477);
            listViewProjects.TabIndex = 0;
            listViewProjects.UseCompatibleStateImageBehavior = false;
            listViewProjects.View = View.Details;
            listViewProjects.SelectedIndexChanged += materialListView1_SelectedIndexChanged;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 150;
            // 
            // Genre
            // 
            Genre.Text = "Gennre";
            Genre.Width = 100;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 100;
            // 
            // StartDate
            // 
            StartDate.Text = "Start Date";
            StartDate.Width = 120;
            // 
            // Deadline
            // 
            Deadline.Text = "Deadline";
            Deadline.Width = 120;
            // 
            // txtBudget
            // 
            txtBudget.AnimateReadOnly = false;
            txtBudget.BackgroundImageLayout = ImageLayout.None;
            txtBudget.CharacterCasing = CharacterCasing.Normal;
            txtBudget.Depth = 0;
            txtBudget.HideSelection = true;
            txtBudget.Location = new Point(667, 142);
            txtBudget.MaxLength = 32767;
            txtBudget.MouseState = MaterialSkin.MouseState.OUT;
            txtBudget.Name = "txtBudget";
            txtBudget.PasswordChar = '\0';
            txtBudget.ReadOnly = false;
            txtBudget.ScrollBars = ScrollBars.None;
            txtBudget.SelectedText = "";
            txtBudget.SelectionLength = 0;
            txtBudget.SelectionStart = 0;
            txtBudget.ShortcutsEnabled = true;
            txtBudget.Size = new Size(245, 50);
            txtBudget.TabIndex = 1;
            txtBudget.TabStop = false;
            txtBudget.TextAlign = HorizontalAlignment.Left;
            txtBudget.UseSystemPasswordChar = false;
            txtBudget.Click += txtBudget_Click;
            // 
            // txtTitle
            // 
            txtTitle.AnimateReadOnly = false;
            txtTitle.BackgroundImageLayout = ImageLayout.None;
            txtTitle.CharacterCasing = CharacterCasing.Normal;
            txtTitle.Depth = 0;
            txtTitle.HideSelection = true;
            txtTitle.Location = new Point(667, 86);
            txtTitle.MaxLength = 32767;
            txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            txtTitle.Name = "txtTitle";
            txtTitle.PasswordChar = '\0';
            txtTitle.ReadOnly = false;
            txtTitle.ScrollBars = ScrollBars.None;
            txtTitle.SelectedText = "";
            txtTitle.SelectionLength = 0;
            txtTitle.SelectionStart = 0;
            txtTitle.ShortcutsEnabled = true;
            txtTitle.Size = new Size(245, 50);
            txtTitle.TabIndex = 2;
            txtTitle.TabStop = false;
            txtTitle.TextAlign = HorizontalAlignment.Left;
            txtTitle.UseSystemPasswordChar = false;
            txtTitle.Click += materialMultiLineTextBox22_Click;
            // 
            // dtpDeadline
            // 
            dtpDeadline.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpDeadline.Format = DateTimePickerFormat.Custom;
            dtpDeadline.Location = new Point(689, 369);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(260, 27);
            dtpDeadline.TabIndex = 3;
            dtpDeadline.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(690, 419);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(260, 27);
            dtpStartDate.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(918, 77);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Title";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(918, 142);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(51, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Budget";
            // 
            // btnADDPROJECT
            // 
            btnADDPROJECT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnADDPROJECT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnADDPROJECT.Depth = 0;
            btnADDPROJECT.HighEmphasis = true;
            btnADDPROJECT.Icon = null;
            btnADDPROJECT.Location = new Point(727, 552);
            btnADDPROJECT.Margin = new Padding(4, 6, 4, 6);
            btnADDPROJECT.MouseState = MaterialSkin.MouseState.HOVER;
            btnADDPROJECT.Name = "btnADDPROJECT";
            btnADDPROJECT.NoAccentTextColor = Color.Empty;
            btnADDPROJECT.Size = new Size(118, 36);
            btnADDPROJECT.TabIndex = 7;
            btnADDPROJECT.Text = "ADD PROJECT";
            btnADDPROJECT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnADDPROJECT.UseAccentColor = false;
            btnADDPROJECT.UseVisualStyleBackColor = true;
            btnADDPROJECT.Click += btnADDPROJECT_Click;
            // 
            // txtStatus
            // 
            txtStatus.AnimateReadOnly = false;
            txtStatus.BackgroundImageLayout = ImageLayout.None;
            txtStatus.CharacterCasing = CharacterCasing.Normal;
            txtStatus.Depth = 0;
            txtStatus.HideSelection = true;
            txtStatus.Location = new Point(667, 198);
            txtStatus.MaxLength = 32767;
            txtStatus.MouseState = MaterialSkin.MouseState.OUT;
            txtStatus.Name = "txtStatus";
            txtStatus.PasswordChar = '\0';
            txtStatus.ReadOnly = false;
            txtStatus.ScrollBars = ScrollBars.None;
            txtStatus.SelectedText = "";
            txtStatus.SelectionLength = 0;
            txtStatus.SelectionStart = 0;
            txtStatus.ShortcutsEnabled = true;
            txtStatus.Size = new Size(245, 50);
            txtStatus.TabIndex = 8;
            txtStatus.TabStop = false;
            txtStatus.TextAlign = HorizontalAlignment.Left;
            txtStatus.UseSystemPasswordChar = false;
            txtStatus.Click += materialMultiLineTextBox21_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(918, 198);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(47, 19);
            materialLabel3.TabIndex = 9;
            materialLabel3.Text = "Status";
            materialLabel3.Click += materialLabel3_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(956, 419);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(72, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Start Date";
            materialLabel4.Click += materialLabel4_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(955, 369);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(63, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Deadline";
            materialLabel5.Click += materialLabel5_Click;
            // 
            // txtGenre
            // 
            txtGenre.AnimateReadOnly = false;
            txtGenre.BackgroundImageLayout = ImageLayout.None;
            txtGenre.CharacterCasing = CharacterCasing.Normal;
            txtGenre.Depth = 0;
            txtGenre.HideSelection = true;
            txtGenre.Location = new Point(667, 254);
            txtGenre.MaxLength = 32767;
            txtGenre.MouseState = MaterialSkin.MouseState.OUT;
            txtGenre.Name = "txtGenre";
            txtGenre.PasswordChar = '\0';
            txtGenre.ReadOnly = false;
            txtGenre.ScrollBars = ScrollBars.None;
            txtGenre.SelectedText = "";
            txtGenre.SelectionLength = 0;
            txtGenre.SelectionStart = 0;
            txtGenre.ShortcutsEnabled = true;
            txtGenre.Size = new Size(245, 50);
            txtGenre.TabIndex = 12;
            txtGenre.TabStop = false;
            txtGenre.TextAlign = HorizontalAlignment.Left;
            txtGenre.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(918, 254);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(42, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Genre";
            materialLabel6.Click += materialLabel6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 643);
            Controls.Add(materialLabel6);
            Controls.Add(txtGenre);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(txtStatus);
            Controls.Add(btnADDPROJECT);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpDeadline);
            Controls.Add(txtTitle);
            Controls.Add(txtBudget);
            Controls.Add(listViewProjects);
            Name = "MainForm";
            Text = "Game Development Studio";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewProjects;
        private ColumnHeader Title;
        private ColumnHeader Genre;
        private ColumnHeader Status;
        private ColumnHeader StartDate;
        private ColumnHeader Deadline;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBudget;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtTitle;
        private DateTimePicker dtpDeadline;
        private DateTimePicker dtpStartDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnADDPROJECT;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtGenre;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }

}