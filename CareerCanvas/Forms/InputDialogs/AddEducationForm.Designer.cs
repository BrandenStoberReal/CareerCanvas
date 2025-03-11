namespace CareerCanvas.Forms.InputDialogs
{
    partial class AddEducationForm
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
            schoolNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            degreeComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            startDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            endDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            discardButton = new ReaLTaiizor.Controls.MaterialButton();
            addJobButton = new ReaLTaiizor.Controls.MaterialButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(schoolNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(degreeComboBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 369);
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
            materialLabel1.Size = new Size(89, 17);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "School Name:";
            // 
            // schoolNameBox
            // 
            schoolNameBox.AnimateReadOnly = false;
            schoolNameBox.AutoCompleteMode = AutoCompleteMode.None;
            schoolNameBox.AutoCompleteSource = AutoCompleteSource.None;
            schoolNameBox.BackgroundImageLayout = ImageLayout.None;
            schoolNameBox.CharacterCasing = CharacterCasing.Normal;
            schoolNameBox.Depth = 0;
            schoolNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            schoolNameBox.HideSelection = true;
            schoolNameBox.Hint = "Institution Name";
            schoolNameBox.LeadingIcon = null;
            schoolNameBox.Location = new Point(3, 26);
            schoolNameBox.MaxLength = 32767;
            schoolNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            schoolNameBox.Name = "schoolNameBox";
            schoolNameBox.PasswordChar = '\0';
            schoolNameBox.PrefixSuffixText = null;
            schoolNameBox.ReadOnly = false;
            schoolNameBox.RightToLeft = RightToLeft.No;
            schoolNameBox.SelectedText = "";
            schoolNameBox.SelectionLength = 0;
            schoolNameBox.SelectionStart = 0;
            schoolNameBox.ShortcutsEnabled = true;
            schoolNameBox.Size = new Size(250, 48);
            schoolNameBox.TabIndex = 1;
            schoolNameBox.TextAlign = HorizontalAlignment.Center;
            schoolNameBox.TrailingIcon = null;
            schoolNameBox.UseSystemPasswordChar = false;
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
            materialLabel2.Size = new Size(51, 17);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Degree:";
            // 
            // degreeComboBox
            // 
            degreeComboBox.AutoResize = false;
            degreeComboBox.BackColor = Color.FromArgb(255, 255, 255);
            degreeComboBox.Depth = 0;
            degreeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            degreeComboBox.DropDownHeight = 174;
            degreeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            degreeComboBox.DropDownWidth = 121;
            degreeComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            degreeComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            degreeComboBox.FormattingEnabled = true;
            degreeComboBox.IntegralHeight = false;
            degreeComboBox.ItemHeight = 43;
            degreeComboBox.Items.AddRange(new object[] { "High School Diploma", "Associate's Degree", "Bacholar's Degree", "Master's Degree", "Doctorate Degree" });
            degreeComboBox.Location = new Point(3, 103);
            degreeComboBox.MaxDropDownItems = 4;
            degreeComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            degreeComboBox.Name = "degreeComboBox";
            degreeComboBox.Size = new Size(250, 49);
            degreeComboBox.StartIndex = 0;
            degreeComboBox.TabIndex = 2;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Left;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel3.Location = new Point(3, 161);
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
            startDateBox.Location = new Point(3, 181);
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
            materialLabel4.Location = new Point(3, 238);
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
            endDateBox.Location = new Point(3, 258);
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
            endDateBox.TextAlign = HorizontalAlignment.Center;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
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
            discardButton.Location = new Point(309, 405);
            discardButton.Margin = new Padding(4, 6, 4, 6);
            discardButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            discardButton.Name = "discardButton";
            discardButton.NoAccentTextColor = Color.Empty;
            discardButton.Size = new Size(75, 36);
            discardButton.TabIndex = 6;
            discardButton.TabStop = false;
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
            addJobButton.Location = new Point(8, 405);
            addJobButton.Margin = new Padding(4, 6, 4, 6);
            addJobButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addJobButton.Name = "addJobButton";
            addJobButton.NoAccentTextColor = Color.Empty;
            addJobButton.Size = new Size(75, 36);
            addJobButton.TabIndex = 5;
            addJobButton.TabStop = false;
            addJobButton.Text = "Add";
            addJobButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addJobButton.UseAccentColor = false;
            addJobButton.UseVisualStyleBackColor = true;
            addJobButton.Click += addJobButton_Click;
            // 
            // AddEducationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(discardButton);
            Controls.Add(addJobButton);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "AddEducationForm";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Add Education";
            Load += AddEducationForm_Load;
            Shown += AddEducationForm_Shown;
            Click += AddEducationForm_Click;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit schoolNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialComboBox degreeComboBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit startDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endDateBox;
        private ReaLTaiizor.Controls.MaterialButton discardButton;
        private ReaLTaiizor.Controls.MaterialButton addJobButton;
    }
}