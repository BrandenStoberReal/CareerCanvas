namespace CareerCanvas.Forms.InputDialogs
{
    partial class AddCertificateForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            certificateTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            issuerBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            certificateIssueDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            programNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            programStartDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            programEndDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            discardButton = new ReaLTaiizor.Controls.MaterialButton();
            addJobButton = new ReaLTaiizor.Controls.MaterialButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(certificateTitleBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(issuerBox);
            flowLayoutPanel1.Controls.Add(materialLabel6);
            flowLayoutPanel1.Controls.Add(certificateIssueDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel5);
            flowLayoutPanel1.Controls.Add(programNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(programStartDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(programEndDateBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 530);
            flowLayoutPanel1.TabIndex = 1001;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.Location = new Point(3, 6);
            materialLabel1.Margin = new Padding(3, 6, 3, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 17);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Certificate Title:";
            // 
            // certificateTitleBox
            // 
            certificateTitleBox.AnimateReadOnly = false;
            certificateTitleBox.AutoCompleteMode = AutoCompleteMode.None;
            certificateTitleBox.AutoCompleteSource = AutoCompleteSource.None;
            certificateTitleBox.BackgroundImageLayout = ImageLayout.None;
            certificateTitleBox.CharacterCasing = CharacterCasing.Normal;
            certificateTitleBox.Depth = 0;
            certificateTitleBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            certificateTitleBox.HideSelection = true;
            certificateTitleBox.Hint = "Certificate Name";
            certificateTitleBox.LeadingIcon = null;
            certificateTitleBox.Location = new Point(3, 26);
            certificateTitleBox.MaxLength = 32767;
            certificateTitleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            certificateTitleBox.Name = "certificateTitleBox";
            certificateTitleBox.PasswordChar = '\0';
            certificateTitleBox.PrefixSuffixText = null;
            certificateTitleBox.ReadOnly = false;
            certificateTitleBox.RightToLeft = RightToLeft.No;
            certificateTitleBox.SelectedText = "";
            certificateTitleBox.SelectionLength = 0;
            certificateTitleBox.SelectionStart = 0;
            certificateTitleBox.ShortcutsEnabled = true;
            certificateTitleBox.Size = new Size(250, 48);
            certificateTitleBox.TabIndex = 1;
            certificateTitleBox.TabStop = false;
            certificateTitleBox.TextAlign = HorizontalAlignment.Center;
            certificateTitleBox.TrailingIcon = null;
            certificateTitleBox.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel2.Location = new Point(3, 83);
            materialLabel2.Margin = new Padding(3, 6, 3, 0);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(44, 17);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Issuer:";
            // 
            // issuerBox
            // 
            issuerBox.AnimateReadOnly = false;
            issuerBox.AutoCompleteMode = AutoCompleteMode.None;
            issuerBox.AutoCompleteSource = AutoCompleteSource.None;
            issuerBox.BackgroundImageLayout = ImageLayout.None;
            issuerBox.CharacterCasing = CharacterCasing.Normal;
            issuerBox.Depth = 0;
            issuerBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issuerBox.HideSelection = true;
            issuerBox.Hint = "Certificate Issuer";
            issuerBox.LeadingIcon = null;
            issuerBox.Location = new Point(3, 103);
            issuerBox.MaxLength = 32767;
            issuerBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            issuerBox.Name = "issuerBox";
            issuerBox.PasswordChar = '\0';
            issuerBox.PrefixSuffixText = null;
            issuerBox.ReadOnly = false;
            issuerBox.RightToLeft = RightToLeft.No;
            issuerBox.SelectedText = "";
            issuerBox.SelectionLength = 0;
            issuerBox.SelectionStart = 0;
            issuerBox.ShortcutsEnabled = true;
            issuerBox.Size = new Size(250, 48);
            issuerBox.TabIndex = 2;
            issuerBox.TabStop = false;
            issuerBox.TextAlign = HorizontalAlignment.Center;
            issuerBox.TrailingIcon = null;
            issuerBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Left;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel6.Location = new Point(3, 160);
            materialLabel6.Margin = new Padding(3, 6, 3, 0);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(72, 17);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Issue Date:";
            // 
            // certificateIssueDateBox
            // 
            certificateIssueDateBox.AnimateReadOnly = false;
            certificateIssueDateBox.AutoCompleteMode = AutoCompleteMode.None;
            certificateIssueDateBox.AutoCompleteSource = AutoCompleteSource.None;
            certificateIssueDateBox.BackgroundImageLayout = ImageLayout.None;
            certificateIssueDateBox.CharacterCasing = CharacterCasing.Normal;
            certificateIssueDateBox.Depth = 0;
            certificateIssueDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            certificateIssueDateBox.HideSelection = true;
            certificateIssueDateBox.Hint = "MM/YYYY";
            certificateIssueDateBox.LeadingIcon = null;
            certificateIssueDateBox.Location = new Point(3, 180);
            certificateIssueDateBox.MaxLength = 32767;
            certificateIssueDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            certificateIssueDateBox.Name = "certificateIssueDateBox";
            certificateIssueDateBox.PasswordChar = '\0';
            certificateIssueDateBox.PrefixSuffixText = null;
            certificateIssueDateBox.ReadOnly = false;
            certificateIssueDateBox.RightToLeft = RightToLeft.No;
            certificateIssueDateBox.SelectedText = "";
            certificateIssueDateBox.SelectionLength = 0;
            certificateIssueDateBox.SelectionStart = 0;
            certificateIssueDateBox.ShortcutsEnabled = true;
            certificateIssueDateBox.Size = new Size(109, 48);
            certificateIssueDateBox.TabIndex = 3;
            certificateIssueDateBox.TabStop = false;
            certificateIssueDateBox.TextAlign = HorizontalAlignment.Center;
            certificateIssueDateBox.TrailingIcon = null;
            certificateIssueDateBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Left;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel5.Location = new Point(3, 237);
            materialLabel5.Margin = new Padding(3, 6, 3, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(101, 17);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Program Name:";
            // 
            // programNameBox
            // 
            programNameBox.AnimateReadOnly = false;
            programNameBox.AutoCompleteMode = AutoCompleteMode.None;
            programNameBox.AutoCompleteSource = AutoCompleteSource.None;
            programNameBox.BackgroundImageLayout = ImageLayout.None;
            programNameBox.CharacterCasing = CharacterCasing.Normal;
            programNameBox.Depth = 0;
            programNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            programNameBox.HideSelection = true;
            programNameBox.Hint = "Certificate Program Name";
            programNameBox.LeadingIcon = null;
            programNameBox.Location = new Point(3, 257);
            programNameBox.MaxLength = 32767;
            programNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            programNameBox.Name = "programNameBox";
            programNameBox.PasswordChar = '\0';
            programNameBox.PrefixSuffixText = null;
            programNameBox.ReadOnly = false;
            programNameBox.RightToLeft = RightToLeft.No;
            programNameBox.SelectedText = "";
            programNameBox.SelectionLength = 0;
            programNameBox.SelectionStart = 0;
            programNameBox.ShortcutsEnabled = true;
            programNameBox.Size = new Size(250, 48);
            programNameBox.TabIndex = 4;
            programNameBox.TabStop = false;
            programNameBox.TextAlign = HorizontalAlignment.Center;
            programNameBox.TrailingIcon = null;
            programNameBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Left;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel3.Location = new Point(3, 314);
            materialLabel3.Margin = new Padding(3, 6, 3, 0);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(127, 17);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Program Start Date:";
            // 
            // programStartDateBox
            // 
            programStartDateBox.AnimateReadOnly = false;
            programStartDateBox.AutoCompleteMode = AutoCompleteMode.None;
            programStartDateBox.AutoCompleteSource = AutoCompleteSource.None;
            programStartDateBox.BackgroundImageLayout = ImageLayout.None;
            programStartDateBox.CharacterCasing = CharacterCasing.Normal;
            programStartDateBox.Depth = 0;
            programStartDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            programStartDateBox.HideSelection = true;
            programStartDateBox.Hint = "MM/YYYY";
            programStartDateBox.LeadingIcon = null;
            programStartDateBox.Location = new Point(3, 334);
            programStartDateBox.MaxLength = 32767;
            programStartDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            programStartDateBox.Name = "programStartDateBox";
            programStartDateBox.PasswordChar = '\0';
            programStartDateBox.PrefixSuffixText = null;
            programStartDateBox.ReadOnly = false;
            programStartDateBox.RightToLeft = RightToLeft.No;
            programStartDateBox.SelectedText = "";
            programStartDateBox.SelectionLength = 0;
            programStartDateBox.SelectionStart = 0;
            programStartDateBox.ShortcutsEnabled = true;
            programStartDateBox.Size = new Size(109, 48);
            programStartDateBox.TabIndex = 5;
            programStartDateBox.TabStop = false;
            programStartDateBox.TextAlign = HorizontalAlignment.Center;
            programStartDateBox.TrailingIcon = null;
            programStartDateBox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Left;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel4.Location = new Point(3, 391);
            materialLabel4.Margin = new Padding(3, 6, 3, 0);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(120, 17);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Program End Date:";
            // 
            // programEndDateBox
            // 
            programEndDateBox.AnimateReadOnly = false;
            programEndDateBox.AutoCompleteMode = AutoCompleteMode.None;
            programEndDateBox.AutoCompleteSource = AutoCompleteSource.None;
            programEndDateBox.BackgroundImageLayout = ImageLayout.None;
            programEndDateBox.CharacterCasing = CharacterCasing.Normal;
            programEndDateBox.Depth = 0;
            programEndDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            programEndDateBox.HideSelection = true;
            programEndDateBox.Hint = "MM/YYYY";
            programEndDateBox.LeadingIcon = null;
            programEndDateBox.Location = new Point(3, 411);
            programEndDateBox.MaxLength = 32767;
            programEndDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            programEndDateBox.Name = "programEndDateBox";
            programEndDateBox.PasswordChar = '\0';
            programEndDateBox.PrefixSuffixText = null;
            programEndDateBox.ReadOnly = false;
            programEndDateBox.RightToLeft = RightToLeft.No;
            programEndDateBox.SelectedText = "";
            programEndDateBox.SelectionLength = 0;
            programEndDateBox.SelectionStart = 0;
            programEndDateBox.ShortcutsEnabled = true;
            programEndDateBox.Size = new Size(109, 48);
            programEndDateBox.TabIndex = 6;
            programEndDateBox.TabStop = false;
            programEndDateBox.TextAlign = HorizontalAlignment.Center;
            programEndDateBox.TrailingIcon = null;
            programEndDateBox.UseSystemPasswordChar = false;
            // 
            // discardButton
            // 
            discardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            discardButton.AutoSize = false;
            discardButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            discardButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            discardButton.Depth = 0;
            discardButton.HighEmphasis = true;
            discardButton.Icon = null;
            discardButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            discardButton.Location = new Point(309, 566);
            discardButton.Margin = new Padding(4, 6, 4, 6);
            discardButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            discardButton.Name = "discardButton";
            discardButton.NoAccentTextColor = Color.Empty;
            discardButton.Size = new Size(75, 36);
            discardButton.TabIndex = 8;
            discardButton.Text = "Discard";
            discardButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            discardButton.UseAccentColor = false;
            discardButton.UseVisualStyleBackColor = true;
            discardButton.Click += discardButton_Click;
            // 
            // addJobButton
            // 
            addJobButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addJobButton.AutoSize = false;
            addJobButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addJobButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addJobButton.Depth = 0;
            addJobButton.HighEmphasis = true;
            addJobButton.Icon = null;
            addJobButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addJobButton.Location = new Point(8, 566);
            addJobButton.Margin = new Padding(4, 6, 4, 6);
            addJobButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addJobButton.Name = "addJobButton";
            addJobButton.NoAccentTextColor = Color.Empty;
            addJobButton.Size = new Size(75, 36);
            addJobButton.TabIndex = 7;
            addJobButton.Text = "Add";
            addJobButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addJobButton.UseAccentColor = false;
            addJobButton.UseVisualStyleBackColor = true;
            addJobButton.Click += addJobButton_Click;
            // 
            // AddCertificateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 611);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(discardButton);
            Controls.Add(addJobButton);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "AddCertificateForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Add Certificate Program";
            FormClosing += AddCertificateForm_FormClosing;
            Load += AddCertificateForm_Load;
            Click += AddCertificateForm_Click;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit certificateTitleBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit issuerBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit certificateIssueDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit programNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit programStartDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit programEndDateBox;
        private ReaLTaiizor.Controls.MaterialButton discardButton;
        private ReaLTaiizor.Controls.MaterialButton addJobButton;
    }
}