namespace CareerCanvas
{
    partial class EntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            welcomePage = new TabPage();
            readMeView = new Microsoft.Web.WebView2.WinForms.WebView2();
            identityPage = new TabPage();
            identityConfigExpansionPanel = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            identityEncryptionPasswordLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identityShowPasswordCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            identityEncryptionPasswordBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            identityEncryptionCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            openIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            newIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            flowLayoutPanel1 = new FlowLayoutPanel();
            identitiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identitiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            historyPage = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            historiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            historiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            newHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            openHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            resumePage = new TabPage();
            recentResumesFlow = new FlowLayoutPanel();
            recentResumesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            recentResumesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            mainMenuButtonFlowPanel = new FlowLayoutPanel();
            newResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            loadResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            cvPage = new TabPage();
            creditsPage = new TabPage();
            identityRefreshTimer = new System.Windows.Forms.Timer(components);
            materialTabControl1.SuspendLayout();
            welcomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readMeView).BeginInit();
            identityPage.SuspendLayout();
            identityConfigExpansionPanel.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            historyPage.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            resumePage.SuspendLayout();
            recentResumesFlow.SuspendLayout();
            mainMenuButtonFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(welcomePage);
            materialTabControl1.Controls.Add(identityPage);
            materialTabControl1.Controls.Add(historyPage);
            materialTabControl1.Controls.Add(resumePage);
            materialTabControl1.Controls.Add(cvPage);
            materialTabControl1.Controls.Add(creditsPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(6, 67);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1282, 598);
            materialTabControl1.TabIndex = 0;
            // 
            // welcomePage
            // 
            welcomePage.Controls.Add(readMeView);
            welcomePage.Location = new Point(4, 24);
            welcomePage.Name = "welcomePage";
            welcomePage.Size = new Size(1274, 570);
            welcomePage.TabIndex = 2;
            welcomePage.Text = "Welcome";
            welcomePage.UseVisualStyleBackColor = true;
            // 
            // readMeView
            // 
            readMeView.AllowExternalDrop = true;
            readMeView.BackColor = SystemColors.Desktop;
            readMeView.CreationProperties = null;
            readMeView.DefaultBackgroundColor = Color.White;
            readMeView.Dock = DockStyle.Fill;
            readMeView.ForeColor = SystemColors.Control;
            readMeView.Location = new Point(0, 0);
            readMeView.Name = "readMeView";
            readMeView.Size = new Size(1274, 570);
            readMeView.TabIndex = 1;
            readMeView.ZoomFactor = 1D;
            // 
            // identityPage
            // 
            identityPage.Controls.Add(identityConfigExpansionPanel);
            identityPage.Controls.Add(materialCard2);
            identityPage.Controls.Add(materialCard1);
            identityPage.Location = new Point(4, 24);
            identityPage.Name = "identityPage";
            identityPage.Size = new Size(1274, 570);
            identityPage.TabIndex = 4;
            identityPage.Text = "Identities";
            identityPage.UseVisualStyleBackColor = true;
            identityPage.Click += identityPage_Click;
            // 
            // identityConfigExpansionPanel
            // 
            identityConfigExpansionPanel.BackColor = Color.FromArgb(255, 255, 255);
            identityConfigExpansionPanel.Controls.Add(identityEncryptionPasswordLabel);
            identityConfigExpansionPanel.Controls.Add(identityShowPasswordCheckbox);
            identityConfigExpansionPanel.Controls.Add(identityEncryptionPasswordBox);
            identityConfigExpansionPanel.Controls.Add(identityEncryptionCheckbox);
            identityConfigExpansionPanel.Depth = 0;
            identityConfigExpansionPanel.Description = "Settings related to how identities are stored and handled";
            identityConfigExpansionPanel.ExpandHeight = 542;
            identityConfigExpansionPanel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identityConfigExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            identityConfigExpansionPanel.Location = new Point(198, 14);
            identityConfigExpansionPanel.Margin = new Padding(16);
            identityConfigExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityConfigExpansionPanel.Name = "identityConfigExpansionPanel";
            identityConfigExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            identityConfigExpansionPanel.Size = new Size(663, 542);
            identityConfigExpansionPanel.TabIndex = 6;
            identityConfigExpansionPanel.Title = "Options";
            identityConfigExpansionPanel.SaveClick += identityConfigExpansionPanel_SaveClick;
            identityConfigExpansionPanel.Click += identityConfigExpansionPanel_Click;
            // 
            // identityEncryptionPasswordLabel
            // 
            identityEncryptionPasswordLabel.Depth = 0;
            identityEncryptionPasswordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identityEncryptionPasswordLabel.Location = new Point(24, 138);
            identityEncryptionPasswordLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityEncryptionPasswordLabel.Name = "identityEncryptionPasswordLabel";
            identityEncryptionPasswordLabel.Size = new Size(159, 48);
            identityEncryptionPasswordLabel.TabIndex = 5;
            identityEncryptionPasswordLabel.Text = "Encryption Password:";
            identityEncryptionPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // identityShowPasswordCheckbox
            // 
            identityShowPasswordCheckbox.AutoSize = true;
            identityShowPasswordCheckbox.Depth = 0;
            identityShowPasswordCheckbox.Enabled = false;
            identityShowPasswordCheckbox.Location = new Point(24, 101);
            identityShowPasswordCheckbox.Margin = new Padding(0);
            identityShowPasswordCheckbox.MouseLocation = new Point(-1, -1);
            identityShowPasswordCheckbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityShowPasswordCheckbox.Name = "identityShowPasswordCheckbox";
            identityShowPasswordCheckbox.ReadOnly = false;
            identityShowPasswordCheckbox.Ripple = true;
            identityShowPasswordCheckbox.Size = new Size(226, 37);
            identityShowPasswordCheckbox.TabIndex = 4;
            identityShowPasswordCheckbox.Text = "Show encryption password";
            identityShowPasswordCheckbox.UseAccentColor = false;
            identityShowPasswordCheckbox.UseVisualStyleBackColor = true;
            identityShowPasswordCheckbox.CheckedChanged += identityShowPasswordCheckbox_CheckedChanged;
            // 
            // identityEncryptionPasswordBox
            // 
            identityEncryptionPasswordBox.AnimateReadOnly = false;
            identityEncryptionPasswordBox.AutoCompleteMode = AutoCompleteMode.None;
            identityEncryptionPasswordBox.AutoCompleteSource = AutoCompleteSource.None;
            identityEncryptionPasswordBox.BackgroundImageLayout = ImageLayout.None;
            identityEncryptionPasswordBox.CharacterCasing = CharacterCasing.Normal;
            identityEncryptionPasswordBox.Depth = 0;
            identityEncryptionPasswordBox.Enabled = false;
            identityEncryptionPasswordBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            identityEncryptionPasswordBox.HideSelection = true;
            identityEncryptionPasswordBox.LeadingIcon = null;
            identityEncryptionPasswordBox.Location = new Point(189, 138);
            identityEncryptionPasswordBox.MaxLength = 32767;
            identityEncryptionPasswordBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            identityEncryptionPasswordBox.Name = "identityEncryptionPasswordBox";
            identityEncryptionPasswordBox.PasswordChar = '●';
            identityEncryptionPasswordBox.PrefixSuffixText = null;
            identityEncryptionPasswordBox.ReadOnly = false;
            identityEncryptionPasswordBox.RightToLeft = RightToLeft.No;
            identityEncryptionPasswordBox.SelectedText = "";
            identityEncryptionPasswordBox.SelectionLength = 0;
            identityEncryptionPasswordBox.SelectionStart = 0;
            identityEncryptionPasswordBox.ShortcutsEnabled = true;
            identityEncryptionPasswordBox.Size = new Size(250, 48);
            identityEncryptionPasswordBox.TabIndex = 3;
            identityEncryptionPasswordBox.TabStop = false;
            identityEncryptionPasswordBox.TextAlign = HorizontalAlignment.Left;
            identityEncryptionPasswordBox.TrailingIcon = null;
            identityEncryptionPasswordBox.UseSystemPasswordChar = true;
            identityEncryptionPasswordBox.TextChanged += identityEncryptionPasswordBox_TextChanged;
            // 
            // identityEncryptionCheckbox
            // 
            identityEncryptionCheckbox.AutoSize = true;
            identityEncryptionCheckbox.Depth = 0;
            identityEncryptionCheckbox.Location = new Point(24, 64);
            identityEncryptionCheckbox.Margin = new Padding(0);
            identityEncryptionCheckbox.MouseLocation = new Point(-1, -1);
            identityEncryptionCheckbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityEncryptionCheckbox.Name = "identityEncryptionCheckbox";
            identityEncryptionCheckbox.ReadOnly = false;
            identityEncryptionCheckbox.Ripple = true;
            identityEncryptionCheckbox.Size = new Size(139, 37);
            identityEncryptionCheckbox.TabIndex = 2;
            identityEncryptionCheckbox.Text = "Use encryption";
            identityEncryptionCheckbox.UseAccentColor = false;
            identityEncryptionCheckbox.UseVisualStyleBackColor = true;
            identityEncryptionCheckbox.CheckedChanged += identityEncryptionCheckbox_CheckedChanged;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(openIdentityButton);
            materialCard2.Controls.Add(newIdentityButton);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(167, 542);
            materialCard2.TabIndex = 5;
            // 
            // openIdentityButton
            // 
            openIdentityButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openIdentityButton.AutoSize = false;
            openIdentityButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openIdentityButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openIdentityButton.Depth = 0;
            openIdentityButton.HighEmphasis = true;
            openIdentityButton.Icon = null;
            openIdentityButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openIdentityButton.Location = new Point(10, 58);
            openIdentityButton.Margin = new Padding(6);
            openIdentityButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openIdentityButton.Name = "openIdentityButton";
            openIdentityButton.NoAccentTextColor = Color.Empty;
            openIdentityButton.Size = new Size(147, 36);
            openIdentityButton.TabIndex = 101;
            openIdentityButton.TabStop = false;
            openIdentityButton.Text = "Import Identity";
            openIdentityButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openIdentityButton.UseAccentColor = false;
            openIdentityButton.UseVisualStyleBackColor = true;
            openIdentityButton.Click += openIdentityButton_Click;
            // 
            // newIdentityButton
            // 
            newIdentityButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newIdentityButton.AutoSize = false;
            newIdentityButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newIdentityButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newIdentityButton.Depth = 0;
            newIdentityButton.HighEmphasis = true;
            newIdentityButton.Icon = null;
            newIdentityButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newIdentityButton.Location = new Point(10, 10);
            newIdentityButton.Margin = new Padding(6);
            newIdentityButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newIdentityButton.Name = "newIdentityButton";
            newIdentityButton.NoAccentTextColor = Color.Empty;
            newIdentityButton.Size = new Size(147, 36);
            newIdentityButton.TabIndex = 100;
            newIdentityButton.TabStop = false;
            newIdentityButton.Text = "New Identity";
            newIdentityButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newIdentityButton.UseAccentColor = false;
            newIdentityButton.UseVisualStyleBackColor = true;
            newIdentityButton.Click += newIdentityButton_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(flowLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(878, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(382, 542);
            materialCard1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(identitiesLabel);
            flowLayoutPanel1.Controls.Add(identitiesListBox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(17, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 508);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // identitiesLabel
            // 
            identitiesLabel.Anchor = AnchorStyles.Top;
            identitiesLabel.Depth = 0;
            identitiesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identitiesLabel.Location = new Point(3, 0);
            identitiesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identitiesLabel.Name = "identitiesLabel";
            identitiesLabel.Size = new Size(340, 23);
            identitiesLabel.TabIndex = 4;
            identitiesLabel.Text = "Identities";
            identitiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identitiesListBox
            // 
            identitiesListBox.BackColor = Color.White;
            identitiesListBox.BorderColor = Color.LightGray;
            identitiesListBox.Depth = 0;
            identitiesListBox.Dock = DockStyle.Bottom;
            identitiesListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            identitiesListBox.Location = new Point(6, 29);
            identitiesListBox.Margin = new Padding(6);
            identitiesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identitiesListBox.Name = "identitiesListBox";
            identitiesListBox.SelectedIndex = -1;
            identitiesListBox.SelectedItem = null;
            identitiesListBox.Size = new Size(334, 470);
            identitiesListBox.TabIndex = 200;
            identitiesListBox.TabStop = false;
            identitiesListBox.SelectedIndexChanged += identitiesListBox_SelectedIndexChanged;
            // 
            // historyPage
            // 
            historyPage.Controls.Add(flowLayoutPanel2);
            historyPage.Controls.Add(flowLayoutPanel3);
            historyPage.Location = new Point(4, 24);
            historyPage.Name = "historyPage";
            historyPage.Size = new Size(1274, 570);
            historyPage.TabIndex = 5;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(historiesLabel);
            flowLayoutPanel2.Controls.Add(historiesListBox);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(924, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(350, 570);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // historiesLabel
            // 
            historiesLabel.Anchor = AnchorStyles.Top;
            historiesLabel.Depth = 0;
            historiesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            historiesLabel.Location = new Point(3, 0);
            historiesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            historiesLabel.Name = "historiesLabel";
            historiesLabel.Size = new Size(340, 23);
            historiesLabel.TabIndex = 4;
            historiesLabel.Text = "Histories";
            historiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historiesListBox
            // 
            historiesListBox.BackColor = Color.White;
            historiesListBox.BorderColor = Color.LightGray;
            historiesListBox.Depth = 0;
            historiesListBox.Dock = DockStyle.Bottom;
            historiesListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            historiesListBox.Location = new Point(6, 29);
            historiesListBox.Margin = new Padding(6);
            historiesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            historiesListBox.Name = "historiesListBox";
            historiesListBox.SelectedIndex = -1;
            historiesListBox.SelectedItem = null;
            historiesListBox.Size = new Size(334, 535);
            historiesListBox.TabIndex = 200;
            historiesListBox.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(newHistoryButton);
            flowLayoutPanel3.Controls.Add(openHistoryButton);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(158, 570);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // newHistoryButton
            // 
            newHistoryButton.Anchor = AnchorStyles.None;
            newHistoryButton.AutoSize = false;
            newHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newHistoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newHistoryButton.Depth = 0;
            newHistoryButton.HighEmphasis = true;
            newHistoryButton.Icon = null;
            newHistoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newHistoryButton.Location = new Point(6, 6);
            newHistoryButton.Margin = new Padding(6);
            newHistoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newHistoryButton.Name = "newHistoryButton";
            newHistoryButton.NoAccentTextColor = Color.Empty;
            newHistoryButton.Size = new Size(136, 36);
            newHistoryButton.TabIndex = 100;
            newHistoryButton.TabStop = false;
            newHistoryButton.Text = "New History";
            newHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newHistoryButton.UseAccentColor = false;
            newHistoryButton.UseVisualStyleBackColor = true;
            // 
            // openHistoryButton
            // 
            openHistoryButton.Anchor = AnchorStyles.None;
            openHistoryButton.AutoSize = false;
            openHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openHistoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openHistoryButton.Depth = 0;
            openHistoryButton.HighEmphasis = true;
            openHistoryButton.Icon = null;
            openHistoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openHistoryButton.Location = new Point(6, 54);
            openHistoryButton.Margin = new Padding(6);
            openHistoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openHistoryButton.Name = "openHistoryButton";
            openHistoryButton.NoAccentTextColor = Color.Empty;
            openHistoryButton.Size = new Size(136, 36);
            openHistoryButton.TabIndex = 101;
            openHistoryButton.TabStop = false;
            openHistoryButton.Text = "Open History";
            openHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openHistoryButton.UseAccentColor = false;
            openHistoryButton.UseVisualStyleBackColor = true;
            // 
            // resumePage
            // 
            resumePage.Controls.Add(recentResumesFlow);
            resumePage.Controls.Add(mainMenuButtonFlowPanel);
            resumePage.Location = new Point(4, 24);
            resumePage.Name = "resumePage";
            resumePage.Size = new Size(1274, 570);
            resumePage.TabIndex = 0;
            resumePage.Text = "Resume";
            resumePage.UseVisualStyleBackColor = true;
            // 
            // recentResumesFlow
            // 
            recentResumesFlow.Controls.Add(recentResumesLabel);
            recentResumesFlow.Controls.Add(recentResumesListBox);
            recentResumesFlow.Dock = DockStyle.Right;
            recentResumesFlow.FlowDirection = FlowDirection.TopDown;
            recentResumesFlow.Location = new Point(928, 0);
            recentResumesFlow.Name = "recentResumesFlow";
            recentResumesFlow.Size = new Size(346, 570);
            recentResumesFlow.TabIndex = 2;
            // 
            // recentResumesLabel
            // 
            recentResumesLabel.Anchor = AnchorStyles.Top;
            recentResumesLabel.Depth = 0;
            recentResumesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentResumesLabel.Location = new Point(3, 0);
            recentResumesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            recentResumesLabel.Name = "recentResumesLabel";
            recentResumesLabel.Size = new Size(340, 23);
            recentResumesLabel.TabIndex = 0;
            recentResumesLabel.Text = "Recent Resumes";
            recentResumesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recentResumesListBox
            // 
            recentResumesListBox.BackColor = Color.White;
            recentResumesListBox.BorderColor = Color.LightGray;
            recentResumesListBox.Depth = 0;
            recentResumesListBox.Dock = DockStyle.Bottom;
            recentResumesListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            recentResumesListBox.Location = new Point(6, 29);
            recentResumesListBox.Margin = new Padding(6);
            recentResumesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            recentResumesListBox.Name = "recentResumesListBox";
            recentResumesListBox.SelectedIndex = -1;
            recentResumesListBox.SelectedItem = null;
            recentResumesListBox.Size = new Size(334, 534);
            recentResumesListBox.TabIndex = 1;
            // 
            // mainMenuButtonFlowPanel
            // 
            mainMenuButtonFlowPanel.Controls.Add(newResumeButton);
            mainMenuButtonFlowPanel.Controls.Add(loadResumeButton);
            mainMenuButtonFlowPanel.Dock = DockStyle.Left;
            mainMenuButtonFlowPanel.FlowDirection = FlowDirection.TopDown;
            mainMenuButtonFlowPanel.Location = new Point(0, 0);
            mainMenuButtonFlowPanel.Name = "mainMenuButtonFlowPanel";
            mainMenuButtonFlowPanel.Size = new Size(181, 570);
            mainMenuButtonFlowPanel.TabIndex = 1;
            // 
            // newResumeButton
            // 
            newResumeButton.Anchor = AnchorStyles.None;
            newResumeButton.AutoSize = false;
            newResumeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newResumeButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newResumeButton.Depth = 0;
            newResumeButton.HighEmphasis = true;
            newResumeButton.Icon = null;
            newResumeButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newResumeButton.Location = new Point(6, 6);
            newResumeButton.Margin = new Padding(6);
            newResumeButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newResumeButton.Name = "newResumeButton";
            newResumeButton.NoAccentTextColor = Color.Empty;
            newResumeButton.Size = new Size(136, 36);
            newResumeButton.TabIndex = 0;
            newResumeButton.Text = "New Resume";
            newResumeButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newResumeButton.UseAccentColor = false;
            newResumeButton.UseVisualStyleBackColor = true;
            // 
            // loadResumeButton
            // 
            loadResumeButton.Anchor = AnchorStyles.None;
            loadResumeButton.AutoSize = false;
            loadResumeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadResumeButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadResumeButton.Depth = 0;
            loadResumeButton.HighEmphasis = true;
            loadResumeButton.Icon = null;
            loadResumeButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loadResumeButton.Location = new Point(6, 54);
            loadResumeButton.Margin = new Padding(6);
            loadResumeButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loadResumeButton.Name = "loadResumeButton";
            loadResumeButton.NoAccentTextColor = Color.Empty;
            loadResumeButton.Size = new Size(136, 36);
            loadResumeButton.TabIndex = 1;
            loadResumeButton.Text = "Load Resume";
            loadResumeButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loadResumeButton.UseAccentColor = false;
            loadResumeButton.UseVisualStyleBackColor = true;
            // 
            // cvPage
            // 
            cvPage.Location = new Point(4, 24);
            cvPage.Name = "cvPage";
            cvPage.Size = new Size(1274, 570);
            cvPage.TabIndex = 3;
            cvPage.Text = "Cover Letter";
            cvPage.UseVisualStyleBackColor = true;
            // 
            // creditsPage
            // 
            creditsPage.Location = new Point(4, 24);
            creditsPage.Name = "creditsPage";
            creditsPage.Size = new Size(1274, 570);
            creditsPage.TabIndex = 1;
            creditsPage.Text = "Credits";
            creditsPage.UseVisualStyleBackColor = true;
            // 
            // identityRefreshTimer
            // 
            identityRefreshTimer.Enabled = true;
            identityRefreshTimer.Interval = 1000;
            identityRefreshTimer.Tick += identityRefreshTimer_Tick;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 671);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "EntryForm";
            Sizable = false;
            Text = "Career Canvas";
            FormClosing += EntryForm_FormClosing;
            Load += EntryForm_Load;
            materialTabControl1.ResumeLayout(false);
            welcomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readMeView).EndInit();
            identityPage.ResumeLayout(false);
            identityConfigExpansionPanel.ResumeLayout(false);
            identityConfigExpansionPanel.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            historyPage.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            resumePage.ResumeLayout(false);
            recentResumesFlow.ResumeLayout(false);
            mainMenuButtonFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage resumePage;
        private TabPage creditsPage;
        private FlowLayoutPanel mainMenuButtonFlowPanel;
        private ReaLTaiizor.Controls.MaterialButton newResumeButton;
        private ReaLTaiizor.Controls.MaterialButton loadResumeButton;
        private TabPage welcomePage;
        private TabPage cvPage;
        private TabPage identityPage;
        private Microsoft.Web.WebView2.WinForms.WebView2 readMeView;
        private ReaLTaiizor.Controls.MaterialButton newIdentityButton;
        private ReaLTaiizor.Controls.MaterialListBox identitiesListBox;
        private FlowLayoutPanel recentResumesFlow;
        private ReaLTaiizor.Controls.MaterialLabel recentResumesLabel;
        private ReaLTaiizor.Controls.MaterialListBox recentResumesListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel identitiesLabel;
        private ReaLTaiizor.Controls.MaterialButton openIdentityButton;
        private TabPage historyPage;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialLabel historiesLabel;
        private ReaLTaiizor.Controls.MaterialListBox historiesListBox;
        private FlowLayoutPanel flowLayoutPanel3;
        private ReaLTaiizor.Controls.MaterialButton newHistoryButton;
        private ReaLTaiizor.Controls.MaterialButton openHistoryButton;
        private System.Windows.Forms.Timer identityRefreshTimer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialExpansionPanel identityConfigExpansionPanel;
        private ReaLTaiizor.Controls.MaterialCheckBox identityEncryptionCheckbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit identityEncryptionPasswordBox;
        private ReaLTaiizor.Controls.MaterialCheckBox identityShowPasswordCheckbox;
        private ReaLTaiizor.Controls.MaterialLabel identityEncryptionPasswordLabel;
    }
}
