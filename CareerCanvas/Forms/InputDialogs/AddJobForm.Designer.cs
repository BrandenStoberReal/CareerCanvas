namespace CareerCanvas.Forms.InputDialogs
{
    partial class AddJobForm
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
            addJobButton = new ReaLTaiizor.Controls.MaterialButton();
            discardButton = new ReaLTaiizor.Controls.MaterialButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            jobTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            companyBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            cityBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            stateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            startDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            endDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            jobDescriptionBox = new ReaLTaiizor.Controls.MaterialRichTextBox();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            flowLayoutPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
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
            addJobButton.Location = new Point(7, 525);
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
            discardButton.Location = new Point(724, 525);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(jobTitleBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(companyBox);
            flowLayoutPanel1.Controls.Add(materialLabel5);
            flowLayoutPanel1.Controls.Add(cityBox);
            flowLayoutPanel1.Controls.Add(materialLabel6);
            flowLayoutPanel1.Controls.Add(stateBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(7, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(307, 489);
            flowLayoutPanel1.TabIndex = 2;
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
            materialLabel1.Size = new Size(62, 17);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Job Title:";
            // 
            // jobTitleBox
            // 
            jobTitleBox.AnimateReadOnly = false;
            jobTitleBox.AutoCompleteMode = AutoCompleteMode.None;
            jobTitleBox.AutoCompleteSource = AutoCompleteSource.None;
            jobTitleBox.BackgroundImageLayout = ImageLayout.None;
            jobTitleBox.CharacterCasing = CharacterCasing.Normal;
            jobTitleBox.Depth = 0;
            jobTitleBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobTitleBox.HideSelection = true;
            jobTitleBox.Hint = "Position Name";
            jobTitleBox.LeadingIcon = null;
            jobTitleBox.Location = new Point(3, 26);
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
            jobTitleBox.Size = new Size(250, 48);
            jobTitleBox.TabIndex = 1;
            jobTitleBox.TabStop = false;
            jobTitleBox.TextAlign = HorizontalAlignment.Center;
            jobTitleBox.TrailingIcon = null;
            jobTitleBox.UseSystemPasswordChar = false;
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
            materialLabel2.Size = new Size(65, 17);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Company:";
            // 
            // companyBox
            // 
            companyBox.AnimateReadOnly = false;
            companyBox.AutoCompleteMode = AutoCompleteMode.None;
            companyBox.AutoCompleteSource = AutoCompleteSource.None;
            companyBox.BackgroundImageLayout = ImageLayout.None;
            companyBox.CharacterCasing = CharacterCasing.Normal;
            companyBox.Depth = 0;
            companyBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            companyBox.HideSelection = true;
            companyBox.Hint = "Company Name";
            companyBox.LeadingIcon = null;
            companyBox.Location = new Point(3, 103);
            companyBox.MaxLength = 32767;
            companyBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            companyBox.Name = "companyBox";
            companyBox.PasswordChar = '\0';
            companyBox.PrefixSuffixText = null;
            companyBox.ReadOnly = false;
            companyBox.RightToLeft = RightToLeft.No;
            companyBox.SelectedText = "";
            companyBox.SelectionLength = 0;
            companyBox.SelectionStart = 0;
            companyBox.ShortcutsEnabled = true;
            companyBox.Size = new Size(250, 48);
            companyBox.TabIndex = 2;
            companyBox.TabStop = false;
            companyBox.TextAlign = HorizontalAlignment.Center;
            companyBox.TrailingIcon = null;
            companyBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Left;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel5.Location = new Point(3, 160);
            materialLabel5.Margin = new Padding(3, 6, 3, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(30, 17);
            materialLabel5.TabIndex = 7;
            materialLabel5.Text = "City:";
            // 
            // cityBox
            // 
            cityBox.AnimateReadOnly = false;
            cityBox.AutoCompleteMode = AutoCompleteMode.None;
            cityBox.AutoCompleteSource = AutoCompleteSource.None;
            cityBox.BackgroundImageLayout = ImageLayout.None;
            cityBox.CharacterCasing = CharacterCasing.Normal;
            cityBox.Depth = 0;
            cityBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cityBox.HideSelection = true;
            cityBox.Hint = "City or Town Name";
            cityBox.LeadingIcon = null;
            cityBox.Location = new Point(3, 180);
            cityBox.MaxLength = 32767;
            cityBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cityBox.Name = "cityBox";
            cityBox.PasswordChar = '\0';
            cityBox.PrefixSuffixText = null;
            cityBox.ReadOnly = false;
            cityBox.RightToLeft = RightToLeft.No;
            cityBox.SelectedText = "";
            cityBox.SelectionLength = 0;
            cityBox.SelectionStart = 0;
            cityBox.ShortcutsEnabled = true;
            cityBox.Size = new Size(250, 48);
            cityBox.TabIndex = 3;
            cityBox.TabStop = false;
            cityBox.TextAlign = HorizontalAlignment.Center;
            cityBox.TrailingIcon = null;
            cityBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Left;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel6.Location = new Point(3, 237);
            materialLabel6.Margin = new Padding(3, 6, 3, 0);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(39, 17);
            materialLabel6.TabIndex = 9;
            materialLabel6.Text = "State:";
            // 
            // stateBox
            // 
            stateBox.AnimateReadOnly = false;
            stateBox.AutoCompleteMode = AutoCompleteMode.None;
            stateBox.AutoCompleteSource = AutoCompleteSource.None;
            stateBox.BackgroundImageLayout = ImageLayout.None;
            stateBox.CharacterCasing = CharacterCasing.Normal;
            stateBox.Depth = 0;
            stateBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            stateBox.HideSelection = true;
            stateBox.Hint = "State Name";
            stateBox.LeadingIcon = null;
            stateBox.Location = new Point(3, 257);
            stateBox.MaxLength = 32767;
            stateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            stateBox.Name = "stateBox";
            stateBox.PasswordChar = '\0';
            stateBox.PrefixSuffixText = null;
            stateBox.ReadOnly = false;
            stateBox.RightToLeft = RightToLeft.No;
            stateBox.SelectedText = "";
            stateBox.SelectionLength = 0;
            stateBox.SelectionStart = 0;
            stateBox.ShortcutsEnabled = true;
            stateBox.Size = new Size(250, 48);
            stateBox.TabIndex = 4;
            stateBox.TabStop = false;
            stateBox.TextAlign = HorizontalAlignment.Center;
            stateBox.TrailingIcon = null;
            stateBox.UseSystemPasswordChar = false;
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
            materialLabel3.Size = new Size(69, 17);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Start Date:";
            // 
            // startDateBox
            // 
            startDateBox.AnimateReadOnly = false;
            startDateBox.AutoCompleteMode = AutoCompleteMode.None;
            startDateBox.AutoCompleteSource = AutoCompleteSource.None;
            startDateBox.BackgroundImageLayout = ImageLayout.None;
            startDateBox.CharacterCasing = CharacterCasing.Normal;
            startDateBox.Depth = 0;
            startDateBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            startDateBox.HideSelection = true;
            startDateBox.Hint = "MM/YYYY";
            startDateBox.LeadingIcon = null;
            startDateBox.Location = new Point(3, 334);
            startDateBox.MaxLength = 32767;
            startDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            startDateBox.Name = "startDateBox";
            startDateBox.PasswordChar = '\0';
            startDateBox.PrefixSuffixText = null;
            startDateBox.ReadOnly = false;
            startDateBox.RightToLeft = RightToLeft.No;
            startDateBox.SelectedText = "";
            startDateBox.SelectionLength = 0;
            startDateBox.SelectionStart = 0;
            startDateBox.ShortcutsEnabled = true;
            startDateBox.Size = new Size(109, 48);
            startDateBox.TabIndex = 5;
            startDateBox.TabStop = false;
            startDateBox.TextAlign = HorizontalAlignment.Center;
            startDateBox.TrailingIcon = null;
            startDateBox.UseSystemPasswordChar = false;
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
            materialLabel4.Size = new Size(62, 17);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "End Date:";
            // 
            // endDateBox
            // 
            endDateBox.AnimateReadOnly = false;
            endDateBox.AutoCompleteMode = AutoCompleteMode.None;
            endDateBox.AutoCompleteSource = AutoCompleteSource.None;
            endDateBox.BackgroundImageLayout = ImageLayout.None;
            endDateBox.CharacterCasing = CharacterCasing.Normal;
            endDateBox.Depth = 0;
            endDateBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            endDateBox.HideSelection = true;
            endDateBox.Hint = "MM/YYYY";
            endDateBox.LeadingIcon = null;
            endDateBox.Location = new Point(3, 411);
            endDateBox.MaxLength = 32767;
            endDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            endDateBox.Name = "endDateBox";
            endDateBox.PasswordChar = '\0';
            endDateBox.PrefixSuffixText = null;
            endDateBox.ReadOnly = false;
            endDateBox.RightToLeft = RightToLeft.No;
            endDateBox.SelectedText = "";
            endDateBox.SelectionLength = 0;
            endDateBox.SelectionStart = 0;
            endDateBox.ShortcutsEnabled = true;
            endDateBox.Size = new Size(109, 48);
            endDateBox.TabIndex = 6;
            endDateBox.TabStop = false;
            endDateBox.TextAlign = HorizontalAlignment.Center;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(jobDescriptionBox);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(331, 33);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(458, 483);
            materialCard1.TabIndex = 9;
            // 
            // jobDescriptionBox
            // 
            jobDescriptionBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jobDescriptionBox.BackColor = Color.FromArgb(255, 255, 255);
            jobDescriptionBox.BorderStyle = BorderStyle.FixedSingle;
            jobDescriptionBox.Depth = 0;
            jobDescriptionBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobDescriptionBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            jobDescriptionBox.Hint = "Optional job description here";
            jobDescriptionBox.Location = new Point(17, 40);
            jobDescriptionBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            jobDescriptionBox.Name = "jobDescriptionBox";
            jobDescriptionBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            jobDescriptionBox.Size = new Size(424, 426);
            jobDescriptionBox.TabIndex = 1;
            jobDescriptionBox.Text = "";
            // 
            // materialLabel7
            // 
            materialLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel7.Location = new Point(17, 14);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(424, 23);
            materialLabel7.TabIndex = 0;
            materialLabel7.Text = "Job Description:";
            materialLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 570);
            Controls.Add(materialCard1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(discardButton);
            Controls.Add(addJobButton);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "AddJobForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Add New Job";
            FormClosing += AddJobForm_FormClosing;
            Load += AddJobForm_Load;
            Shown += AddJobForm_Shown;
            Click += AddJobForm_Click;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton addJobButton;
        private ReaLTaiizor.Controls.MaterialButton discardButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit jobTitleBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit companyBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit startDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cityBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit stateBox;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialRichTextBox jobDescriptionBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
    }
}