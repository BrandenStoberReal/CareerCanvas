namespace CareerCanvas.Forms.InputDialogs
{
    partial class CoverLetterInfoForm
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
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            saveButton = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            companyWebsiteBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel15 = new ReaLTaiizor.Controls.MaterialLabel();
            companyEmailBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel14 = new ReaLTaiizor.Controls.MaterialLabel();
            companyPhoneBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel13 = new ReaLTaiizor.Controls.MaterialLabel();
            companyZipBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel12 = new ReaLTaiizor.Controls.MaterialLabel();
            companyStateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel11 = new ReaLTaiizor.Controls.MaterialLabel();
            companyCityBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            companyAddressBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel9 = new ReaLTaiizor.Controls.MaterialLabel();
            recipientTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            recipientLastNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            recipientFirstNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            jobTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            companyNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            recipientPrefixBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel1.Location = new Point(6, 24);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(653, 23);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Welcome!";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            materialLabel2.Location = new Point(6, 47);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(653, 23);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "We need a little information to create your CV. Please provide as much as possible!";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            saveButton.Location = new Point(300, 762);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(64, 36);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(companyWebsiteBox, 1, 12);
            tableLayoutPanel1.Controls.Add(materialLabel15, 0, 12);
            tableLayoutPanel1.Controls.Add(companyEmailBox, 1, 11);
            tableLayoutPanel1.Controls.Add(materialLabel14, 0, 11);
            tableLayoutPanel1.Controls.Add(companyPhoneBox, 1, 10);
            tableLayoutPanel1.Controls.Add(materialLabel13, 0, 10);
            tableLayoutPanel1.Controls.Add(companyZipBox, 1, 9);
            tableLayoutPanel1.Controls.Add(materialLabel12, 0, 9);
            tableLayoutPanel1.Controls.Add(companyStateBox, 1, 8);
            tableLayoutPanel1.Controls.Add(materialLabel11, 0, 8);
            tableLayoutPanel1.Controls.Add(companyCityBox, 1, 7);
            tableLayoutPanel1.Controls.Add(materialLabel10, 0, 7);
            tableLayoutPanel1.Controls.Add(companyAddressBox, 1, 6);
            tableLayoutPanel1.Controls.Add(materialLabel9, 0, 6);
            tableLayoutPanel1.Controls.Add(recipientTitleBox, 1, 5);
            tableLayoutPanel1.Controls.Add(materialLabel8, 0, 5);
            tableLayoutPanel1.Controls.Add(recipientLastNameBox, 1, 3);
            tableLayoutPanel1.Controls.Add(materialLabel7, 0, 3);
            tableLayoutPanel1.Controls.Add(recipientFirstNameBox, 1, 2);
            tableLayoutPanel1.Controls.Add(materialLabel5, 0, 2);
            tableLayoutPanel1.Controls.Add(jobTitleBox, 1, 1);
            tableLayoutPanel1.Controls.Add(materialLabel4, 0, 1);
            tableLayoutPanel1.Controls.Add(materialLabel3, 0, 0);
            tableLayoutPanel1.Controls.Add(companyNameBox, 1, 0);
            tableLayoutPanel1.Controls.Add(materialLabel6, 0, 4);
            tableLayoutPanel1.Controls.Add(recipientPrefixBox, 1, 4);
            tableLayoutPanel1.Location = new Point(6, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.Size = new Size(653, 680);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // companyWebsiteBox
            // 
            companyWebsiteBox.Anchor = AnchorStyles.Left;
            companyWebsiteBox.AnimateReadOnly = false;
            companyWebsiteBox.AutoCompleteMode = AutoCompleteMode.None;
            companyWebsiteBox.AutoCompleteSource = AutoCompleteSource.None;
            companyWebsiteBox.BackgroundImageLayout = ImageLayout.None;
            companyWebsiteBox.CharacterCasing = CharacterCasing.Normal;
            companyWebsiteBox.Depth = 0;
            companyWebsiteBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyWebsiteBox.HideSelection = true;
            companyWebsiteBox.Hint = "e.g. google.com, microsoft.com";
            companyWebsiteBox.LeadingIcon = null;
            companyWebsiteBox.Location = new Point(204, 628);
            companyWebsiteBox.MaxLength = 32767;
            companyWebsiteBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyWebsiteBox.Name = "companyWebsiteBox";
            companyWebsiteBox.PasswordChar = '\0';
            companyWebsiteBox.PrefixSuffixText = null;
            companyWebsiteBox.ReadOnly = false;
            companyWebsiteBox.RightToLeft = RightToLeft.No;
            companyWebsiteBox.SelectedText = "";
            companyWebsiteBox.SelectionLength = 0;
            companyWebsiteBox.SelectionStart = 0;
            companyWebsiteBox.ShortcutsEnabled = true;
            companyWebsiteBox.Size = new Size(382, 48);
            companyWebsiteBox.TabIndex = 13;
            companyWebsiteBox.TabStop = false;
            companyWebsiteBox.TextAlign = HorizontalAlignment.Left;
            companyWebsiteBox.TrailingIcon = null;
            companyWebsiteBox.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            materialLabel15.Anchor = AnchorStyles.Right;
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(65, 642);
            materialLabel15.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(133, 19);
            materialLabel15.TabIndex = 24;
            materialLabel15.Text = "Company Website:";
            // 
            // companyEmailBox
            // 
            companyEmailBox.Anchor = AnchorStyles.Left;
            companyEmailBox.AnimateReadOnly = false;
            companyEmailBox.AutoCompleteMode = AutoCompleteMode.None;
            companyEmailBox.AutoCompleteSource = AutoCompleteSource.None;
            companyEmailBox.BackgroundImageLayout = ImageLayout.None;
            companyEmailBox.CharacterCasing = CharacterCasing.Normal;
            companyEmailBox.Depth = 0;
            companyEmailBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyEmailBox.HideSelection = true;
            companyEmailBox.Hint = "e.g. hiring@microsoft.com";
            companyEmailBox.LeadingIcon = null;
            companyEmailBox.Location = new Point(204, 575);
            companyEmailBox.MaxLength = 32767;
            companyEmailBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyEmailBox.Name = "companyEmailBox";
            companyEmailBox.PasswordChar = '\0';
            companyEmailBox.PrefixSuffixText = null;
            companyEmailBox.ReadOnly = false;
            companyEmailBox.RightToLeft = RightToLeft.No;
            companyEmailBox.SelectedText = "";
            companyEmailBox.SelectionLength = 0;
            companyEmailBox.SelectionStart = 0;
            companyEmailBox.ShortcutsEnabled = true;
            companyEmailBox.Size = new Size(382, 48);
            companyEmailBox.TabIndex = 12;
            companyEmailBox.TabStop = false;
            companyEmailBox.TextAlign = HorizontalAlignment.Left;
            companyEmailBox.TrailingIcon = null;
            companyEmailBox.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            materialLabel14.Anchor = AnchorStyles.Right;
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(33, 588);
            materialLabel14.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(165, 19);
            materialLabel14.TabIndex = 22;
            materialLabel14.Text = "Company Public Email:";
            // 
            // companyPhoneBox
            // 
            companyPhoneBox.Anchor = AnchorStyles.Left;
            companyPhoneBox.AnimateReadOnly = false;
            companyPhoneBox.AutoCompleteMode = AutoCompleteMode.None;
            companyPhoneBox.AutoCompleteSource = AutoCompleteSource.None;
            companyPhoneBox.BackgroundImageLayout = ImageLayout.None;
            companyPhoneBox.CharacterCasing = CharacterCasing.Normal;
            companyPhoneBox.Depth = 0;
            companyPhoneBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyPhoneBox.HideSelection = true;
            companyPhoneBox.Hint = "e.g. 000-000-0000, 123-456-7890";
            companyPhoneBox.LeadingIcon = null;
            companyPhoneBox.Location = new Point(204, 523);
            companyPhoneBox.MaxLength = 32767;
            companyPhoneBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyPhoneBox.Name = "companyPhoneBox";
            companyPhoneBox.PasswordChar = '\0';
            companyPhoneBox.PrefixSuffixText = null;
            companyPhoneBox.ReadOnly = false;
            companyPhoneBox.RightToLeft = RightToLeft.No;
            companyPhoneBox.SelectedText = "";
            companyPhoneBox.SelectionLength = 0;
            companyPhoneBox.SelectionStart = 0;
            companyPhoneBox.ShortcutsEnabled = true;
            companyPhoneBox.Size = new Size(382, 48);
            companyPhoneBox.TabIndex = 11;
            companyPhoneBox.TabStop = false;
            companyPhoneBox.TextAlign = HorizontalAlignment.Left;
            companyPhoneBox.TrailingIcon = null;
            companyPhoneBox.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            materialLabel13.Anchor = AnchorStyles.Right;
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(16, 536);
            materialLabel13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(182, 19);
            materialLabel13.TabIndex = 20;
            materialLabel13.Text = "Company Phone Number:";
            // 
            // companyZipBox
            // 
            companyZipBox.Anchor = AnchorStyles.Left;
            companyZipBox.AnimateReadOnly = false;
            companyZipBox.AutoCompleteMode = AutoCompleteMode.None;
            companyZipBox.AutoCompleteSource = AutoCompleteSource.None;
            companyZipBox.BackgroundImageLayout = ImageLayout.None;
            companyZipBox.CharacterCasing = CharacterCasing.Normal;
            companyZipBox.Depth = 0;
            companyZipBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyZipBox.HideSelection = true;
            companyZipBox.Hint = "e.g. 32724, 07860, 12345";
            companyZipBox.LeadingIcon = null;
            companyZipBox.Location = new Point(204, 471);
            companyZipBox.MaxLength = 32767;
            companyZipBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyZipBox.Name = "companyZipBox";
            companyZipBox.PasswordChar = '\0';
            companyZipBox.PrefixSuffixText = null;
            companyZipBox.ReadOnly = false;
            companyZipBox.RightToLeft = RightToLeft.No;
            companyZipBox.SelectedText = "";
            companyZipBox.SelectionLength = 0;
            companyZipBox.SelectionStart = 0;
            companyZipBox.ShortcutsEnabled = true;
            companyZipBox.Size = new Size(382, 48);
            companyZipBox.TabIndex = 10;
            companyZipBox.TabStop = false;
            companyZipBox.TextAlign = HorizontalAlignment.Left;
            companyZipBox.TrailingIcon = null;
            companyZipBox.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            materialLabel12.Anchor = AnchorStyles.Right;
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(58, 484);
            materialLabel12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(140, 19);
            materialLabel12.TabIndex = 18;
            materialLabel12.Text = "Company Zip Code:";
            // 
            // companyStateBox
            // 
            companyStateBox.Anchor = AnchorStyles.Left;
            companyStateBox.AnimateReadOnly = false;
            companyStateBox.AutoCompleteMode = AutoCompleteMode.None;
            companyStateBox.AutoCompleteSource = AutoCompleteSource.None;
            companyStateBox.BackgroundImageLayout = ImageLayout.None;
            companyStateBox.CharacterCasing = CharacterCasing.Normal;
            companyStateBox.Depth = 0;
            companyStateBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyStateBox.HideSelection = true;
            companyStateBox.Hint = "e.g. Ohio, Virginia, Florida";
            companyStateBox.LeadingIcon = null;
            companyStateBox.Location = new Point(204, 419);
            companyStateBox.MaxLength = 32767;
            companyStateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyStateBox.Name = "companyStateBox";
            companyStateBox.PasswordChar = '\0';
            companyStateBox.PrefixSuffixText = null;
            companyStateBox.ReadOnly = false;
            companyStateBox.RightToLeft = RightToLeft.No;
            companyStateBox.SelectedText = "";
            companyStateBox.SelectionLength = 0;
            companyStateBox.SelectionStart = 0;
            companyStateBox.ShortcutsEnabled = true;
            companyStateBox.Size = new Size(382, 48);
            companyStateBox.TabIndex = 9;
            companyStateBox.TabStop = false;
            companyStateBox.TextAlign = HorizontalAlignment.Left;
            companyStateBox.TrailingIcon = null;
            companyStateBox.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            materialLabel11.Anchor = AnchorStyles.Right;
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(84, 432);
            materialLabel11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(114, 19);
            materialLabel11.TabIndex = 16;
            materialLabel11.Text = "Company State:";
            // 
            // companyCityBox
            // 
            companyCityBox.Anchor = AnchorStyles.Left;
            companyCityBox.AnimateReadOnly = false;
            companyCityBox.AutoCompleteMode = AutoCompleteMode.None;
            companyCityBox.AutoCompleteSource = AutoCompleteSource.None;
            companyCityBox.BackgroundImageLayout = ImageLayout.None;
            companyCityBox.CharacterCasing = CharacterCasing.Normal;
            companyCityBox.Depth = 0;
            companyCityBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyCityBox.HideSelection = true;
            companyCityBox.Hint = "e.g. New York, Springfield, Allentown";
            companyCityBox.LeadingIcon = null;
            companyCityBox.Location = new Point(204, 367);
            companyCityBox.MaxLength = 32767;
            companyCityBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyCityBox.Name = "companyCityBox";
            companyCityBox.PasswordChar = '\0';
            companyCityBox.PrefixSuffixText = null;
            companyCityBox.ReadOnly = false;
            companyCityBox.RightToLeft = RightToLeft.No;
            companyCityBox.SelectedText = "";
            companyCityBox.SelectionLength = 0;
            companyCityBox.SelectionStart = 0;
            companyCityBox.ShortcutsEnabled = true;
            companyCityBox.Size = new Size(382, 48);
            companyCityBox.TabIndex = 8;
            companyCityBox.TabStop = false;
            companyCityBox.TextAlign = HorizontalAlignment.Left;
            companyCityBox.TrailingIcon = null;
            companyCityBox.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            materialLabel10.Anchor = AnchorStyles.Right;
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(94, 380);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(104, 19);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "Company City:";
            // 
            // companyAddressBox
            // 
            companyAddressBox.Anchor = AnchorStyles.Left;
            companyAddressBox.AnimateReadOnly = false;
            companyAddressBox.AutoCompleteMode = AutoCompleteMode.None;
            companyAddressBox.AutoCompleteSource = AutoCompleteSource.None;
            companyAddressBox.BackgroundImageLayout = ImageLayout.None;
            companyAddressBox.CharacterCasing = CharacterCasing.Normal;
            companyAddressBox.Depth = 0;
            companyAddressBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyAddressBox.HideSelection = true;
            companyAddressBox.Hint = "e.g. 123 Example Way, 456 Victoria Street";
            companyAddressBox.LeadingIcon = null;
            companyAddressBox.Location = new Point(204, 315);
            companyAddressBox.MaxLength = 32767;
            companyAddressBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyAddressBox.Name = "companyAddressBox";
            companyAddressBox.PasswordChar = '\0';
            companyAddressBox.PrefixSuffixText = null;
            companyAddressBox.ReadOnly = false;
            companyAddressBox.RightToLeft = RightToLeft.No;
            companyAddressBox.SelectedText = "";
            companyAddressBox.SelectionLength = 0;
            companyAddressBox.SelectionStart = 0;
            companyAddressBox.ShortcutsEnabled = true;
            companyAddressBox.Size = new Size(382, 48);
            companyAddressBox.TabIndex = 7;
            companyAddressBox.TabStop = false;
            companyAddressBox.TextAlign = HorizontalAlignment.Left;
            companyAddressBox.TrailingIcon = null;
            companyAddressBox.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.Anchor = AnchorStyles.Right;
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(64, 328);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(134, 19);
            materialLabel9.TabIndex = 12;
            materialLabel9.Text = "Company Address:";
            // 
            // recipientTitleBox
            // 
            recipientTitleBox.Anchor = AnchorStyles.Left;
            recipientTitleBox.AnimateReadOnly = false;
            recipientTitleBox.AutoCompleteMode = AutoCompleteMode.None;
            recipientTitleBox.AutoCompleteSource = AutoCompleteSource.None;
            recipientTitleBox.BackgroundImageLayout = ImageLayout.None;
            recipientTitleBox.CharacterCasing = CharacterCasing.Normal;
            recipientTitleBox.Depth = 0;
            recipientTitleBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            recipientTitleBox.HideSelection = true;
            recipientTitleBox.Hint = "e.g. Hiring Manager, CEO, VP of Sales";
            recipientTitleBox.LeadingIcon = null;
            recipientTitleBox.Location = new Point(204, 263);
            recipientTitleBox.MaxLength = 32767;
            recipientTitleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            recipientTitleBox.Name = "recipientTitleBox";
            recipientTitleBox.PasswordChar = '\0';
            recipientTitleBox.PrefixSuffixText = null;
            recipientTitleBox.ReadOnly = false;
            recipientTitleBox.RightToLeft = RightToLeft.No;
            recipientTitleBox.SelectedText = "";
            recipientTitleBox.SelectionLength = 0;
            recipientTitleBox.SelectionStart = 0;
            recipientTitleBox.ShortcutsEnabled = true;
            recipientTitleBox.Size = new Size(382, 48);
            recipientTitleBox.TabIndex = 6;
            recipientTitleBox.TabStop = false;
            recipientTitleBox.TextAlign = HorizontalAlignment.Left;
            recipientTitleBox.TrailingIcon = null;
            recipientTitleBox.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.Anchor = AnchorStyles.Right;
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(18, 276);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(180, 19);
            materialLabel8.TabIndex = 10;
            materialLabel8.Text = "Hiring Manager Job Title:";
            // 
            // recipientLastNameBox
            // 
            recipientLastNameBox.Anchor = AnchorStyles.Left;
            recipientLastNameBox.AnimateReadOnly = false;
            recipientLastNameBox.AutoCompleteMode = AutoCompleteMode.None;
            recipientLastNameBox.AutoCompleteSource = AutoCompleteSource.None;
            recipientLastNameBox.BackgroundImageLayout = ImageLayout.None;
            recipientLastNameBox.CharacterCasing = CharacterCasing.Normal;
            recipientLastNameBox.Depth = 0;
            recipientLastNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            recipientLastNameBox.HideSelection = true;
            recipientLastNameBox.Hint = "e.g. Doe, Allen, Smith";
            recipientLastNameBox.LeadingIcon = null;
            recipientLastNameBox.Location = new Point(204, 159);
            recipientLastNameBox.MaxLength = 32767;
            recipientLastNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            recipientLastNameBox.Name = "recipientLastNameBox";
            recipientLastNameBox.PasswordChar = '\0';
            recipientLastNameBox.PrefixSuffixText = null;
            recipientLastNameBox.ReadOnly = false;
            recipientLastNameBox.RightToLeft = RightToLeft.No;
            recipientLastNameBox.SelectedText = "";
            recipientLastNameBox.SelectionLength = 0;
            recipientLastNameBox.SelectionStart = 0;
            recipientLastNameBox.ShortcutsEnabled = true;
            recipientLastNameBox.Size = new Size(382, 48);
            recipientLastNameBox.TabIndex = 4;
            recipientLastNameBox.TabStop = false;
            recipientLastNameBox.TextAlign = HorizontalAlignment.Left;
            recipientLastNameBox.TrailingIcon = null;
            recipientLastNameBox.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.Anchor = AnchorStyles.Right;
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(3, 172);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(195, 19);
            materialLabel7.TabIndex = 8;
            materialLabel7.Text = "Hiring Manager Last Name:";
            // 
            // recipientFirstNameBox
            // 
            recipientFirstNameBox.Anchor = AnchorStyles.Left;
            recipientFirstNameBox.AnimateReadOnly = false;
            recipientFirstNameBox.AutoCompleteMode = AutoCompleteMode.None;
            recipientFirstNameBox.AutoCompleteSource = AutoCompleteSource.None;
            recipientFirstNameBox.BackgroundImageLayout = ImageLayout.None;
            recipientFirstNameBox.CharacterCasing = CharacterCasing.Normal;
            recipientFirstNameBox.Depth = 0;
            recipientFirstNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            recipientFirstNameBox.HideSelection = true;
            recipientFirstNameBox.Hint = "e.g. Jane, John, Jeremy";
            recipientFirstNameBox.LeadingIcon = null;
            recipientFirstNameBox.Location = new Point(204, 107);
            recipientFirstNameBox.MaxLength = 32767;
            recipientFirstNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            recipientFirstNameBox.Name = "recipientFirstNameBox";
            recipientFirstNameBox.PasswordChar = '\0';
            recipientFirstNameBox.PrefixSuffixText = null;
            recipientFirstNameBox.ReadOnly = false;
            recipientFirstNameBox.RightToLeft = RightToLeft.No;
            recipientFirstNameBox.SelectedText = "";
            recipientFirstNameBox.SelectionLength = 0;
            recipientFirstNameBox.SelectionStart = 0;
            recipientFirstNameBox.ShortcutsEnabled = true;
            recipientFirstNameBox.Size = new Size(382, 48);
            recipientFirstNameBox.TabIndex = 3;
            recipientFirstNameBox.TabStop = false;
            recipientFirstNameBox.TextAlign = HorizontalAlignment.Left;
            recipientFirstNameBox.TrailingIcon = null;
            recipientFirstNameBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Right;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(3, 120);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(195, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Hiring Manager First Name:";
            // 
            // jobTitleBox
            // 
            jobTitleBox.Anchor = AnchorStyles.Left;
            jobTitleBox.AnimateReadOnly = false;
            jobTitleBox.AutoCompleteMode = AutoCompleteMode.None;
            jobTitleBox.AutoCompleteSource = AutoCompleteSource.None;
            jobTitleBox.BackgroundImageLayout = ImageLayout.None;
            jobTitleBox.CharacterCasing = CharacterCasing.Normal;
            jobTitleBox.Depth = 0;
            jobTitleBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobTitleBox.HideSelection = true;
            jobTitleBox.Hint = "e.g. Line Cook, Software Engineer";
            jobTitleBox.LeadingIcon = null;
            jobTitleBox.Location = new Point(204, 55);
            jobTitleBox.MaxLength = 32767;
            jobTitleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            jobTitleBox.Name = "jobTitleBox";
            jobTitleBox.PasswordChar = '\0';
            jobTitleBox.PrefixSuffixText = null;
            jobTitleBox.ReadOnly = false;
            jobTitleBox.RightToLeft = RightToLeft.No;
            jobTitleBox.SelectedText = "";
            jobTitleBox.SelectionLength = 0;
            jobTitleBox.SelectionStart = 0;
            jobTitleBox.ShortcutsEnabled = true;
            jobTitleBox.Size = new Size(382, 48);
            jobTitleBox.TabIndex = 2;
            jobTitleBox.TabStop = false;
            jobTitleBox.TextAlign = HorizontalAlignment.Left;
            jobTitleBox.TrailingIcon = null;
            jobTitleBox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Right;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(78, 68);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(120, 19);
            materialLabel4.TabIndex = 2;
            materialLabel4.Text = "Desired Position:";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(79, 16);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(119, 19);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "Company Name:";
            // 
            // companyNameBox
            // 
            companyNameBox.Anchor = AnchorStyles.Left;
            companyNameBox.AnimateReadOnly = false;
            companyNameBox.AutoCompleteMode = AutoCompleteMode.None;
            companyNameBox.AutoCompleteSource = AutoCompleteSource.None;
            companyNameBox.BackgroundImageLayout = ImageLayout.None;
            companyNameBox.CharacterCasing = CharacterCasing.Normal;
            companyNameBox.Depth = 0;
            companyNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyNameBox.HideSelection = true;
            companyNameBox.Hint = "e.g. Alphabet Inc, Microsoft";
            companyNameBox.LeadingIcon = null;
            companyNameBox.Location = new Point(204, 3);
            companyNameBox.MaxLength = 32767;
            companyNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyNameBox.Name = "companyNameBox";
            companyNameBox.PasswordChar = '\0';
            companyNameBox.PrefixSuffixText = null;
            companyNameBox.ReadOnly = false;
            companyNameBox.RightToLeft = RightToLeft.No;
            companyNameBox.SelectedText = "";
            companyNameBox.SelectionLength = 0;
            companyNameBox.SelectionStart = 0;
            companyNameBox.ShortcutsEnabled = true;
            companyNameBox.Size = new Size(382, 48);
            companyNameBox.TabIndex = 1;
            companyNameBox.TabStop = false;
            companyNameBox.TextAlign = HorizontalAlignment.Left;
            companyNameBox.TrailingIcon = null;
            companyNameBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Right;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(39, 224);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(159, 19);
            materialLabel6.TabIndex = 6;
            materialLabel6.Text = "Hiring Manager Prefix:";
            // 
            // recipientPrefixBox
            // 
            recipientPrefixBox.Anchor = AnchorStyles.Left;
            recipientPrefixBox.AnimateReadOnly = false;
            recipientPrefixBox.AutoCompleteMode = AutoCompleteMode.None;
            recipientPrefixBox.AutoCompleteSource = AutoCompleteSource.None;
            recipientPrefixBox.BackgroundImageLayout = ImageLayout.None;
            recipientPrefixBox.CharacterCasing = CharacterCasing.Normal;
            recipientPrefixBox.Depth = 0;
            recipientPrefixBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            recipientPrefixBox.HideSelection = true;
            recipientPrefixBox.Hint = "e.g. Mr, Mrs, Ms, Mrs";
            recipientPrefixBox.LeadingIcon = null;
            recipientPrefixBox.Location = new Point(204, 211);
            recipientPrefixBox.MaxLength = 32767;
            recipientPrefixBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            recipientPrefixBox.Name = "recipientPrefixBox";
            recipientPrefixBox.PasswordChar = '\0';
            recipientPrefixBox.PrefixSuffixText = null;
            recipientPrefixBox.ReadOnly = false;
            recipientPrefixBox.RightToLeft = RightToLeft.No;
            recipientPrefixBox.SelectedText = "";
            recipientPrefixBox.SelectionLength = 0;
            recipientPrefixBox.SelectionStart = 0;
            recipientPrefixBox.ShortcutsEnabled = true;
            recipientPrefixBox.Size = new Size(382, 48);
            recipientPrefixBox.TabIndex = 5;
            recipientPrefixBox.TabStop = false;
            recipientPrefixBox.TextAlign = HorizontalAlignment.Left;
            recipientPrefixBox.TrailingIcon = null;
            recipientPrefixBox.UseSystemPasswordChar = false;
            // 
            // CoverLetterInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 807);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(saveButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "CoverLetterInfoForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Cover Letter Information";
            FormClosing += CoverLetterInfoForm_FormClosing;
            Load += CoverLetterInfoForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialButton saveButton;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit jobTitleBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit recipientFirstNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit recipientPrefixBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit recipientLastNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit recipientTitleBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel9;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyAddressBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyStateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel11;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyCityBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyZipBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel12;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyPhoneBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel13;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyEmailBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel14;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyWebsiteBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel15;
    }
}