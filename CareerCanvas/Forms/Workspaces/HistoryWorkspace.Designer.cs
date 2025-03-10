namespace CareerCanvas.Forms
{
    partial class HistoryWorkspace
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
            components = new System.ComponentModel.Container();
            employmentListBox = new ReaLTaiizor.Controls.MaterialListBox();
            addEmploymentButton = new ReaLTaiizor.Controls.MaterialButton();
            updateJobsTimer = new System.Windows.Forms.Timer(components);
            educationListBox = new ReaLTaiizor.Controls.MaterialListBox();
            addEducationButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            titleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            addCertificateButton = new ReaLTaiizor.Controls.MaterialButton();
            certificatesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            jobsExpansionPanel = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            removeJobButton = new ReaLTaiizor.Controls.MaterialButton();
            educationExpansionPanel = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            removeEducationButton = new ReaLTaiizor.Controls.MaterialButton();
            certificatesExpansionPanel = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            removeCertificateButton = new ReaLTaiizor.Controls.MaterialButton();
            updateEducationTimer = new System.Windows.Forms.Timer(components);
            updateCertificatesTimer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            jobsExpansionPanel.SuspendLayout();
            educationExpansionPanel.SuspendLayout();
            certificatesExpansionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // employmentListBox
            // 
            employmentListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            employmentListBox.BackColor = Color.White;
            employmentListBox.BorderColor = Color.LightGray;
            employmentListBox.Depth = 0;
            employmentListBox.Font = new Font("Roboto", 16F);
            employmentListBox.Location = new Point(27, 67);
            employmentListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            employmentListBox.Name = "employmentListBox";
            employmentListBox.SelectedIndex = -1;
            employmentListBox.SelectedItem = null;
            employmentListBox.ShowScrollBar = true;
            employmentListBox.Size = new Size(458, 391);
            employmentListBox.TabIndex = 0;
            employmentListBox.SelectedIndexChanged += employmentListBox_SelectedIndexChanged;
            // 
            // addEmploymentButton
            // 
            addEmploymentButton.AutoSize = false;
            addEmploymentButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addEmploymentButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addEmploymentButton.Depth = 0;
            addEmploymentButton.HighEmphasis = true;
            addEmploymentButton.Icon = null;
            addEmploymentButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addEmploymentButton.Location = new Point(492, 67);
            addEmploymentButton.Margin = new Padding(4, 6, 4, 6);
            addEmploymentButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addEmploymentButton.Name = "addEmploymentButton";
            addEmploymentButton.NoAccentTextColor = Color.Empty;
            addEmploymentButton.Size = new Size(82, 36);
            addEmploymentButton.TabIndex = 100;
            addEmploymentButton.TabStop = false;
            addEmploymentButton.Text = "Add";
            addEmploymentButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addEmploymentButton.UseAccentColor = false;
            addEmploymentButton.UseVisualStyleBackColor = true;
            addEmploymentButton.Click += addEmploymentButton_Click;
            // 
            // updateJobsTimer
            // 
            updateJobsTimer.Enabled = true;
            updateJobsTimer.Interval = 200;
            updateJobsTimer.Tick += updateJobsTimer_Tick;
            // 
            // educationListBox
            // 
            educationListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            educationListBox.BackColor = Color.White;
            educationListBox.BorderColor = Color.LightGray;
            educationListBox.Depth = 0;
            educationListBox.Font = new Font("Roboto", 16F);
            educationListBox.Location = new Point(27, 67);
            educationListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            educationListBox.Name = "educationListBox";
            educationListBox.SelectedIndex = -1;
            educationListBox.SelectedItem = null;
            educationListBox.ShowScrollBar = true;
            educationListBox.Size = new Size(458, 391);
            educationListBox.TabIndex = 0;
            educationListBox.SelectedIndexChanged += educationListBox_SelectedIndexChanged;
            // 
            // addEducationButton
            // 
            addEducationButton.AutoSize = false;
            addEducationButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addEducationButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addEducationButton.Depth = 0;
            addEducationButton.HighEmphasis = true;
            addEducationButton.Icon = null;
            addEducationButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addEducationButton.Location = new Point(492, 67);
            addEducationButton.Margin = new Padding(4, 6, 4, 6);
            addEducationButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addEducationButton.Name = "addEducationButton";
            addEducationButton.NoAccentTextColor = Color.Empty;
            addEducationButton.Size = new Size(82, 36);
            addEducationButton.TabIndex = 101;
            addEducationButton.TabStop = false;
            addEducationButton.Text = "Add";
            addEducationButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addEducationButton.UseAccentColor = false;
            addEducationButton.UseVisualStyleBackColor = true;
            addEducationButton.Click += addEducationButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.ForeColor = SystemColors.ControlText;
            materialLabel1.Location = new Point(259, 18);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(401, 17);
            materialLabel1.TabIndex = 102;
            materialLabel1.Text = "<---- History is automatically saved on exit IF name is filled out!";
            materialLabel1.UseAccent = true;
            // 
            // titleBox
            // 
            titleBox.Anchor = AnchorStyles.Left;
            titleBox.AnimateReadOnly = false;
            titleBox.AutoCompleteMode = AutoCompleteMode.None;
            titleBox.AutoCompleteSource = AutoCompleteSource.None;
            titleBox.BackgroundImageLayout = ImageLayout.None;
            titleBox.CharacterCasing = CharacterCasing.Normal;
            titleBox.Depth = 0;
            titleBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleBox.HideSelection = true;
            titleBox.Hint = "Industry Name";
            titleBox.LeadingIcon = null;
            titleBox.Location = new Point(3, 3);
            titleBox.MaxLength = 32767;
            titleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            titleBox.Name = "titleBox";
            titleBox.PasswordChar = '\0';
            titleBox.PrefixSuffixText = null;
            titleBox.ReadOnly = false;
            titleBox.RightToLeft = RightToLeft.No;
            titleBox.SelectedText = "";
            titleBox.SelectionLength = 0;
            titleBox.SelectionStart = 0;
            titleBox.ShortcutsEnabled = true;
            titleBox.Size = new Size(250, 48);
            titleBox.TabIndex = 104;
            titleBox.TabStop = false;
            titleBox.TextAlign = HorizontalAlignment.Left;
            titleBox.TrailingIcon = null;
            titleBox.UseSystemPasswordChar = false;
            // 
            // addCertificateButton
            // 
            addCertificateButton.AutoSize = false;
            addCertificateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addCertificateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addCertificateButton.Depth = 0;
            addCertificateButton.HighEmphasis = true;
            addCertificateButton.Icon = null;
            addCertificateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addCertificateButton.Location = new Point(492, 70);
            addCertificateButton.Margin = new Padding(4, 6, 4, 6);
            addCertificateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addCertificateButton.Name = "addCertificateButton";
            addCertificateButton.NoAccentTextColor = Color.Empty;
            addCertificateButton.Size = new Size(82, 36);
            addCertificateButton.TabIndex = 103;
            addCertificateButton.TabStop = false;
            addCertificateButton.Text = "Add";
            addCertificateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addCertificateButton.UseAccentColor = false;
            addCertificateButton.UseVisualStyleBackColor = true;
            addCertificateButton.Click += addCertificateButton_Click;
            // 
            // certificatesListBox
            // 
            certificatesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            certificatesListBox.BackColor = Color.White;
            certificatesListBox.BorderColor = Color.LightGray;
            certificatesListBox.Depth = 0;
            certificatesListBox.Font = new Font("Roboto", 16F);
            certificatesListBox.Location = new Point(27, 67);
            certificatesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            certificatesListBox.Name = "certificatesListBox";
            certificatesListBox.SelectedIndex = -1;
            certificatesListBox.SelectedItem = null;
            certificatesListBox.ShowScrollBar = true;
            certificatesListBox.Size = new Size(458, 391);
            certificatesListBox.TabIndex = 0;
            certificatesListBox.SelectedIndexChanged += certificatesListBox_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(titleBox);
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Location = new Point(9, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1910, 56);
            flowLayoutPanel1.TabIndex = 106;
            // 
            // jobsExpansionPanel
            // 
            jobsExpansionPanel.BackColor = Color.FromArgb(255, 255, 255);
            jobsExpansionPanel.Controls.Add(removeJobButton);
            jobsExpansionPanel.Controls.Add(employmentListBox);
            jobsExpansionPanel.Controls.Add(addEmploymentButton);
            jobsExpansionPanel.Depth = 0;
            jobsExpansionPanel.Description = "Relevant job history";
            jobsExpansionPanel.ExpandHeight = 477;
            jobsExpansionPanel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobsExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            jobsExpansionPanel.Location = new Point(17, 109);
            jobsExpansionPanel.Margin = new Padding(14, 16, 3, 16);
            jobsExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            jobsExpansionPanel.Name = "jobsExpansionPanel";
            jobsExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            jobsExpansionPanel.ShowValidationButtons = false;
            jobsExpansionPanel.Size = new Size(592, 477);
            jobsExpansionPanel.TabIndex = 107;
            jobsExpansionPanel.Title = "Job History";
            // 
            // removeJobButton
            // 
            removeJobButton.AutoSize = false;
            removeJobButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeJobButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeJobButton.Depth = 0;
            removeJobButton.Enabled = false;
            removeJobButton.HighEmphasis = true;
            removeJobButton.Icon = null;
            removeJobButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            removeJobButton.Location = new Point(492, 115);
            removeJobButton.Margin = new Padding(4, 6, 4, 6);
            removeJobButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            removeJobButton.Name = "removeJobButton";
            removeJobButton.NoAccentTextColor = Color.Empty;
            removeJobButton.Size = new Size(82, 36);
            removeJobButton.TabIndex = 101;
            removeJobButton.Text = "Remove";
            removeJobButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            removeJobButton.UseAccentColor = false;
            removeJobButton.UseVisualStyleBackColor = true;
            removeJobButton.Click += removeJobButton_Click;
            // 
            // educationExpansionPanel
            // 
            educationExpansionPanel.BackColor = Color.FromArgb(255, 255, 255);
            educationExpansionPanel.Controls.Add(removeEducationButton);
            educationExpansionPanel.Controls.Add(educationListBox);
            educationExpansionPanel.Controls.Add(addEducationButton);
            educationExpansionPanel.Depth = 0;
            educationExpansionPanel.Description = "Relevant degrees or higher education";
            educationExpansionPanel.ExpandHeight = 477;
            educationExpansionPanel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            educationExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            educationExpansionPanel.Location = new Point(615, 109);
            educationExpansionPanel.Margin = new Padding(3, 16, 3, 16);
            educationExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            educationExpansionPanel.Name = "educationExpansionPanel";
            educationExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            educationExpansionPanel.ShowValidationButtons = false;
            educationExpansionPanel.Size = new Size(590, 477);
            educationExpansionPanel.TabIndex = 108;
            educationExpansionPanel.Title = "Education History";
            // 
            // removeEducationButton
            // 
            removeEducationButton.AutoSize = false;
            removeEducationButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeEducationButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeEducationButton.Depth = 0;
            removeEducationButton.Enabled = false;
            removeEducationButton.HighEmphasis = true;
            removeEducationButton.Icon = null;
            removeEducationButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            removeEducationButton.Location = new Point(492, 115);
            removeEducationButton.Margin = new Padding(4, 6, 4, 6);
            removeEducationButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            removeEducationButton.Name = "removeEducationButton";
            removeEducationButton.NoAccentTextColor = Color.Empty;
            removeEducationButton.Size = new Size(82, 36);
            removeEducationButton.TabIndex = 102;
            removeEducationButton.Text = "Remove";
            removeEducationButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            removeEducationButton.UseAccentColor = false;
            removeEducationButton.UseVisualStyleBackColor = true;
            removeEducationButton.Click += removeEducationButton_Click;
            // 
            // certificatesExpansionPanel
            // 
            certificatesExpansionPanel.BackColor = Color.FromArgb(255, 255, 255);
            certificatesExpansionPanel.Controls.Add(removeCertificateButton);
            certificatesExpansionPanel.Controls.Add(certificatesListBox);
            certificatesExpansionPanel.Controls.Add(addCertificateButton);
            certificatesExpansionPanel.Depth = 0;
            certificatesExpansionPanel.Description = "Relevant certificate programs";
            certificatesExpansionPanel.ExpandHeight = 477;
            certificatesExpansionPanel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            certificatesExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            certificatesExpansionPanel.Location = new Point(1211, 109);
            certificatesExpansionPanel.Margin = new Padding(3, 16, 3, 16);
            certificatesExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            certificatesExpansionPanel.Name = "certificatesExpansionPanel";
            certificatesExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            certificatesExpansionPanel.ShowValidationButtons = false;
            certificatesExpansionPanel.Size = new Size(592, 477);
            certificatesExpansionPanel.TabIndex = 2;
            certificatesExpansionPanel.Title = "Certificates";
            // 
            // removeCertificateButton
            // 
            removeCertificateButton.AutoSize = false;
            removeCertificateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeCertificateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeCertificateButton.Depth = 0;
            removeCertificateButton.Enabled = false;
            removeCertificateButton.HighEmphasis = true;
            removeCertificateButton.Icon = null;
            removeCertificateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            removeCertificateButton.Location = new Point(492, 118);
            removeCertificateButton.Margin = new Padding(4, 6, 4, 6);
            removeCertificateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            removeCertificateButton.Name = "removeCertificateButton";
            removeCertificateButton.NoAccentTextColor = Color.Empty;
            removeCertificateButton.Size = new Size(82, 36);
            removeCertificateButton.TabIndex = 103;
            removeCertificateButton.Text = "Remove";
            removeCertificateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            removeCertificateButton.UseAccentColor = false;
            removeCertificateButton.UseVisualStyleBackColor = true;
            removeCertificateButton.Click += removeCertificateButton_Click;
            // 
            // updateEducationTimer
            // 
            updateEducationTimer.Enabled = true;
            updateEducationTimer.Interval = 200;
            updateEducationTimer.Tick += updateEducationTimer_Tick;
            // 
            // updateCertificatesTimer
            // 
            updateCertificatesTimer.Enabled = true;
            updateCertificatesTimer.Interval = 200;
            updateCertificatesTimer.Tick += updateCertificatesTimer_Tick;
            // 
            // HistoryWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 605);
            Controls.Add(certificatesExpansionPanel);
            Controls.Add(educationExpansionPanel);
            Controls.Add(jobsExpansionPanel);
            Controls.Add(flowLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "HistoryWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "History Workspace";
            FormClosing += HistoryWorkspace_FormClosing;
            Load += HistoryWorkspace_Load;
            Shown += HistoryWorkspace_Shown;
            Click += HistoryWorkspace_Click;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            jobsExpansionPanel.ResumeLayout(false);
            jobsExpansionPanel.PerformLayout();
            educationExpansionPanel.ResumeLayout(false);
            educationExpansionPanel.PerformLayout();
            certificatesExpansionPanel.ResumeLayout(false);
            certificatesExpansionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton addEmploymentButton;
        private ReaLTaiizor.Controls.MaterialListBox employmentListBox;
        private System.Windows.Forms.Timer updateJobsTimer;
        private ReaLTaiizor.Controls.MaterialListBox educationListBox;
        private ReaLTaiizor.Controls.MaterialButton addEducationButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit titleBox;
        private ReaLTaiizor.Controls.MaterialButton addCertificateButton;
        private ReaLTaiizor.Controls.MaterialListBox certificatesListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialExpansionPanel jobsExpansionPanel;
        private ReaLTaiizor.Controls.MaterialExpansionPanel educationExpansionPanel;
        private ReaLTaiizor.Controls.MaterialExpansionPanel certificatesExpansionPanel;
        private ReaLTaiizor.Controls.MaterialButton removeJobButton;
        private System.Windows.Forms.Timer updateEducationTimer;
        private System.Windows.Forms.Timer updateCertificatesTimer;
        private ReaLTaiizor.Controls.MaterialButton removeEducationButton;
        private ReaLTaiizor.Controls.MaterialButton removeCertificateButton;
    }
}