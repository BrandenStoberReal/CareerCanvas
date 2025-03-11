namespace CareerCanvas.Forms.Info
{
    partial class CertificateInfoViewer
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
            certificateNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            issuerBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            issueDateBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            programNameBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            materialCard1.Size = new Size(583, 371);
            materialCard1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(materialLabel1);
            flowLayoutPanel1.Controls.Add(certificateNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel2);
            flowLayoutPanel1.Controls.Add(issuerBox);
            flowLayoutPanel1.Controls.Add(materialLabel3);
            flowLayoutPanel1.Controls.Add(issueDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel4);
            flowLayoutPanel1.Controls.Add(programNameBox);
            flowLayoutPanel1.Controls.Add(materialLabel5);
            flowLayoutPanel1.Controls.Add(startDateBox);
            flowLayoutPanel1.Controls.Add(materialLabel6);
            flowLayoutPanel1.Controls.Add(endDateBox);
            flowLayoutPanel1.Location = new Point(17, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(549, 337);
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
            materialLabel1.Size = new Size(123, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Certificate Name:";
            // 
            // certificateNameBox
            // 
            certificateNameBox.AnimateReadOnly = false;
            certificateNameBox.AutoCompleteMode = AutoCompleteMode.None;
            certificateNameBox.AutoCompleteSource = AutoCompleteSource.None;
            certificateNameBox.BackgroundImageLayout = ImageLayout.None;
            certificateNameBox.CharacterCasing = CharacterCasing.Normal;
            certificateNameBox.Depth = 0;
            certificateNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            certificateNameBox.HideSelection = true;
            certificateNameBox.LeadingIcon = null;
            certificateNameBox.Location = new Point(132, 3);
            certificateNameBox.MaxLength = 32767;
            certificateNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            certificateNameBox.Name = "certificateNameBox";
            certificateNameBox.PasswordChar = '\0';
            certificateNameBox.PrefixSuffixText = null;
            certificateNameBox.ReadOnly = true;
            certificateNameBox.RightToLeft = RightToLeft.No;
            certificateNameBox.SelectedText = "";
            certificateNameBox.SelectionLength = 0;
            certificateNameBox.SelectionStart = 0;
            certificateNameBox.ShortcutsEnabled = true;
            certificateNameBox.Size = new Size(406, 48);
            certificateNameBox.TabIndex = 1;
            certificateNameBox.TabStop = false;
            certificateNameBox.Text = "None provided.";
            certificateNameBox.TextAlign = HorizontalAlignment.Left;
            certificateNameBox.TrailingIcon = null;
            certificateNameBox.UseSystemPasswordChar = false;
            certificateNameBox.Click += textBox_Click;
            certificateNameBox.Enter += textBox_Enter;
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
            materialLabel2.Size = new Size(151, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Issuing Organization:";
            // 
            // issuerBox
            // 
            issuerBox.AnimateReadOnly = false;
            issuerBox.AutoCompleteMode = AutoCompleteMode.None;
            issuerBox.AutoCompleteSource = AutoCompleteSource.None;
            issuerBox.BackgroundImageLayout = ImageLayout.None;
            issuerBox.CharacterCasing = CharacterCasing.Normal;
            issuerBox.Depth = 0;
            issuerBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issuerBox.HideSelection = true;
            issuerBox.LeadingIcon = null;
            issuerBox.Location = new Point(160, 57);
            issuerBox.MaxLength = 32767;
            issuerBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            issuerBox.Name = "issuerBox";
            issuerBox.PasswordChar = '\0';
            issuerBox.PrefixSuffixText = null;
            issuerBox.ReadOnly = true;
            issuerBox.RightToLeft = RightToLeft.No;
            issuerBox.SelectedText = "";
            issuerBox.SelectionLength = 0;
            issuerBox.SelectionStart = 0;
            issuerBox.ShortcutsEnabled = true;
            issuerBox.Size = new Size(378, 48);
            issuerBox.TabIndex = 3;
            issuerBox.TabStop = false;
            issuerBox.Text = "None provided.";
            issuerBox.TextAlign = HorizontalAlignment.Left;
            issuerBox.TrailingIcon = null;
            issuerBox.UseSystemPasswordChar = false;
            issuerBox.Click += textBox_Click;
            issuerBox.Enter += textBox_Enter;
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
            materialLabel3.Size = new Size(79, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Issue Date:";
            // 
            // issueDateBox
            // 
            issueDateBox.AnimateReadOnly = false;
            issueDateBox.AutoCompleteMode = AutoCompleteMode.None;
            issueDateBox.AutoCompleteSource = AutoCompleteSource.None;
            issueDateBox.BackgroundImageLayout = ImageLayout.None;
            issueDateBox.CharacterCasing = CharacterCasing.Normal;
            issueDateBox.Depth = 0;
            issueDateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issueDateBox.HideSelection = true;
            issueDateBox.LeadingIcon = null;
            issueDateBox.Location = new Point(88, 111);
            issueDateBox.MaxLength = 32767;
            issueDateBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            issueDateBox.Name = "issueDateBox";
            issueDateBox.PasswordChar = '\0';
            issueDateBox.PrefixSuffixText = null;
            issueDateBox.ReadOnly = true;
            issueDateBox.RightToLeft = RightToLeft.No;
            issueDateBox.SelectedText = "";
            issueDateBox.SelectionLength = 0;
            issueDateBox.SelectionStart = 0;
            issueDateBox.ShortcutsEnabled = true;
            issueDateBox.Size = new Size(450, 48);
            issueDateBox.TabIndex = 5;
            issueDateBox.TabStop = false;
            issueDateBox.Text = "None provided.";
            issueDateBox.TextAlign = HorizontalAlignment.Left;
            issueDateBox.TrailingIcon = null;
            issueDateBox.UseSystemPasswordChar = false;
            issueDateBox.Click += textBox_Click;
            issueDateBox.Enter += textBox_Enter;
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
            materialLabel4.Size = new Size(112, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Program Name:";
            // 
            // programNameBox
            // 
            programNameBox.AnimateReadOnly = false;
            programNameBox.AutoCompleteMode = AutoCompleteMode.None;
            programNameBox.AutoCompleteSource = AutoCompleteSource.None;
            programNameBox.BackgroundImageLayout = ImageLayout.None;
            programNameBox.CharacterCasing = CharacterCasing.Normal;
            programNameBox.Depth = 0;
            programNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            programNameBox.HideSelection = true;
            programNameBox.LeadingIcon = null;
            programNameBox.Location = new Point(121, 165);
            programNameBox.MaxLength = 32767;
            programNameBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            programNameBox.Name = "programNameBox";
            programNameBox.PasswordChar = '\0';
            programNameBox.PrefixSuffixText = null;
            programNameBox.ReadOnly = true;
            programNameBox.RightToLeft = RightToLeft.No;
            programNameBox.SelectedText = "";
            programNameBox.SelectionLength = 0;
            programNameBox.SelectionStart = 0;
            programNameBox.ShortcutsEnabled = true;
            programNameBox.Size = new Size(417, 48);
            programNameBox.TabIndex = 7;
            programNameBox.TabStop = false;
            programNameBox.Text = "None provided.";
            programNameBox.TextAlign = HorizontalAlignment.Left;
            programNameBox.TrailingIcon = null;
            programNameBox.UseSystemPasswordChar = false;
            programNameBox.Click += textBox_Click;
            programNameBox.Enter += textBox_Enter;
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
            startDateBox.Size = new Size(453, 48);
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
            endDateBox.Size = new Size(453, 48);
            endDateBox.TabIndex = 11;
            endDateBox.TabStop = false;
            endDateBox.Text = "None provided.";
            endDateBox.TextAlign = HorizontalAlignment.Left;
            endDateBox.TrailingIcon = null;
            endDateBox.UseSystemPasswordChar = false;
            endDateBox.Click += textBox_Click;
            endDateBox.Enter += textBox_Enter;
            // 
            // CertificateInfoViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 426);
            Controls.Add(materialCard1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "CertificateInfoViewer";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Certificate Info";
            Load += CertificateInfoViewer_Load;
            materialCard1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit certificateNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit issuerBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit issueDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit programNameBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit startDateBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endDateBox;
    }
}