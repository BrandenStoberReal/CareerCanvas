namespace CareerCanvas.Forms.InputDialogs
{
    partial class AddSkillForm
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
            skillNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            skillNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            yearsExperienceLabel = new ReaLTaiizor.Controls.MaterialLabel();
            yearsBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            addJobButton.Location = new Point(13, 218);
            addJobButton.Margin = new Padding(4, 6, 4, 6);
            addJobButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addJobButton.Name = "addJobButton";
            addJobButton.NoAccentTextColor = Color.Empty;
            addJobButton.Size = new Size(112, 36);
            addJobButton.TabIndex = 7;
            addJobButton.Text = "Save Skill";
            addJobButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addJobButton.UseAccentColor = false;
            addJobButton.UseVisualStyleBackColor = true;
            addJobButton.Click += addSkillButton_Click;
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
            discardButton.Location = new Point(158, 218);
            discardButton.Margin = new Padding(4, 6, 4, 6);
            discardButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            discardButton.Name = "discardButton";
            discardButton.NoAccentTextColor = Color.Empty;
            discardButton.Size = new Size(156, 36);
            discardButton.TabIndex = 8;
            discardButton.Text = "Discard Changes";
            discardButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            discardButton.UseAccentColor = false;
            discardButton.UseVisualStyleBackColor = true;
            discardButton.Click += discardButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(skillNameLabel);
            flowLayoutPanel1.Controls.Add(skillNameBox);
            flowLayoutPanel1.Controls.Add(yearsExperienceLabel);
            flowLayoutPanel1.Controls.Add(yearsBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 34);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(301, 172);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            // 
            // skillNameLabel
            // 
            skillNameLabel.Anchor = AnchorStyles.Left;
            skillNameLabel.AutoSize = true;
            skillNameLabel.Depth = 0;
            skillNameLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            skillNameLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            skillNameLabel.Location = new Point(3, 6);
            skillNameLabel.Margin = new Padding(3, 6, 3, 0);
            skillNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            skillNameLabel.Name = "skillNameLabel";
            skillNameLabel.Size = new Size(73, 17);
            skillNameLabel.TabIndex = 0;
            skillNameLabel.Text = "Skill Name:";
            // 
            // skillNameBox
            // 
            skillNameBox.AnimateReadOnly = false;
            skillNameBox.AutoCompleteMode = AutoCompleteMode.None;
            skillNameBox.AutoCompleteSource = AutoCompleteSource.None;
            skillNameBox.BackgroundImageLayout = ImageLayout.None;
            skillNameBox.CharacterCasing = CharacterCasing.Normal;
            skillNameBox.Depth = 0;
            skillNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            skillNameBox.HideSelection = true;
            skillNameBox.Hint = "Skill Name";
            skillNameBox.LeadingIcon = null;
            skillNameBox.Location = new Point(3, 26);
            skillNameBox.MaxLength = 32767;
            skillNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            skillNameBox.Name = "skillNameBox";
            skillNameBox.PasswordChar = '\0';
            skillNameBox.PrefixSuffixText = null;
            skillNameBox.ReadOnly = false;
            skillNameBox.RightToLeft = RightToLeft.No;
            skillNameBox.SelectedText = "";
            skillNameBox.SelectionLength = 0;
            skillNameBox.SelectionStart = 0;
            skillNameBox.ShortcutsEnabled = true;
            skillNameBox.Size = new Size(285, 48);
            skillNameBox.TabIndex = 1;
            skillNameBox.TabStop = false;
            skillNameBox.TextAlign = HorizontalAlignment.Center;
            skillNameBox.TrailingIcon = null;
            skillNameBox.UseSystemPasswordChar = false;
            // 
            // yearsExperienceLabel
            // 
            yearsExperienceLabel.Anchor = AnchorStyles.Left;
            yearsExperienceLabel.AutoSize = true;
            yearsExperienceLabel.Depth = 0;
            yearsExperienceLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            yearsExperienceLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            yearsExperienceLabel.Location = new Point(3, 83);
            yearsExperienceLabel.Margin = new Padding(3, 6, 3, 0);
            yearsExperienceLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            yearsExperienceLabel.Name = "yearsExperienceLabel";
            yearsExperienceLabel.Size = new Size(132, 17);
            yearsExperienceLabel.TabIndex = 2;
            yearsExperienceLabel.Text = "Years of Experience:";
            // 
            // yearsBox
            // 
            yearsBox.AnimateReadOnly = false;
            yearsBox.AutoCompleteMode = AutoCompleteMode.None;
            yearsBox.AutoCompleteSource = AutoCompleteSource.None;
            yearsBox.BackgroundImageLayout = ImageLayout.None;
            yearsBox.CharacterCasing = CharacterCasing.Normal;
            yearsBox.Depth = 0;
            yearsBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            yearsBox.HideSelection = true;
            yearsBox.Hint = "Years";
            yearsBox.LeadingIcon = null;
            yearsBox.Location = new Point(3, 103);
            yearsBox.MaxLength = 32767;
            yearsBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            yearsBox.Name = "yearsBox";
            yearsBox.PasswordChar = '\0';
            yearsBox.PrefixSuffixText = null;
            yearsBox.ReadOnly = false;
            yearsBox.RightToLeft = RightToLeft.No;
            yearsBox.SelectedText = "";
            yearsBox.SelectionLength = 0;
            yearsBox.SelectionStart = 0;
            yearsBox.ShortcutsEnabled = true;
            yearsBox.Size = new Size(285, 48);
            yearsBox.TabIndex = 2;
            yearsBox.TabStop = false;
            yearsBox.TextAlign = HorizontalAlignment.Center;
            yearsBox.TrailingIcon = null;
            yearsBox.UseSystemPasswordChar = false;
            // 
            // AddSkillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 263);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(discardButton);
            Controls.Add(addJobButton);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "AddSkillForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Add New Skill";
            FormClosing += AddSkillForm_FormClosing;
            Load += AddSkillForm_Load;
            Shown += AddSkillForm_Shown;
            Click += AddSkillForm_Click;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton addJobButton;
        private ReaLTaiizor.Controls.MaterialButton discardButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel skillNameLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit skillNameBox;
        private ReaLTaiizor.Controls.MaterialLabel yearsExperienceLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit yearsBox;
    }
}