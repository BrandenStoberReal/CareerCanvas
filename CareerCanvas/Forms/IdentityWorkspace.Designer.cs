namespace CareerCanvas.Forms
{
    partial class IdentityWorkspace
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exportToToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            firstNameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            firstNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            middleNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            middleNametextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lastNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            lastNameTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            addressLabel = new ReaLTaiizor.Controls.MaterialLabel();
            addressTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cityLabel = new ReaLTaiizor.Controls.MaterialLabel();
            cityTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            stateLabel = new ReaLTaiizor.Controls.MaterialLabel();
            stateTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            zipLabel = new ReaLTaiizor.Controls.MaterialLabel();
            zipTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            phoneLabel = new ReaLTaiizor.Controls.MaterialLabel();
            phoneTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            emailLabel = new ReaLTaiizor.Controls.MaterialLabel();
            emailTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            linkedInLabel = new ReaLTaiizor.Controls.MaterialLabel();
            linkedInTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            portfolioLabel = new ReaLTaiizor.Controls.MaterialLabel();
            portfolioTextBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(3, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exportToToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exportToToolStripMenuItem
            // 
            exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            exportToToolStripMenuItem.Size = new Size(180, 22);
            exportToToolStripMenuItem.Text = "Export to JSON";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Anchor = AnchorStyles.Left;
            firstNameTextBox.AnimateReadOnly = false;
            firstNameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            firstNameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            firstNameTextBox.BackgroundImageLayout = ImageLayout.None;
            firstNameTextBox.CharacterCasing = CharacterCasing.Normal;
            firstNameTextBox.Depth = 0;
            firstNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstNameTextBox.HideSelection = true;
            firstNameTextBox.LeadingIcon = null;
            firstNameTextBox.Location = new Point(96, 3);
            firstNameTextBox.MaxLength = 32767;
            firstNameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PasswordChar = '\0';
            firstNameTextBox.PrefixSuffixText = null;
            firstNameTextBox.ReadOnly = false;
            firstNameTextBox.RightToLeft = RightToLeft.No;
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.SelectionLength = 0;
            firstNameTextBox.SelectionStart = 0;
            firstNameTextBox.ShortcutsEnabled = true;
            firstNameTextBox.Size = new Size(250, 48);
            firstNameTextBox.TabIndex = 100;
            firstNameTextBox.TabStop = false;
            firstNameTextBox.TextAlign = HorizontalAlignment.Left;
            firstNameTextBox.TrailingIcon = null;
            firstNameTextBox.UseSystemPasswordChar = false;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Left;
            firstNameLabel.Depth = 0;
            firstNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstNameLabel.Location = new Point(3, 3);
            firstNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(87, 48);
            firstNameLabel.TabIndex = 101;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // middleNameLabel
            // 
            middleNameLabel.Anchor = AnchorStyles.Left;
            middleNameLabel.Depth = 0;
            middleNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            middleNameLabel.Location = new Point(3, 57);
            middleNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(104, 48);
            middleNameLabel.TabIndex = 103;
            middleNameLabel.Text = "Middle Name:";
            middleNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // middleNametextBox
            // 
            middleNametextBox.Anchor = AnchorStyles.Left;
            middleNametextBox.AnimateReadOnly = false;
            middleNametextBox.AutoCompleteMode = AutoCompleteMode.None;
            middleNametextBox.AutoCompleteSource = AutoCompleteSource.None;
            middleNametextBox.BackgroundImageLayout = ImageLayout.None;
            middleNametextBox.CharacterCasing = CharacterCasing.Normal;
            middleNametextBox.Depth = 0;
            middleNametextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            middleNametextBox.HideSelection = true;
            middleNametextBox.LeadingIcon = null;
            middleNametextBox.Location = new Point(113, 57);
            middleNametextBox.MaxLength = 32767;
            middleNametextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            middleNametextBox.Name = "middleNametextBox";
            middleNametextBox.PasswordChar = '\0';
            middleNametextBox.PrefixSuffixText = null;
            middleNametextBox.ReadOnly = false;
            middleNametextBox.RightToLeft = RightToLeft.No;
            middleNametextBox.SelectedText = "";
            middleNametextBox.SelectionLength = 0;
            middleNametextBox.SelectionStart = 0;
            middleNametextBox.ShortcutsEnabled = true;
            middleNametextBox.Size = new Size(250, 48);
            middleNametextBox.TabIndex = 102;
            middleNametextBox.TabStop = false;
            middleNametextBox.TextAlign = HorizontalAlignment.Left;
            middleNametextBox.TrailingIcon = null;
            middleNametextBox.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(firstNameLabel);
            flowLayoutPanel1.Controls.Add(firstNameTextBox);
            flowLayoutPanel1.Controls.Add(middleNameLabel);
            flowLayoutPanel1.Controls.Add(middleNametextBox);
            flowLayoutPanel1.Controls.Add(lastNameLabel);
            flowLayoutPanel1.Controls.Add(lastNameTextBox);
            flowLayoutPanel1.Controls.Add(addressLabel);
            flowLayoutPanel1.Controls.Add(addressTextBox);
            flowLayoutPanel1.Controls.Add(cityLabel);
            flowLayoutPanel1.Controls.Add(cityTextBox);
            flowLayoutPanel1.Controls.Add(stateLabel);
            flowLayoutPanel1.Controls.Add(stateTextBox);
            flowLayoutPanel1.Controls.Add(zipLabel);
            flowLayoutPanel1.Controls.Add(zipTextBox);
            flowLayoutPanel1.Controls.Add(phoneLabel);
            flowLayoutPanel1.Controls.Add(phoneTextBox);
            flowLayoutPanel1.Controls.Add(emailLabel);
            flowLayoutPanel1.Controls.Add(emailTextBox);
            flowLayoutPanel1.Controls.Add(linkedInLabel);
            flowLayoutPanel1.Controls.Add(linkedInTextBox);
            flowLayoutPanel1.Controls.Add(portfolioLabel);
            flowLayoutPanel1.Controls.Add(portfolioTextBox);
            flowLayoutPanel1.Location = new Point(6, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(430, 636);
            flowLayoutPanel1.TabIndex = 104;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Left;
            lastNameLabel.Depth = 0;
            lastNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameLabel.Location = new Point(3, 111);
            lastNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(87, 48);
            lastNameLabel.TabIndex = 105;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Left;
            lastNameTextBox.AnimateReadOnly = false;
            lastNameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            lastNameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            lastNameTextBox.BackgroundImageLayout = ImageLayout.None;
            lastNameTextBox.CharacterCasing = CharacterCasing.Normal;
            lastNameTextBox.Depth = 0;
            lastNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameTextBox.HideSelection = true;
            lastNameTextBox.LeadingIcon = null;
            lastNameTextBox.Location = new Point(96, 111);
            lastNameTextBox.MaxLength = 32767;
            lastNameTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PasswordChar = '\0';
            lastNameTextBox.PrefixSuffixText = null;
            lastNameTextBox.ReadOnly = false;
            lastNameTextBox.RightToLeft = RightToLeft.No;
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.SelectionLength = 0;
            lastNameTextBox.SelectionStart = 0;
            lastNameTextBox.ShortcutsEnabled = true;
            lastNameTextBox.Size = new Size(250, 48);
            lastNameTextBox.TabIndex = 104;
            lastNameTextBox.TabStop = false;
            lastNameTextBox.TextAlign = HorizontalAlignment.Left;
            lastNameTextBox.TrailingIcon = null;
            lastNameTextBox.UseSystemPasswordChar = false;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Left;
            addressLabel.Depth = 0;
            addressLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressLabel.Location = new Point(3, 165);
            addressLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(87, 48);
            addressLabel.TabIndex = 107;
            addressLabel.Text = "Address:";
            addressLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Left;
            addressTextBox.AnimateReadOnly = false;
            addressTextBox.AutoCompleteMode = AutoCompleteMode.None;
            addressTextBox.AutoCompleteSource = AutoCompleteSource.None;
            addressTextBox.BackgroundImageLayout = ImageLayout.None;
            addressTextBox.CharacterCasing = CharacterCasing.Normal;
            addressTextBox.Depth = 0;
            addressTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressTextBox.HideSelection = true;
            addressTextBox.LeadingIcon = null;
            addressTextBox.Location = new Point(96, 165);
            addressTextBox.MaxLength = 32767;
            addressTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PasswordChar = '\0';
            addressTextBox.PrefixSuffixText = null;
            addressTextBox.ReadOnly = false;
            addressTextBox.RightToLeft = RightToLeft.No;
            addressTextBox.SelectedText = "";
            addressTextBox.SelectionLength = 0;
            addressTextBox.SelectionStart = 0;
            addressTextBox.ShortcutsEnabled = true;
            addressTextBox.Size = new Size(250, 48);
            addressTextBox.TabIndex = 106;
            addressTextBox.TabStop = false;
            addressTextBox.TextAlign = HorizontalAlignment.Left;
            addressTextBox.TrailingIcon = null;
            addressTextBox.UseSystemPasswordChar = false;
            // 
            // cityLabel
            // 
            cityLabel.Anchor = AnchorStyles.Left;
            cityLabel.Depth = 0;
            cityLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cityLabel.Location = new Point(3, 219);
            cityLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(87, 48);
            cityLabel.TabIndex = 109;
            cityLabel.Text = "City:";
            cityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cityTextBox
            // 
            cityTextBox.Anchor = AnchorStyles.Left;
            cityTextBox.AnimateReadOnly = false;
            cityTextBox.AutoCompleteMode = AutoCompleteMode.None;
            cityTextBox.AutoCompleteSource = AutoCompleteSource.None;
            cityTextBox.BackgroundImageLayout = ImageLayout.None;
            cityTextBox.CharacterCasing = CharacterCasing.Normal;
            cityTextBox.Depth = 0;
            cityTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cityTextBox.HideSelection = true;
            cityTextBox.LeadingIcon = null;
            cityTextBox.Location = new Point(96, 219);
            cityTextBox.MaxLength = 32767;
            cityTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PasswordChar = '\0';
            cityTextBox.PrefixSuffixText = null;
            cityTextBox.ReadOnly = false;
            cityTextBox.RightToLeft = RightToLeft.No;
            cityTextBox.SelectedText = "";
            cityTextBox.SelectionLength = 0;
            cityTextBox.SelectionStart = 0;
            cityTextBox.ShortcutsEnabled = true;
            cityTextBox.Size = new Size(250, 48);
            cityTextBox.TabIndex = 108;
            cityTextBox.TabStop = false;
            cityTextBox.TextAlign = HorizontalAlignment.Left;
            cityTextBox.TrailingIcon = null;
            cityTextBox.UseSystemPasswordChar = false;
            // 
            // stateLabel
            // 
            stateLabel.Anchor = AnchorStyles.Left;
            stateLabel.Depth = 0;
            stateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            stateLabel.Location = new Point(3, 273);
            stateLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(87, 48);
            stateLabel.TabIndex = 111;
            stateLabel.Text = "State:";
            stateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stateTextBox
            // 
            stateTextBox.Anchor = AnchorStyles.Left;
            stateTextBox.AnimateReadOnly = false;
            stateTextBox.AutoCompleteMode = AutoCompleteMode.None;
            stateTextBox.AutoCompleteSource = AutoCompleteSource.None;
            stateTextBox.BackgroundImageLayout = ImageLayout.None;
            stateTextBox.CharacterCasing = CharacterCasing.Normal;
            stateTextBox.Depth = 0;
            stateTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            stateTextBox.HideSelection = true;
            stateTextBox.LeadingIcon = null;
            stateTextBox.Location = new Point(96, 273);
            stateTextBox.MaxLength = 32767;
            stateTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            stateTextBox.Name = "stateTextBox";
            stateTextBox.PasswordChar = '\0';
            stateTextBox.PrefixSuffixText = null;
            stateTextBox.ReadOnly = false;
            stateTextBox.RightToLeft = RightToLeft.No;
            stateTextBox.SelectedText = "";
            stateTextBox.SelectionLength = 0;
            stateTextBox.SelectionStart = 0;
            stateTextBox.ShortcutsEnabled = true;
            stateTextBox.Size = new Size(250, 48);
            stateTextBox.TabIndex = 110;
            stateTextBox.TabStop = false;
            stateTextBox.TextAlign = HorizontalAlignment.Left;
            stateTextBox.TrailingIcon = null;
            stateTextBox.UseSystemPasswordChar = false;
            // 
            // zipLabel
            // 
            zipLabel.Anchor = AnchorStyles.Left;
            zipLabel.Depth = 0;
            zipLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            zipLabel.Location = new Point(3, 327);
            zipLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(87, 48);
            zipLabel.TabIndex = 113;
            zipLabel.Text = "Zip Code:";
            zipLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // zipTextBox
            // 
            zipTextBox.Anchor = AnchorStyles.Left;
            zipTextBox.AnimateReadOnly = false;
            zipTextBox.AutoCompleteMode = AutoCompleteMode.None;
            zipTextBox.AutoCompleteSource = AutoCompleteSource.None;
            zipTextBox.BackgroundImageLayout = ImageLayout.None;
            zipTextBox.CharacterCasing = CharacterCasing.Normal;
            zipTextBox.Depth = 0;
            zipTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            zipTextBox.HideSelection = true;
            zipTextBox.LeadingIcon = null;
            zipTextBox.Location = new Point(96, 327);
            zipTextBox.MaxLength = 32767;
            zipTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            zipTextBox.Name = "zipTextBox";
            zipTextBox.PasswordChar = '\0';
            zipTextBox.PrefixSuffixText = null;
            zipTextBox.ReadOnly = false;
            zipTextBox.RightToLeft = RightToLeft.No;
            zipTextBox.SelectedText = "";
            zipTextBox.SelectionLength = 0;
            zipTextBox.SelectionStart = 0;
            zipTextBox.ShortcutsEnabled = true;
            zipTextBox.Size = new Size(250, 48);
            zipTextBox.TabIndex = 112;
            zipTextBox.TabStop = false;
            zipTextBox.TextAlign = HorizontalAlignment.Left;
            zipTextBox.TrailingIcon = null;
            zipTextBox.UseSystemPasswordChar = false;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Left;
            phoneLabel.Depth = 0;
            phoneLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneLabel.Location = new Point(3, 381);
            phoneLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(87, 48);
            phoneLabel.TabIndex = 115;
            phoneLabel.Text = "Phone #:";
            phoneLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Left;
            phoneTextBox.AnimateReadOnly = false;
            phoneTextBox.AutoCompleteMode = AutoCompleteMode.None;
            phoneTextBox.AutoCompleteSource = AutoCompleteSource.None;
            phoneTextBox.BackgroundImageLayout = ImageLayout.None;
            phoneTextBox.CharacterCasing = CharacterCasing.Normal;
            phoneTextBox.Depth = 0;
            phoneTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneTextBox.HideSelection = true;
            phoneTextBox.LeadingIcon = null;
            phoneTextBox.Location = new Point(96, 381);
            phoneTextBox.MaxLength = 32767;
            phoneTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PasswordChar = '\0';
            phoneTextBox.PrefixSuffixText = null;
            phoneTextBox.ReadOnly = false;
            phoneTextBox.RightToLeft = RightToLeft.No;
            phoneTextBox.SelectedText = "";
            phoneTextBox.SelectionLength = 0;
            phoneTextBox.SelectionStart = 0;
            phoneTextBox.ShortcutsEnabled = true;
            phoneTextBox.Size = new Size(250, 48);
            phoneTextBox.TabIndex = 114;
            phoneTextBox.TabStop = false;
            phoneTextBox.TextAlign = HorizontalAlignment.Left;
            phoneTextBox.TrailingIcon = null;
            phoneTextBox.UseSystemPasswordChar = false;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Left;
            emailLabel.Depth = 0;
            emailLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLabel.Location = new Point(3, 435);
            emailLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(87, 48);
            emailLabel.TabIndex = 117;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left;
            emailTextBox.AnimateReadOnly = false;
            emailTextBox.AutoCompleteMode = AutoCompleteMode.None;
            emailTextBox.AutoCompleteSource = AutoCompleteSource.None;
            emailTextBox.BackgroundImageLayout = ImageLayout.None;
            emailTextBox.CharacterCasing = CharacterCasing.Normal;
            emailTextBox.Depth = 0;
            emailTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextBox.HideSelection = true;
            emailTextBox.LeadingIcon = null;
            emailTextBox.Location = new Point(96, 435);
            emailTextBox.MaxLength = 32767;
            emailTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PasswordChar = '\0';
            emailTextBox.PrefixSuffixText = null;
            emailTextBox.ReadOnly = false;
            emailTextBox.RightToLeft = RightToLeft.No;
            emailTextBox.SelectedText = "";
            emailTextBox.SelectionLength = 0;
            emailTextBox.SelectionStart = 0;
            emailTextBox.ShortcutsEnabled = true;
            emailTextBox.Size = new Size(250, 48);
            emailTextBox.TabIndex = 116;
            emailTextBox.TabStop = false;
            emailTextBox.TextAlign = HorizontalAlignment.Left;
            emailTextBox.TrailingIcon = null;
            emailTextBox.UseSystemPasswordChar = false;
            // 
            // linkedInLabel
            // 
            linkedInLabel.Anchor = AnchorStyles.Left;
            linkedInLabel.Depth = 0;
            linkedInLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            linkedInLabel.Location = new Point(3, 489);
            linkedInLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            linkedInLabel.Name = "linkedInLabel";
            linkedInLabel.Size = new Size(87, 48);
            linkedInLabel.TabIndex = 119;
            linkedInLabel.Text = "LinkedIn:";
            linkedInLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkedInTextBox
            // 
            linkedInTextBox.Anchor = AnchorStyles.Left;
            linkedInTextBox.AnimateReadOnly = false;
            linkedInTextBox.AutoCompleteMode = AutoCompleteMode.None;
            linkedInTextBox.AutoCompleteSource = AutoCompleteSource.None;
            linkedInTextBox.BackgroundImageLayout = ImageLayout.None;
            linkedInTextBox.CharacterCasing = CharacterCasing.Normal;
            linkedInTextBox.Depth = 0;
            linkedInTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            linkedInTextBox.HideSelection = true;
            linkedInTextBox.LeadingIcon = null;
            linkedInTextBox.Location = new Point(96, 489);
            linkedInTextBox.MaxLength = 32767;
            linkedInTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            linkedInTextBox.Name = "linkedInTextBox";
            linkedInTextBox.PasswordChar = '\0';
            linkedInTextBox.PrefixSuffixText = null;
            linkedInTextBox.ReadOnly = false;
            linkedInTextBox.RightToLeft = RightToLeft.No;
            linkedInTextBox.SelectedText = "";
            linkedInTextBox.SelectionLength = 0;
            linkedInTextBox.SelectionStart = 0;
            linkedInTextBox.ShortcutsEnabled = true;
            linkedInTextBox.Size = new Size(250, 48);
            linkedInTextBox.TabIndex = 118;
            linkedInTextBox.TabStop = false;
            linkedInTextBox.TextAlign = HorizontalAlignment.Left;
            linkedInTextBox.TrailingIcon = null;
            linkedInTextBox.UseSystemPasswordChar = false;
            // 
            // portfolioLabel
            // 
            portfolioLabel.Anchor = AnchorStyles.Left;
            portfolioLabel.Depth = 0;
            portfolioLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            portfolioLabel.Location = new Point(3, 543);
            portfolioLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            portfolioLabel.Name = "portfolioLabel";
            portfolioLabel.Size = new Size(87, 48);
            portfolioLabel.TabIndex = 121;
            portfolioLabel.Text = "Portfolio:";
            portfolioLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // portfolioTextBox
            // 
            portfolioTextBox.Anchor = AnchorStyles.Left;
            portfolioTextBox.AnimateReadOnly = false;
            portfolioTextBox.AutoCompleteMode = AutoCompleteMode.None;
            portfolioTextBox.AutoCompleteSource = AutoCompleteSource.None;
            portfolioTextBox.BackgroundImageLayout = ImageLayout.None;
            portfolioTextBox.CharacterCasing = CharacterCasing.Normal;
            portfolioTextBox.Depth = 0;
            portfolioTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            portfolioTextBox.HideSelection = true;
            portfolioTextBox.LeadingIcon = null;
            portfolioTextBox.Location = new Point(96, 543);
            portfolioTextBox.MaxLength = 32767;
            portfolioTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            portfolioTextBox.Name = "portfolioTextBox";
            portfolioTextBox.PasswordChar = '\0';
            portfolioTextBox.PrefixSuffixText = null;
            portfolioTextBox.ReadOnly = false;
            portfolioTextBox.RightToLeft = RightToLeft.No;
            portfolioTextBox.SelectedText = "";
            portfolioTextBox.SelectionLength = 0;
            portfolioTextBox.SelectionStart = 0;
            portfolioTextBox.ShortcutsEnabled = true;
            portfolioTextBox.Size = new Size(250, 48);
            portfolioTextBox.TabIndex = 120;
            portfolioTextBox.TabStop = false;
            portfolioTextBox.TextAlign = HorizontalAlignment.Left;
            portfolioTextBox.TrailingIcon = null;
            portfolioTextBox.UseSystemPasswordChar = false;
            // 
            // IdentityWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 693);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MainMenuStrip = menuStrip1;
            Name = "IdentityWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Identity Workspace";
            Load += IdentityWorkspace_Load;
            Shown += IdentityWorkspace_Shown;
            Click += IdentityWorkspace_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem exportToToolStripMenuItem;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit firstNameTextBox;
        private ReaLTaiizor.Controls.MaterialLabel firstNameLabel;
        private ReaLTaiizor.Controls.MaterialLabel middleNameLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit middleNametextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel lastNameLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit lastNameTextBox;
        private ReaLTaiizor.Controls.MaterialLabel addressLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit addressTextBox;
        private ReaLTaiizor.Controls.MaterialLabel cityLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cityTextBox;
        private ReaLTaiizor.Controls.MaterialLabel stateLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit stateTextBox;
        private ReaLTaiizor.Controls.MaterialLabel zipLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit zipTextBox;
        private ReaLTaiizor.Controls.MaterialLabel phoneLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit phoneTextBox;
        private ReaLTaiizor.Controls.MaterialLabel emailLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit emailTextBox;
        private ReaLTaiizor.Controls.MaterialLabel linkedInLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit linkedInTextBox;
        private ReaLTaiizor.Controls.MaterialLabel portfolioLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit portfolioTextBox;
    }
}