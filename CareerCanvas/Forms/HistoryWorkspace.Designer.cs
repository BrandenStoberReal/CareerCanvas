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
            employmentHistoryCard = new ReaLTaiizor.Controls.MaterialCard();
            jobTitleLabel = new ReaLTaiizor.Controls.MaterialLabel();
            employmentListBox = new ReaLTaiizor.Controls.MaterialListBox();
            addEmploymentButton = new ReaLTaiizor.Controls.MaterialButton();
            updateJobsTimer = new System.Windows.Forms.Timer(components);
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            educationLabel = new ReaLTaiizor.Controls.MaterialLabel();
            educationListBox = new ReaLTaiizor.Controls.MaterialListBox();
            addEducationButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            titleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            employmentHistoryCard.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // employmentHistoryCard
            // 
            employmentHistoryCard.BackColor = Color.FromArgb(255, 255, 255);
            employmentHistoryCard.Controls.Add(jobTitleLabel);
            employmentHistoryCard.Controls.Add(employmentListBox);
            employmentHistoryCard.Depth = 0;
            employmentHistoryCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            employmentHistoryCard.Location = new Point(24, 138);
            employmentHistoryCard.Margin = new Padding(14);
            employmentHistoryCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            employmentHistoryCard.Name = "employmentHistoryCard";
            employmentHistoryCard.Padding = new Padding(14);
            employmentHistoryCard.Size = new Size(543, 594);
            employmentHistoryCard.TabIndex = 0;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            jobTitleLabel.Depth = 0;
            jobTitleLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            jobTitleLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            jobTitleLabel.Location = new Point(17, 14);
            jobTitleLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(509, 23);
            jobTitleLabel.TabIndex = 1;
            jobTitleLabel.Text = "Jobs";
            jobTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employmentListBox
            // 
            employmentListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employmentListBox.BackColor = Color.White;
            employmentListBox.BorderColor = Color.LightGray;
            employmentListBox.Depth = 0;
            employmentListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employmentListBox.Location = new Point(17, 40);
            employmentListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            employmentListBox.Name = "employmentListBox";
            employmentListBox.SelectedIndex = -1;
            employmentListBox.SelectedItem = null;
            employmentListBox.Size = new Size(509, 537);
            employmentListBox.TabIndex = 0;
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
            addEmploymentButton.Location = new Point(585, 138);
            addEmploymentButton.Margin = new Padding(4, 6, 4, 6);
            addEmploymentButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addEmploymentButton.Name = "addEmploymentButton";
            addEmploymentButton.NoAccentTextColor = Color.Empty;
            addEmploymentButton.Size = new Size(82, 36);
            addEmploymentButton.TabIndex = 100;
            addEmploymentButton.TabStop = false;
            addEmploymentButton.Text = "Add Job";
            addEmploymentButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addEmploymentButton.UseAccentColor = false;
            addEmploymentButton.UseVisualStyleBackColor = true;
            addEmploymentButton.Click += addEmploymentButton_Click;
            // 
            // updateJobsTimer
            // 
            updateJobsTimer.Enabled = true;
            updateJobsTimer.Interval = 500;
            updateJobsTimer.Tick += updateJobsTimer_Tick;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(educationLabel);
            materialCard1.Controls.Add(educationListBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(727, 138);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(543, 594);
            materialCard1.TabIndex = 2;
            // 
            // educationLabel
            // 
            educationLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            educationLabel.Depth = 0;
            educationLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            educationLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            educationLabel.Location = new Point(17, 14);
            educationLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new Size(509, 23);
            educationLabel.TabIndex = 1;
            educationLabel.Text = "Education";
            educationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // educationListBox
            // 
            educationListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            educationListBox.BackColor = Color.White;
            educationListBox.BorderColor = Color.LightGray;
            educationListBox.Depth = 0;
            educationListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            educationListBox.Location = new Point(17, 40);
            educationListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            educationListBox.Name = "educationListBox";
            educationListBox.SelectedIndex = -1;
            educationListBox.SelectedItem = null;
            educationListBox.Size = new Size(509, 537);
            educationListBox.TabIndex = 0;
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
            addEducationButton.Location = new Point(1288, 138);
            addEducationButton.Margin = new Padding(4, 6, 4, 6);
            addEducationButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addEducationButton.Name = "addEducationButton";
            addEducationButton.NoAccentTextColor = Color.Empty;
            addEducationButton.Size = new Size(124, 36);
            addEducationButton.TabIndex = 101;
            addEducationButton.TabStop = false;
            addEducationButton.Text = "Add Education";
            addEducationButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addEducationButton.UseAccentColor = false;
            addEducationButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.ForeColor = SystemColors.ControlText;
            materialLabel1.Location = new Point(1048, 31);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(401, 17);
            materialLabel1.TabIndex = 102;
            materialLabel1.Text = "<---- History is automatically saved on exit IF name is filled out!";
            materialLabel1.UseAccent = true;
            // 
            // titleBox
            // 
            titleBox.AnimateReadOnly = false;
            titleBox.AutoCompleteMode = AutoCompleteMode.None;
            titleBox.AutoCompleteSource = AutoCompleteSource.None;
            titleBox.BackgroundImageLayout = ImageLayout.None;
            titleBox.CharacterCasing = CharacterCasing.Normal;
            titleBox.Depth = 0;
            titleBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleBox.HideSelection = true;
            titleBox.Hint = "History Name";
            titleBox.LeadingIcon = null;
            titleBox.Location = new Point(24, 37);
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
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(6, 98);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(1443, 23);
            materialDivider1.TabIndex = 105;
            materialDivider1.Text = "materialDivider1";
            // 
            // HistoryWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 758);
            Controls.Add(titleBox);
            Controls.Add(materialDivider1);
            Controls.Add(materialLabel1);
            Controls.Add(addEducationButton);
            Controls.Add(materialCard1);
            Controls.Add(addEmploymentButton);
            Controls.Add(employmentHistoryCard);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "HistoryWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "History Workspace";
            Load += HistoryWorkspace_Load;
            Shown += HistoryWorkspace_Shown;
            Click += HistoryWorkspace_Click;
            employmentHistoryCard.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard employmentHistoryCard;
        private ReaLTaiizor.Controls.MaterialButton addEmploymentButton;
        private ReaLTaiizor.Controls.MaterialListBox employmentListBox;
        private ReaLTaiizor.Controls.MaterialLabel jobTitleLabel;
        private System.Windows.Forms.Timer updateJobsTimer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel educationLabel;
        private ReaLTaiizor.Controls.MaterialListBox educationListBox;
        private ReaLTaiizor.Controls.MaterialButton addEducationButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit titleBox;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
    }
}