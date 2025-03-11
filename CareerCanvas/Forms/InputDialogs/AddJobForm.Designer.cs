namespace CareerCanvas.Forms
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
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            startDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            endDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            flowLayoutPanel1.SuspendLayout();
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
            addJobButton.Location = new Point(7, 405);
            addJobButton.Margin = new Padding(4, 6, 4, 6);
            addJobButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addJobButton.Name = "addJobButton";
            addJobButton.NoAccentTextColor = Color.Empty;
            addJobButton.Size = new Size(75, 36);
            addJobButton.TabIndex = 5;
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
            discardButton.Location = new Point(308, 405);
            discardButton.Margin = new Padding(4, 6, 4, 6);
            discardButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            discardButton.Name = "discardButton";
            discardButton.NoAccentTextColor = Color.Empty;
            discardButton.Size = new Size(75, 36);
            discardButton.TabIndex = 6;
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
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(7, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 369);
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
            jobTitleBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            companyBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Left;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel3.Location = new Point(3, 160);
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
            startDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            startDateBox.HideSelection = true;
            startDateBox.Hint = "MM/YYYY";
            startDateBox.LeadingIcon = null;
            startDateBox.Location = new Point(3, 180);
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
            startDateBox.TabIndex = 3;
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
            materialLabel4.Location = new Point(3, 237);
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
            endDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            endDateBox.HideSelection = true;
            endDateBox.Hint = "MM/YYYY";
            endDateBox.LeadingIcon = null;
            endDateBox.Location = new Point(3, 257);
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
            endDateBox.TabIndex = 4;
            endDateBox.TabStop = false;
            endDateBox.TextAlign = HorizontalAlignment.Center;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
            // 
            // AddJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
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
    }
}