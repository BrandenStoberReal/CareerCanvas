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
            employmentHistoryCard.SuspendLayout();
            SuspendLayout();
            // 
            // employmentHistoryCard
            // 
            employmentHistoryCard.BackColor = Color.FromArgb(255, 255, 255);
            employmentHistoryCard.Controls.Add(jobTitleLabel);
            employmentHistoryCard.Controls.Add(employmentListBox);
            employmentHistoryCard.Depth = 0;
            employmentHistoryCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            employmentHistoryCard.Location = new Point(17, 38);
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
            addEmploymentButton.Location = new Point(578, 38);
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
            // HistoryWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 640);
            Controls.Add(addEmploymentButton);
            Controls.Add(employmentHistoryCard);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "HistoryWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "History Workspace";
            Load += HistoryWorkspace_Load;
            Shown += HistoryWorkspace_Shown;
            employmentHistoryCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard employmentHistoryCard;
        private ReaLTaiizor.Controls.MaterialButton addEmploymentButton;
        private ReaLTaiizor.Controls.MaterialListBox employmentListBox;
        private ReaLTaiizor.Controls.MaterialLabel jobTitleLabel;
        private System.Windows.Forms.Timer updateJobsTimer;
    }
}