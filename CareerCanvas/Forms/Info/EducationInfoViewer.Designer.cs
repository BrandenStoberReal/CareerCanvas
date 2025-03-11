namespace CareerCanvas.Forms.Info
{
    partial class EducationInfoViewer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            schoolNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            cityBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            stateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            degreeBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            startDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            endDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            materialCard1.Size = new Size(602, 367);
            materialCard1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(schoolNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(cityBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(stateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(degreeBox);
            flowLayoutPanel1.Controls.Add(materialLabel5);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel6);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.Location = new Point(17, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(568, 333);
            flowLayoutPanel1.TabIndex = 0;
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
            materialLabel1.Size = new Size(100, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "School Name:";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            schoolNameBox.LeadingIcon = null;
            schoolNameBox.Location = new Point(109, 3);
            schoolNameBox.MaxLength = 32767;
            schoolNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            schoolNameBox.Name = "schoolNameBox";
            schoolNameBox.PasswordChar = '\0';
            schoolNameBox.PrefixSuffixText = null;
            schoolNameBox.ReadOnly = true;
            schoolNameBox.RightToLeft = RightToLeft.No;
            schoolNameBox.SelectedText = "";
            schoolNameBox.SelectionLength = 0;
            schoolNameBox.SelectionStart = 0;
            schoolNameBox.ShortcutsEnabled = true;
            schoolNameBox.Size = new Size(449, 48);
            schoolNameBox.TabIndex = 1;
            schoolNameBox.TabStop = false;
            schoolNameBox.Text = "None provided.";
            schoolNameBox.TextAlign = HorizontalAlignment.Left;
            schoolNameBox.TrailingIcon = null;
            schoolNameBox.UseSystemPasswordChar = false;
            schoolNameBox.Click += textBox_Click;
            schoolNameBox.Enter += textBox_Enter;
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
            materialLabel2.Size = new Size(32, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "City:";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cityBox
            // 
            cityBox.AnimateReadOnly = false;
            cityBox.AutoCompleteMode = AutoCompleteMode.None;
            cityBox.AutoCompleteSource = AutoCompleteSource.None;
            cityBox.BackgroundImageLayout = ImageLayout.None;
            cityBox.CharacterCasing = CharacterCasing.Normal;
            cityBox.Depth = 0;
            cityBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cityBox.HideSelection = true;
            cityBox.LeadingIcon = null;
            cityBox.Location = new Point(41, 57);
            cityBox.MaxLength = 32767;
            cityBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cityBox.Name = "cityBox";
            cityBox.PasswordChar = '\0';
            cityBox.PrefixSuffixText = null;
            cityBox.ReadOnly = true;
            cityBox.RightToLeft = RightToLeft.No;
            cityBox.SelectedText = "";
            cityBox.SelectionLength = 0;
            cityBox.SelectionStart = 0;
            cityBox.ShortcutsEnabled = true;
            cityBox.Size = new Size(517, 48);
            cityBox.TabIndex = 3;
            cityBox.TabStop = false;
            cityBox.Text = "None provided.";
            cityBox.TextAlign = HorizontalAlignment.Left;
            cityBox.TrailingIcon = null;
            cityBox.UseSystemPasswordChar = false;
            cityBox.Click += textBox_Click;
            cityBox.Enter += textBox_Enter;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Left;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(3, 125);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(42, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "State:";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stateBox
            // 
            stateBox.AnimateReadOnly = false;
            stateBox.AutoCompleteMode = AutoCompleteMode.None;
            stateBox.AutoCompleteSource = AutoCompleteSource.None;
            stateBox.BackgroundImageLayout = ImageLayout.None;
            stateBox.CharacterCasing = CharacterCasing.Normal;
            stateBox.Depth = 0;
            stateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            stateBox.HideSelection = true;
            stateBox.LeadingIcon = null;
            stateBox.Location = new Point(51, 111);
            stateBox.MaxLength = 32767;
            stateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            stateBox.Name = "stateBox";
            stateBox.PasswordChar = '\0';
            stateBox.PrefixSuffixText = null;
            stateBox.ReadOnly = true;
            stateBox.RightToLeft = RightToLeft.No;
            stateBox.SelectedText = "";
            stateBox.SelectionLength = 0;
            stateBox.SelectionStart = 0;
            stateBox.ShortcutsEnabled = true;
            stateBox.Size = new Size(507, 48);
            stateBox.TabIndex = 5;
            stateBox.TabStop = false;
            stateBox.Text = "None provided.";
            stateBox.TextAlign = HorizontalAlignment.Left;
            stateBox.TrailingIcon = null;
            stateBox.UseSystemPasswordChar = false;
            stateBox.Click += textBox_Click;
            stateBox.Enter += textBox_Enter;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Left;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(3, 179);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(54, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Degree:";
            materialLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // degreeBox
            // 
            degreeBox.AnimateReadOnly = false;
            degreeBox.AutoCompleteMode = AutoCompleteMode.None;
            degreeBox.AutoCompleteSource = AutoCompleteSource.None;
            degreeBox.BackgroundImageLayout = ImageLayout.None;
            degreeBox.CharacterCasing = CharacterCasing.Normal;
            degreeBox.Depth = 0;
            degreeBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            degreeBox.HideSelection = true;
            degreeBox.LeadingIcon = null;
            degreeBox.Location = new Point(63, 165);
            degreeBox.MaxLength = 32767;
            degreeBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            degreeBox.Name = "degreeBox";
            degreeBox.PasswordChar = '\0';
            degreeBox.PrefixSuffixText = null;
            degreeBox.ReadOnly = true;
            degreeBox.RightToLeft = RightToLeft.No;
            degreeBox.SelectedText = "";
            degreeBox.SelectionLength = 0;
            degreeBox.SelectionStart = 0;
            degreeBox.ShortcutsEnabled = true;
            degreeBox.Size = new Size(495, 48);
            degreeBox.TabIndex = 7;
            degreeBox.TabStop = false;
            degreeBox.Text = "None provided.";
            degreeBox.TextAlign = HorizontalAlignment.Left;
            degreeBox.TrailingIcon = null;
            degreeBox.UseSystemPasswordChar = false;
            degreeBox.Click += textBox_Click;
            degreeBox.Enter += textBox_Enter;
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Left;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(3, 233);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(76, 19);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Start Date:";
            materialLabel5.TextAlign = ContentAlignment.MiddleCenter;
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
            startDateBox.LeadingIcon = null;
            startDateBox.Location = new Point(85, 219);
            startDateBox.MaxLength = 32767;
            startDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            startDateBox.Name = "startDateBox";
            startDateBox.PasswordChar = '\0';
            startDateBox.PrefixSuffixText = null;
            startDateBox.ReadOnly = true;
            startDateBox.RightToLeft = RightToLeft.No;
            startDateBox.SelectedText = "";
            startDateBox.SelectionLength = 0;
            startDateBox.SelectionStart = 0;
            startDateBox.ShortcutsEnabled = true;
            startDateBox.Size = new Size(473, 48);
            startDateBox.TabIndex = 9;
            startDateBox.TabStop = false;
            startDateBox.Text = "None provided.";
            startDateBox.TextAlign = HorizontalAlignment.Left;
            startDateBox.TrailingIcon = null;
            startDateBox.UseSystemPasswordChar = false;
            startDateBox.Click += textBox_Click;
            startDateBox.Enter += textBox_Enter;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Left;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(3, 287);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(69, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "End Date:";
            materialLabel6.TextAlign = ContentAlignment.MiddleCenter;
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
            endDateBox.LeadingIcon = null;
            endDateBox.Location = new Point(78, 273);
            endDateBox.MaxLength = 32767;
            endDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            endDateBox.Name = "endDateBox";
            endDateBox.PasswordChar = '\0';
            endDateBox.PrefixSuffixText = null;
            endDateBox.ReadOnly = true;
            endDateBox.RightToLeft = RightToLeft.No;
            endDateBox.SelectedText = "";
            endDateBox.SelectionLength = 0;
            endDateBox.SelectionStart = 0;
            endDateBox.ShortcutsEnabled = true;
            endDateBox.Size = new Size(480, 48);
            endDateBox.TabIndex = 11;
            endDateBox.TabStop = false;
            endDateBox.Text = "None provided.";
            endDateBox.TextAlign = HorizontalAlignment.Left;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
            endDateBox.Click += textBox_Click;
            endDateBox.Enter += textBox_Enter;
            // 
            // EducationInfoViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 422);
            Controls.Add(materialCard1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "EducationInfoViewer";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Schooling Info";
            Load += EducationInfoViewer_Load;
            materialCard1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit schoolNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cityBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit stateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit degreeBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit startDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endDateBox;
    }
}