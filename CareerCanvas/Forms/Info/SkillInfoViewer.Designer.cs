namespace CareerCanvas.Forms.Info
{
    partial class SkillInfoViewer
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            yearsBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            skillNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialCard1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(flowLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 38);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(555, 367);
            materialCard1.TabIndex = 0;
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
            yearsBox.LeadingIcon = null;
            yearsBox.Location = new Point(153, 57);
            yearsBox.MaxLength = 32767;
            yearsBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            yearsBox.Name = "yearsBox";
            yearsBox.PasswordChar = '\0';
            yearsBox.PrefixSuffixText = null;
            yearsBox.ReadOnly = true;
            yearsBox.RightToLeft = RightToLeft.No;
            yearsBox.SelectedText = "";
            yearsBox.SelectionLength = 0;
            yearsBox.SelectionStart = 0;
            yearsBox.ShortcutsEnabled = true;
            yearsBox.Size = new Size(338, 48);
            yearsBox.TabIndex = 3;
            yearsBox.TabStop = false;
            yearsBox.Text = "None provided.";
            yearsBox.TextAlign = HorizontalAlignment.Left;
            yearsBox.TrailingIcon = null;
            yearsBox.UseSystemPasswordChar = false;
            yearsBox.Click += textBox_Click;
            yearsBox.Enter += textBox_Enter;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(3, 71);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(144, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Years of Experience:";
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
            skillNameBox.LeadingIcon = null;
            skillNameBox.Location = new Point(90, 3);
            skillNameBox.MaxLength = 32767;
            skillNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            skillNameBox.Name = "skillNameBox";
            skillNameBox.PasswordChar = '\0';
            skillNameBox.PrefixSuffixText = null;
            skillNameBox.ReadOnly = true;
            skillNameBox.RightToLeft = RightToLeft.No;
            skillNameBox.SelectedText = "";
            skillNameBox.SelectionLength = 0;
            skillNameBox.SelectionStart = 0;
            skillNameBox.ShortcutsEnabled = true;
            skillNameBox.Size = new Size(342, 48);
            skillNameBox.TabIndex = 1;
            skillNameBox.TabStop = false;
            skillNameBox.Text = "None provided.";
            skillNameBox.TextAlign = HorizontalAlignment.Left;
            skillNameBox.TrailingIcon = null;
            skillNameBox.UseSystemPasswordChar = false;
            skillNameBox.Click += textBox_Click;
            skillNameBox.Enter += textBox_Enter;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 17);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(81, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Skill Name:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(skillNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(yearsBox);
            flowLayoutPanel1.Location = new Point(17, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(521, 333);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // SkillInfoViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 422);
            Controls.Add(materialCard1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "SkillInfoViewer";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Job Info";
            Load += SkillInfoViewer_Load;
            Shown += SkillInfoViewer_Shown;
            materialCard1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit skillNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit yearsBox;
    }
}