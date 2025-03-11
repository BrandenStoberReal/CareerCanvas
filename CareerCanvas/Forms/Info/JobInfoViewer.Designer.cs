namespace CareerCanvas.Forms.Info
{
    partial class JobInfoViewer
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
            jobDescriptionBox = new ReaLTaiizor.Controls.MaterialRichTextBox();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            jobTitleBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            employerBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            cityBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            stateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            materialCard1.Controls.Add(jobDescriptionBox);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Controls.Add(flowLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 38);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(766, 367);
            materialCard1.TabIndex = 0;
            // 
            // jobDescriptionBox
            // 
            jobDescriptionBox.BackColor = Color.FromArgb(255, 255, 255);
            jobDescriptionBox.BorderStyle = BorderStyle.None;
            jobDescriptionBox.Depth = 0;
            jobDescriptionBox.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            jobDescriptionBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            jobDescriptionBox.Hint = "";
            jobDescriptionBox.Location = new Point(445, 43);
            jobDescriptionBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            jobDescriptionBox.Name = "jobDescriptionBox";
            jobDescriptionBox.ReadOnly = true;
            jobDescriptionBox.Size = new Size(304, 307);
            jobDescriptionBox.TabIndex = 2;
            jobDescriptionBox.Text = "None provided.";
            jobDescriptionBox.Enter += textBox_Enter;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(445, 17);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(304, 23);
            materialLabel7.TabIndex = 1;
            materialLabel7.Text = "Job Description";
            materialLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(jobTitleBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(employerBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(cityBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(stateBox);
            flowLayoutPanel1.Controls.Add(materialLabel5);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel6);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.Location = new Point(17, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(422, 333);
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
            materialLabel1.Size = new Size(67, 19);
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
            jobTitleBox.LeadingIcon = null;
            jobTitleBox.Location = new Point(76, 3);
            jobTitleBox.MaxLength = 32767;
            jobTitleBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            jobTitleBox.Name = "jobTitleBox";
            jobTitleBox.PasswordChar = '\0';
            jobTitleBox.PrefixSuffixText = null;
            jobTitleBox.ReadOnly = true;
            jobTitleBox.RightToLeft = RightToLeft.No;
            jobTitleBox.SelectedText = "";
            jobTitleBox.SelectionLength = 0;
            jobTitleBox.SelectionStart = 0;
            jobTitleBox.ShortcutsEnabled = true;
            jobTitleBox.Size = new Size(342, 48);
            jobTitleBox.TabIndex = 1;
            jobTitleBox.TabStop = false;
            jobTitleBox.Text = "None provided.";
            jobTitleBox.TextAlign = HorizontalAlignment.Left;
            jobTitleBox.TrailingIcon = null;
            jobTitleBox.UseSystemPasswordChar = false;
            jobTitleBox.Click += textBox_Click;
            jobTitleBox.Enter += textBox_Enter;
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
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Employer:";
            // 
            // employerBox
            // 
            employerBox.AnimateReadOnly = false;
            employerBox.AutoCompleteMode = AutoCompleteMode.None;
            employerBox.AutoCompleteSource = AutoCompleteSource.None;
            employerBox.BackgroundImageLayout = ImageLayout.None;
            employerBox.CharacterCasing = CharacterCasing.Normal;
            employerBox.Depth = 0;
            employerBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employerBox.HideSelection = true;
            employerBox.LeadingIcon = null;
            employerBox.Location = new Point(80, 57);
            employerBox.MaxLength = 32767;
            employerBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            employerBox.Name = "employerBox";
            employerBox.PasswordChar = '\0';
            employerBox.PrefixSuffixText = null;
            employerBox.ReadOnly = true;
            employerBox.RightToLeft = RightToLeft.No;
            employerBox.SelectedText = "";
            employerBox.SelectionLength = 0;
            employerBox.SelectionStart = 0;
            employerBox.ShortcutsEnabled = true;
            employerBox.Size = new Size(338, 48);
            employerBox.TabIndex = 3;
            employerBox.TabStop = false;
            employerBox.Text = "None provided.";
            employerBox.TextAlign = HorizontalAlignment.Left;
            employerBox.TrailingIcon = null;
            employerBox.UseSystemPasswordChar = false;
            employerBox.Click += textBox_Click;
            employerBox.Enter += textBox_Enter;
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
            materialLabel3.Size = new Size(32, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "City:";
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
            cityBox.Location = new Point(41, 111);
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
            cityBox.Size = new Size(377, 48);
            cityBox.TabIndex = 5;
            cityBox.TabStop = false;
            cityBox.Text = "None provided.";
            cityBox.TextAlign = HorizontalAlignment.Left;
            cityBox.TrailingIcon = null;
            cityBox.UseSystemPasswordChar = false;
            cityBox.Click += textBox_Click;
            cityBox.Enter += textBox_Enter;
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
            materialLabel4.Size = new Size(42, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "State:";
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
            stateBox.Location = new Point(51, 165);
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
            stateBox.Size = new Size(367, 48);
            stateBox.TabIndex = 7;
            stateBox.TabStop = false;
            stateBox.Text = "None provided.";
            stateBox.TextAlign = HorizontalAlignment.Left;
            stateBox.TrailingIcon = null;
            stateBox.UseSystemPasswordChar = false;
            stateBox.Click += textBox_Click;
            stateBox.Enter += textBox_Enter;
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
            startDateBox.Size = new Size(333, 48);
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
            endDateBox.Size = new Size(333, 48);
            endDateBox.TabIndex = 11;
            endDateBox.TabStop = false;
            endDateBox.Text = "None provided.";
            endDateBox.TextAlign = HorizontalAlignment.Left;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
            endDateBox.Click += textBox_Click;
            endDateBox.Enter += textBox_Enter;
            // 
            // JobInfoViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(materialCard1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "JobInfoViewer";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Job Info";
            Load += JobInfoViewer_Load;
            Shown += JobInfoViewer_Shown;
            materialCard1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit jobTitleBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit employerBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cityBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit stateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit startDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialRichTextBox jobDescriptionBox;
    }
}