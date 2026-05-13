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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            listViewProjects = new MaterialSkin.Controls.MaterialListView();
            Title = new ColumnHeader();
            Genre = new ColumnHeader();
            Status = new ColumnHeader();
            StartDate = new ColumnHeader();
            Deadline = new ColumnHeader();
            Budget = new ColumnHeader();
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
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            budgetFromTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            budgetToTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            prevButton = new MaterialSkin.Controls.MaterialButton();
            nextButton = new MaterialSkin.Controls.MaterialButton();
            pageNumberTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            countTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            maxBudgetTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            loadSourceButton = new MaterialSkin.Controls.MaterialButton();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // listViewProjects
            // 
            listViewProjects.AutoSizeTable = false;
            listViewProjects.BackColor = Color.FromArgb(255, 255, 255);
            listViewProjects.BorderStyle = BorderStyle.None;
            listViewProjects.Columns.AddRange(new ColumnHeader[] { Title, Genre, Status, StartDate, Deadline, Budget });
            listViewProjects.Depth = 0;
            listViewProjects.FullRowSelect = true;
            listViewProjects.Location = new Point(6, 201);
            listViewProjects.MinimumSize = new Size(200, 100);
            listViewProjects.MouseLocation = new Point(-1, -1);
            listViewProjects.MouseState = MaterialSkin.MouseState.OUT;
            listViewProjects.Name = "listViewProjects";
            listViewProjects.OwnerDraw = true;
            listViewProjects.Size = new Size(829, 436);
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
            // Budget
            // 
            Budget.Text = "Budget";
            Budget.Width = 120;
            // 
            // txtBudget
            // 
            txtBudget.AnimateReadOnly = false;
            txtBudget.BackgroundImageLayout = ImageLayout.None;
            txtBudget.CharacterCasing = CharacterCasing.Normal;
            txtBudget.Depth = 0;
            txtBudget.HideSelection = true;
            txtBudget.Location = new Point(945, 142);
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
            txtBudget.Size = new Size(245, 53);
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
            txtTitle.Location = new Point(945, 86);
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
            dtpDeadline.Location = new Point(930, 369);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(260, 27);
            dtpDeadline.TabIndex = 3;
            dtpDeadline.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(930, 419);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(260, 27);
            dtpStartDate.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(1196, 86);
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
            materialLabel2.Location = new Point(1196, 142);
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
            btnADDPROJECT.Location = new Point(930, 455);
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
            txtStatus.Location = new Point(945, 201);
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
            materialLabel3.Location = new Point(1196, 198);
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
            materialLabel4.Location = new Point(1196, 419);
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
            materialLabel5.Location = new Point(1205, 369);
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
            txtGenre.Location = new Point(945, 257);
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
            materialLabel6.Location = new Point(1196, 254);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(42, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Genre";
            materialLabel6.Click += materialLabel6_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.HideSelection = true;
            searchTextBox.Hint = "Search for project...";
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(27, 88);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffixText = null;
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.No;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(312, 48);
            searchTextBox.TabIndex = 14;
            searchTextBox.TabStop = false;
            searchTextBox.Text = "type here";
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.Click += searchTextBox_Click;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = (Image)resources.GetObject("searchButton.Icon");
            searchButton.Location = new Point(346, 100);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Size = new Size(64, 36);
            searchButton.TabIndex = 15;
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // budgetFromTextBox
            // 
            budgetFromTextBox.AnimateReadOnly = false;
            budgetFromTextBox.BackgroundImageLayout = ImageLayout.None;
            budgetFromTextBox.CharacterCasing = CharacterCasing.Normal;
            budgetFromTextBox.Depth = 0;
            budgetFromTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            budgetFromTextBox.HideSelection = true;
            budgetFromTextBox.LeadingIcon = null;
            budgetFromTextBox.Location = new Point(456, 126);
            budgetFromTextBox.MaxLength = 32767;
            budgetFromTextBox.MouseState = MaterialSkin.MouseState.OUT;
            budgetFromTextBox.Name = "budgetFromTextBox";
            budgetFromTextBox.PasswordChar = '\0';
            budgetFromTextBox.PrefixSuffixText = null;
            budgetFromTextBox.ReadOnly = false;
            budgetFromTextBox.RightToLeft = RightToLeft.No;
            budgetFromTextBox.SelectedText = "";
            budgetFromTextBox.SelectionLength = 0;
            budgetFromTextBox.SelectionStart = 0;
            budgetFromTextBox.ShortcutsEnabled = true;
            budgetFromTextBox.Size = new Size(164, 48);
            budgetFromTextBox.TabIndex = 16;
            budgetFromTextBox.TabStop = false;
            budgetFromTextBox.TextAlign = HorizontalAlignment.Left;
            budgetFromTextBox.TrailingIcon = null;
            budgetFromTextBox.UseSystemPasswordChar = false;
            // 
            // budgetToTextBox
            // 
            budgetToTextBox.AnimateReadOnly = false;
            budgetToTextBox.BackgroundImageLayout = ImageLayout.None;
            budgetToTextBox.CharacterCasing = CharacterCasing.Normal;
            budgetToTextBox.Depth = 0;
            budgetToTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            budgetToTextBox.HideSelection = true;
            budgetToTextBox.LeadingIcon = null;
            budgetToTextBox.Location = new Point(671, 126);
            budgetToTextBox.MaxLength = 32767;
            budgetToTextBox.MouseState = MaterialSkin.MouseState.OUT;
            budgetToTextBox.Name = "budgetToTextBox";
            budgetToTextBox.PasswordChar = '\0';
            budgetToTextBox.PrefixSuffixText = null;
            budgetToTextBox.ReadOnly = false;
            budgetToTextBox.RightToLeft = RightToLeft.No;
            budgetToTextBox.SelectedText = "";
            budgetToTextBox.SelectionLength = 0;
            budgetToTextBox.SelectionStart = 0;
            budgetToTextBox.ShortcutsEnabled = true;
            budgetToTextBox.Size = new Size(164, 48);
            budgetToTextBox.TabIndex = 17;
            budgetToTextBox.TabStop = false;
            budgetToTextBox.TextAlign = HorizontalAlignment.Left;
            budgetToTextBox.TrailingIcon = null;
            budgetToTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(514, 104);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(38, 19);
            materialLabel7.TabIndex = 18;
            materialLabel7.Text = "From";
            materialLabel7.Click += materialLabel7_Click;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(686, 104);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(20, 19);
            materialLabel8.TabIndex = 19;
            materialLabel8.Text = "To";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(640, 142);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(5, 19);
            materialLabel9.TabIndex = 20;
            materialLabel9.Text = "-";
            materialLabel9.Click += materialLabel9_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(475, 75);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(77, 19);
            materialLabel10.TabIndex = 21;
            materialLabel10.Text = "Set budget";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = (Image)resources.GetObject("materialButton1.Icon");
            materialButton1.Location = new Point(853, 93);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 22;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = (Image)resources.GetObject("materialButton2.Icon");
            materialButton2.Location = new Point(853, 142);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 23;
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // prevButton
            // 
            prevButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prevButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prevButton.Depth = 0;
            prevButton.HighEmphasis = true;
            prevButton.Icon = null;
            prevButton.Location = new Point(818, 676);
            prevButton.Margin = new Padding(4, 6, 4, 6);
            prevButton.MouseState = MaterialSkin.MouseState.HOVER;
            prevButton.Name = "prevButton";
            prevButton.NoAccentTextColor = Color.Empty;
            prevButton.Size = new Size(64, 36);
            prevButton.TabIndex = 0;
            prevButton.Text = "PREV";
            prevButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevButton.UseAccentColor = false;
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextButton.Depth = 0;
            nextButton.HighEmphasis = true;
            nextButton.Icon = null;
            nextButton.Location = new Point(1251, 676);
            nextButton.Margin = new Padding(4, 6, 4, 6);
            nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            nextButton.Name = "nextButton";
            nextButton.NoAccentTextColor = Color.Empty;
            nextButton.Size = new Size(64, 36);
            nextButton.TabIndex = 24;
            nextButton.Text = "NEXT";
            nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextButton.UseAccentColor = false;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.AnimateReadOnly = false;
            pageNumberTextBox.BackgroundImageLayout = ImageLayout.None;
            pageNumberTextBox.CharacterCasing = CharacterCasing.Normal;
            pageNumberTextBox.Depth = 0;
            pageNumberTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pageNumberTextBox.HideSelection = true;
            pageNumberTextBox.LeadingIcon = null;
            pageNumberTextBox.Location = new Point(916, 676);
            pageNumberTextBox.MaxLength = 32767;
            pageNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.PasswordChar = '\0';
            pageNumberTextBox.PrefixSuffixText = null;
            pageNumberTextBox.ReadOnly = true;
            pageNumberTextBox.RightToLeft = RightToLeft.No;
            pageNumberTextBox.SelectedText = "";
            pageNumberTextBox.SelectionLength = 0;
            pageNumberTextBox.SelectionStart = 0;
            pageNumberTextBox.ShortcutsEnabled = true;
            pageNumberTextBox.Size = new Size(312, 48);
            pageNumberTextBox.TabIndex = 25;
            pageNumberTextBox.TabStop = false;
            pageNumberTextBox.Text = "1";
            pageNumberTextBox.TextAlign = HorizontalAlignment.Left;
            pageNumberTextBox.TrailingIcon = null;
            pageNumberTextBox.UseSystemPasswordChar = false;
            pageNumberTextBox.Click += pageNumberTextBox_Click;
            // 
            // countTextBox
            // 
            countTextBox.AnimateReadOnly = false;
            countTextBox.BackgroundImageLayout = ImageLayout.None;
            countTextBox.CharacterCasing = CharacterCasing.Normal;
            countTextBox.Depth = 0;
            countTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            countTextBox.HideSelection = true;
            countTextBox.LeadingIcon = null;
            countTextBox.Location = new Point(36, 676);
            countTextBox.MaxLength = 32767;
            countTextBox.MouseState = MaterialSkin.MouseState.OUT;
            countTextBox.Name = "countTextBox";
            countTextBox.PasswordChar = '\0';
            countTextBox.PrefixSuffixText = null;
            countTextBox.ReadOnly = true;
            countTextBox.RightToLeft = RightToLeft.No;
            countTextBox.SelectedText = "";
            countTextBox.SelectionLength = 0;
            countTextBox.SelectionStart = 0;
            countTextBox.ShortcutsEnabled = true;
            countTextBox.Size = new Size(131, 48);
            countTextBox.TabIndex = 26;
            countTextBox.TabStop = false;
            countTextBox.Text = "count";
            countTextBox.TextAlign = HorizontalAlignment.Left;
            countTextBox.TrailingIcon = null;
            countTextBox.UseSystemPasswordChar = false;
            // 
            // maxBudgetTextBox
            // 
            maxBudgetTextBox.AnimateReadOnly = false;
            maxBudgetTextBox.BackgroundImageLayout = ImageLayout.None;
            maxBudgetTextBox.CharacterCasing = CharacterCasing.Normal;
            maxBudgetTextBox.Depth = 0;
            maxBudgetTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maxBudgetTextBox.HideSelection = true;
            maxBudgetTextBox.LeadingIcon = null;
            maxBudgetTextBox.Location = new Point(194, 676);
            maxBudgetTextBox.MaxLength = 32767;
            maxBudgetTextBox.MouseState = MaterialSkin.MouseState.OUT;
            maxBudgetTextBox.Name = "maxBudgetTextBox";
            maxBudgetTextBox.PasswordChar = '\0';
            maxBudgetTextBox.PrefixSuffixText = null;
            maxBudgetTextBox.ReadOnly = true;
            maxBudgetTextBox.RightToLeft = RightToLeft.No;
            maxBudgetTextBox.SelectedText = "";
            maxBudgetTextBox.SelectionLength = 0;
            maxBudgetTextBox.SelectionStart = 0;
            maxBudgetTextBox.ShortcutsEnabled = true;
            maxBudgetTextBox.Size = new Size(131, 48);
            maxBudgetTextBox.TabIndex = 27;
            maxBudgetTextBox.TabStop = false;
            maxBudgetTextBox.Text = "budget";
            maxBudgetTextBox.TextAlign = HorizontalAlignment.Left;
            maxBudgetTextBox.TrailingIcon = null;
            maxBudgetTextBox.UseSystemPasswordChar = false;
            // 
            // loadSourceButton
            // 
            loadSourceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadSourceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadSourceButton.Depth = 0;
            loadSourceButton.HighEmphasis = true;
            loadSourceButton.Icon = null;
            loadSourceButton.Location = new Point(930, 554);
            loadSourceButton.Margin = new Padding(4, 6, 4, 6);
            loadSourceButton.MouseState = MaterialSkin.MouseState.HOVER;
            loadSourceButton.Name = "loadSourceButton";
            loadSourceButton.NoAccentTextColor = Color.Empty;
            loadSourceButton.Size = new Size(158, 36);
            loadSourceButton.TabIndex = 28;
            loadSourceButton.Text = "load another source";
            loadSourceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loadSourceButton.UseAccentColor = false;
            loadSourceButton.UseVisualStyleBackColor = true;
            loadSourceButton.Click += loadSourceButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 768);
            Controls.Add(loadSourceButton);
            Controls.Add(maxBudgetTextBox);
            Controls.Add(countTextBox);
            Controls.Add(pageNumberTextBox);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel10);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(budgetToTextBox);
            Controls.Add(budgetFromTextBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
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
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private ColumnHeader Budget;
        private MaterialSkin.Controls.MaterialTextBox2 budgetFromTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 budgetToTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton prevButton;
        private MaterialSkin.Controls.MaterialButton nextButton;
        private MaterialSkin.Controls.MaterialTextBox2 pageNumberTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 countTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 maxBudgetTextBox;
        private MaterialSkin.Controls.MaterialButton loadSourceButton;
        private OpenFileDialog openFileDialog;
    }

}