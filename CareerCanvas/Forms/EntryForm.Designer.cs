namespace CareerCanvas.Forms
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
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            entryTitleLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identityPage = new TabPage();
            identityConfigExpansionPanel = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            identityEncryptionCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            openIdentityFolderButton = new ReaLTaiizor.Controls.MaterialButton();
            openIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            newIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            identitiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identitiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            industryPage = new TabPage();
            materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            newHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            openIndustryFolderButton = new ReaLTaiizor.Controls.MaterialButton();
            importHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            historiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            historiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            resumePage = new TabPage();
            materialCard5 = new ReaLTaiizor.Controls.MaterialCard();
            openResumeWorkspaceButton = new ReaLTaiizor.Controls.MaterialButton();
            cvPage = new TabPage();
            creditsPage = new TabPage();
            creditsFlowPanel = new FlowLayoutPanel();
            peopleCreditTitleLabel = new ReaLTaiizor.Controls.MaterialLabel();
            brandenCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            libraryCreditsFlowPanel = new FlowLayoutPanel();
            librariesCreditTitleLabel = new ReaLTaiizor.Controls.MaterialLabel();
            googleCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            newtonsoftCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            microsoftCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            asposeCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            alexanderCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            taiizorCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            serilogCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            hapCreditLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identityRefreshTimer = new System.Windows.Forms.Timer(components);
            historyRefreshTimer = new System.Windows.Forms.Timer(components);
            tabPage1 = new TabPage();
            materialTabControl1.SuspendLayout();
            welcomePage.SuspendLayout();
            identityPage.SuspendLayout();
            identityConfigExpansionPanel.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            industryPage.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            resumePage.SuspendLayout();
            materialCard5.SuspendLayout();
            creditsPage.SuspendLayout();
            creditsFlowPanel.SuspendLayout();
            libraryCreditsFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(welcomePage);
            materialTabControl1.Controls.Add(identityPage);
            materialTabControl1.Controls.Add(industryPage);
            materialTabControl1.Controls.Add(resumePage);
            materialTabControl1.Controls.Add(cvPage);
            materialTabControl1.Controls.Add(creditsPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Right;
            materialTabControl1.HotTrack = true;
            materialTabControl1.Location = new Point(206, 24);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1085, 644);
            materialTabControl1.TabIndex = 0;
            // 
            // welcomePage
            // 
            welcomePage.Controls.Add(materialLabel2);
            welcomePage.Controls.Add(entryTitleLabel);
            welcomePage.Location = new Point(4, 24);
            welcomePage.Name = "welcomePage";
            welcomePage.Size = new Size(1077, 616);
            welcomePage.TabIndex = 2;
            welcomePage.Text = "Welcome";
            welcomePage.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(3, 46);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(1071, 23);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Looking to get started? Check out the identities page and go down the list!";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entryTitleLabel
            // 
            entryTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            entryTitleLabel.Depth = 0;
            entryTitleLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            entryTitleLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            entryTitleLabel.Location = new Point(3, 0);
            entryTitleLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            entryTitleLabel.Name = "entryTitleLabel";
            entryTitleLabel.Size = new Size(1071, 46);
            entryTitleLabel.TabIndex = 0;
            entryTitleLabel.Text = "Welcome!";
            entryTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identityPage
            // 
            identityPage.Controls.Add(identityConfigExpansionPanel);
            identityPage.Controls.Add(materialCard2);
            identityPage.Controls.Add(materialCard1);
            identityPage.Location = new Point(4, 24);
            identityPage.Name = "identityPage";
            identityPage.Size = new Size(1077, 616);
            identityPage.TabIndex = 4;
            identityPage.Text = "Identities";
            identityPage.UseVisualStyleBackColor = true;
            identityPage.Click += identityPage_Click;
            // 
            // identityConfigExpansionPanel
            // 
            identityConfigExpansionPanel.BackColor = Color.FromArgb(255, 255, 255);
            identityConfigExpansionPanel.Collapse = true;
            identityConfigExpansionPanel.Controls.Add(identityEncryptionCheckbox);
            identityConfigExpansionPanel.Depth = 0;
            identityConfigExpansionPanel.Description = "Settings related to how identities are stored and handled";
            identityConfigExpansionPanel.ExpandHeight = 542;
            identityConfigExpansionPanel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identityConfigExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            identityConfigExpansionPanel.Location = new Point(198, 14);
            identityConfigExpansionPanel.Margin = new Padding(16, 1, 16, 0);
            identityConfigExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityConfigExpansionPanel.Name = "identityConfigExpansionPanel";
            identityConfigExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            identityConfigExpansionPanel.Size = new Size(457, 48);
            identityConfigExpansionPanel.TabIndex = 6;
            identityConfigExpansionPanel.Title = "Options";
            identityConfigExpansionPanel.SaveClick += identityConfigExpansionPanel_SaveClick;
            identityConfigExpansionPanel.Click += identityConfigExpansionPanel_Click;
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
            identityEncryptionCheckbox.Size = new Size(388, 37);
            identityEncryptionCheckbox.TabIndex = 2;
            identityEncryptionCheckbox.Text = "Use encryption (experimental) (not recommended)";
            identityEncryptionCheckbox.UseAccentColor = false;
            identityEncryptionCheckbox.UseVisualStyleBackColor = true;
            identityEncryptionCheckbox.CheckedChanged += identityEncryptionCheckbox_CheckedChanged;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(openIdentityFolderButton);
            materialCard2.Controls.Add(openIdentityButton);
            materialCard2.Controls.Add(newIdentityButton);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(167, 588);
            materialCard2.TabIndex = 5;
            // 
            // openIdentityFolderButton
            // 
            openIdentityFolderButton.AutoSize = false;
            openIdentityFolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openIdentityFolderButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openIdentityFolderButton.Depth = 0;
            openIdentityFolderButton.HighEmphasis = true;
            openIdentityFolderButton.Icon = null;
            openIdentityFolderButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openIdentityFolderButton.Location = new Point(10, 106);
            openIdentityFolderButton.Margin = new Padding(4, 6, 4, 6);
            openIdentityFolderButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openIdentityFolderButton.Name = "openIdentityFolderButton";
            openIdentityFolderButton.NoAccentTextColor = Color.Empty;
            openIdentityFolderButton.Size = new Size(147, 36);
            openIdentityFolderButton.TabIndex = 102;
            openIdentityFolderButton.Text = "Open Folder";
            openIdentityFolderButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openIdentityFolderButton.UseAccentColor = false;
            openIdentityFolderButton.UseVisualStyleBackColor = true;
            openIdentityFolderButton.Click += openIdentityFolderButton_Click;
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
            materialCard1.Controls.Add(identitiesLabel);
            materialCard1.Controls.Add(identitiesListBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(685, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(382, 588);
            materialCard1.TabIndex = 4;
            // 
            // identitiesLabel
            // 
            identitiesLabel.Anchor = AnchorStyles.Top;
            identitiesLabel.Depth = 0;
            identitiesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identitiesLabel.Location = new Point(20, 14);
            identitiesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identitiesLabel.Name = "identitiesLabel";
            identitiesLabel.Size = new Size(342, 23);
            identitiesLabel.TabIndex = 4;
            identitiesLabel.Text = "Identities";
            identitiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identitiesListBox
            // 
            identitiesListBox.BackColor = Color.White;
            identitiesListBox.BorderColor = Color.LightGray;
            identitiesListBox.Depth = 0;
            identitiesListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            identitiesListBox.Location = new Point(20, 43);
            identitiesListBox.Margin = new Padding(6);
            identitiesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identitiesListBox.Name = "identitiesListBox";
            identitiesListBox.SelectedIndex = -1;
            identitiesListBox.SelectedItem = null;
            identitiesListBox.Size = new Size(342, 525);
            identitiesListBox.TabIndex = 200;
            identitiesListBox.TabStop = false;
            identitiesListBox.SelectedIndexChanged += identitiesListBox_SelectedIndexChanged;
            // 
            // industryPage
            // 
            industryPage.Controls.Add(materialCard4);
            industryPage.Controls.Add(materialCard3);
            industryPage.Location = new Point(4, 24);
            industryPage.Name = "industryPage";
            industryPage.Size = new Size(1077, 616);
            industryPage.TabIndex = 5;
            industryPage.Text = "Industries";
            industryPage.UseVisualStyleBackColor = true;
            industryPage.Click += industryPage_Click;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(newHistoryButton);
            materialCard4.Controls.Add(openIndustryFolderButton);
            materialCard4.Controls.Add(importHistoryButton);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(14, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(176, 588);
            materialCard4.TabIndex = 103;
            // 
            // newHistoryButton
            // 
            newHistoryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            newHistoryButton.AutoSize = false;
            newHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newHistoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newHistoryButton.Depth = 0;
            newHistoryButton.HighEmphasis = true;
            newHistoryButton.Icon = null;
            newHistoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newHistoryButton.Location = new Point(10, 7);
            newHistoryButton.Margin = new Padding(6);
            newHistoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newHistoryButton.Name = "newHistoryButton";
            newHistoryButton.NoAccentTextColor = Color.Empty;
            newHistoryButton.Size = new Size(153, 36);
            newHistoryButton.TabIndex = 100;
            newHistoryButton.TabStop = false;
            newHistoryButton.Text = "New Industry";
            newHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newHistoryButton.UseAccentColor = false;
            newHistoryButton.UseVisualStyleBackColor = true;
            newHistoryButton.Click += newHistoryButton_Click;
            // 
            // openIndustryFolderButton
            // 
            openIndustryFolderButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            openIndustryFolderButton.AutoSize = false;
            openIndustryFolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openIndustryFolderButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openIndustryFolderButton.Depth = 0;
            openIndustryFolderButton.HighEmphasis = true;
            openIndustryFolderButton.Icon = null;
            openIndustryFolderButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openIndustryFolderButton.Location = new Point(10, 103);
            openIndustryFolderButton.Margin = new Padding(6);
            openIndustryFolderButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openIndustryFolderButton.Name = "openIndustryFolderButton";
            openIndustryFolderButton.NoAccentTextColor = Color.Empty;
            openIndustryFolderButton.Size = new Size(153, 36);
            openIndustryFolderButton.TabIndex = 102;
            openIndustryFolderButton.TabStop = false;
            openIndustryFolderButton.Text = "Open Folder";
            openIndustryFolderButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openIndustryFolderButton.UseAccentColor = false;
            openIndustryFolderButton.UseVisualStyleBackColor = true;
            openIndustryFolderButton.Click += openIndustryFolderButton_Click;
            // 
            // importHistoryButton
            // 
            importHistoryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            importHistoryButton.AutoSize = false;
            importHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            importHistoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            importHistoryButton.Depth = 0;
            importHistoryButton.HighEmphasis = true;
            importHistoryButton.Icon = null;
            importHistoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            importHistoryButton.Location = new Point(10, 55);
            importHistoryButton.Margin = new Padding(6);
            importHistoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            importHistoryButton.Name = "importHistoryButton";
            importHistoryButton.NoAccentTextColor = Color.Empty;
            importHistoryButton.Size = new Size(153, 36);
            importHistoryButton.TabIndex = 101;
            importHistoryButton.TabStop = false;
            importHistoryButton.Text = "Import Industry";
            importHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            importHistoryButton.UseAccentColor = false;
            importHistoryButton.UseVisualStyleBackColor = true;
            importHistoryButton.Click += importHistoryButton_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(historiesListBox);
            materialCard3.Controls.Add(historiesLabel);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(638, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(425, 588);
            materialCard3.TabIndex = 6;
            // 
            // historiesListBox
            // 
            historiesListBox.BackColor = Color.White;
            historiesListBox.BorderColor = Color.LightGray;
            historiesListBox.Depth = 0;
            historiesListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            historiesListBox.Location = new Point(17, 40);
            historiesListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            historiesListBox.Name = "historiesListBox";
            historiesListBox.SelectedIndex = -1;
            historiesListBox.SelectedItem = null;
            historiesListBox.Size = new Size(391, 531);
            historiesListBox.TabIndex = 5;
            historiesListBox.SelectedIndexChanged += historiesListBox_SelectedIndexChanged;
            // 
            // historiesLabel
            // 
            historiesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            historiesLabel.Depth = 0;
            historiesLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            historiesLabel.Location = new Point(17, 14);
            historiesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            historiesLabel.Name = "historiesLabel";
            historiesLabel.Size = new Size(391, 23);
            historiesLabel.TabIndex = 4;
            historiesLabel.Text = "Industries";
            historiesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resumePage
            // 
            resumePage.Controls.Add(materialCard5);
            resumePage.Location = new Point(4, 24);
            resumePage.Name = "resumePage";
            resumePage.Size = new Size(1077, 616);
            resumePage.TabIndex = 0;
            resumePage.Text = "Resume";
            resumePage.UseVisualStyleBackColor = true;
            resumePage.Click += resumePage_Click;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(openResumeWorkspaceButton);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(14, 14);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(211, 588);
            materialCard5.TabIndex = 0;
            materialCard5.Click += materialCard5_Click;
            // 
            // openResumeWorkspaceButton
            // 
            openResumeWorkspaceButton.AutoSize = false;
            openResumeWorkspaceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openResumeWorkspaceButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openResumeWorkspaceButton.Depth = 0;
            openResumeWorkspaceButton.HighEmphasis = true;
            openResumeWorkspaceButton.Icon = null;
            openResumeWorkspaceButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openResumeWorkspaceButton.Location = new Point(18, 20);
            openResumeWorkspaceButton.Margin = new Padding(4, 6, 4, 6);
            openResumeWorkspaceButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openResumeWorkspaceButton.Name = "openResumeWorkspaceButton";
            openResumeWorkspaceButton.NoAccentTextColor = Color.Empty;
            openResumeWorkspaceButton.Size = new Size(175, 36);
            openResumeWorkspaceButton.TabIndex = 0;
            openResumeWorkspaceButton.Text = "Open Resume Builder";
            openResumeWorkspaceButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openResumeWorkspaceButton.UseAccentColor = false;
            openResumeWorkspaceButton.UseVisualStyleBackColor = true;
            openResumeWorkspaceButton.Click += openResumeWorkspaceButton_Click;
            // 
            // cvPage
            // 
            cvPage.Location = new Point(4, 24);
            cvPage.Name = "cvPage";
            cvPage.Size = new Size(1077, 616);
            cvPage.TabIndex = 3;
            cvPage.Text = "Cover Letter";
            cvPage.UseVisualStyleBackColor = true;
            // 
            // creditsPage
            // 
            creditsPage.Controls.Add(creditsFlowPanel);
            creditsPage.Controls.Add(libraryCreditsFlowPanel);
            creditsPage.Location = new Point(4, 24);
            creditsPage.Name = "creditsPage";
            creditsPage.Size = new Size(1077, 616);
            creditsPage.TabIndex = 1;
            creditsPage.Text = "Credits";
            creditsPage.UseVisualStyleBackColor = true;
            // 
            // creditsFlowPanel
            // 
            creditsFlowPanel.Controls.Add(peopleCreditTitleLabel);
            creditsFlowPanel.Controls.Add(brandenCreditLabel);
            creditsFlowPanel.Dock = DockStyle.Left;
            creditsFlowPanel.FlowDirection = FlowDirection.TopDown;
            creditsFlowPanel.Location = new Point(0, 0);
            creditsFlowPanel.Name = "creditsFlowPanel";
            creditsFlowPanel.Size = new Size(261, 616);
            creditsFlowPanel.TabIndex = 0;
            // 
            // peopleCreditTitleLabel
            // 
            peopleCreditTitleLabel.Anchor = AnchorStyles.Top;
            peopleCreditTitleLabel.AutoSize = true;
            peopleCreditTitleLabel.Depth = 0;
            peopleCreditTitleLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            peopleCreditTitleLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            peopleCreditTitleLabel.Location = new Point(78, 0);
            peopleCreditTitleLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            peopleCreditTitleLabel.Name = "peopleCreditTitleLabel";
            peopleCreditTitleLabel.Size = new Size(91, 24);
            peopleCreditTitleLabel.TabIndex = 8;
            peopleCreditTitleLabel.Text = "Dev Team";
            // 
            // brandenCreditLabel
            // 
            brandenCreditLabel.Anchor = AnchorStyles.Top;
            brandenCreditLabel.AutoSize = true;
            brandenCreditLabel.Depth = 0;
            brandenCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            brandenCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            brandenCreditLabel.Location = new Point(3, 24);
            brandenCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            brandenCreditLabel.Name = "brandenCreditLabel";
            brandenCreditLabel.Size = new Size(241, 17);
            brandenCreditLabel.TabIndex = 0;
            brandenCreditLabel.Text = "Branden Stober - UI and Programming";
            // 
            // libraryCreditsFlowPanel
            // 
            libraryCreditsFlowPanel.Controls.Add(librariesCreditTitleLabel);
            libraryCreditsFlowPanel.Controls.Add(googleCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(newtonsoftCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(microsoftCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(asposeCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(alexanderCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(taiizorCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(serilogCreditLabel);
            libraryCreditsFlowPanel.Controls.Add(hapCreditLabel);
            libraryCreditsFlowPanel.Dock = DockStyle.Right;
            libraryCreditsFlowPanel.FlowDirection = FlowDirection.TopDown;
            libraryCreditsFlowPanel.Location = new Point(716, 0);
            libraryCreditsFlowPanel.Name = "libraryCreditsFlowPanel";
            libraryCreditsFlowPanel.Size = new Size(361, 616);
            libraryCreditsFlowPanel.TabIndex = 4;
            // 
            // librariesCreditTitleLabel
            // 
            librariesCreditTitleLabel.Anchor = AnchorStyles.Top;
            librariesCreditTitleLabel.AutoSize = true;
            librariesCreditTitleLabel.Depth = 0;
            librariesCreditTitleLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            librariesCreditTitleLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            librariesCreditTitleLabel.Location = new Point(139, 0);
            librariesCreditTitleLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            librariesCreditTitleLabel.Name = "librariesCreditTitleLabel";
            librariesCreditTitleLabel.Size = new Size(79, 24);
            librariesCreditTitleLabel.TabIndex = 7;
            librariesCreditTitleLabel.Text = "Libraries";
            // 
            // googleCreditLabel
            // 
            googleCreditLabel.Anchor = AnchorStyles.Top;
            googleCreditLabel.AutoSize = true;
            googleCreditLabel.Depth = 0;
            googleCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            googleCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            googleCreditLabel.Location = new Point(100, 24);
            googleCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            googleCreditLabel.Name = "googleCreditLabel";
            googleCreditLabel.Size = new Size(158, 17);
            googleCreditLabel.TabIndex = 1;
            googleCreditLabel.Text = "Google - Protobuf library";
            // 
            // newtonsoftCreditLabel
            // 
            newtonsoftCreditLabel.Anchor = AnchorStyles.Top;
            newtonsoftCreditLabel.AutoSize = true;
            newtonsoftCreditLabel.Depth = 0;
            newtonsoftCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            newtonsoftCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            newtonsoftCreditLabel.Location = new Point(96, 41);
            newtonsoftCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newtonsoftCreditLabel.Name = "newtonsoftCreditLabel";
            newtonsoftCreditLabel.Size = new Size(166, 17);
            newtonsoftCreditLabel.TabIndex = 2;
            newtonsoftCreditLabel.Text = "Newtonsoft - JSON library";
            // 
            // microsoftCreditLabel
            // 
            microsoftCreditLabel.Anchor = AnchorStyles.Top;
            microsoftCreditLabel.AutoSize = true;
            microsoftCreditLabel.Depth = 0;
            microsoftCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            microsoftCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            microsoftCreditLabel.Location = new Point(3, 58);
            microsoftCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            microsoftCreditLabel.Name = "microsoftCreditLabel";
            microsoftCreditLabel.Size = new Size(352, 17);
            microsoftCreditLabel.TabIndex = 3;
            microsoftCreditLabel.Text = "Microsoft - WinForms, DotNet, and WebView2 Runtimes";
            // 
            // asposeCreditLabel
            // 
            asposeCreditLabel.Anchor = AnchorStyles.Top;
            asposeCreditLabel.AutoSize = true;
            asposeCreditLabel.Depth = 0;
            asposeCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            asposeCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            asposeCreditLabel.Location = new Point(74, 75);
            asposeCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            asposeCreditLabel.Name = "asposeCreditLabel";
            asposeCreditLabel.Size = new Size(210, 17);
            asposeCreditLabel.TabIndex = 4;
            asposeCreditLabel.Text = "Aspose - HTML and PDF libraries";
            // 
            // alexanderCreditLabel
            // 
            alexanderCreditLabel.Anchor = AnchorStyles.Top;
            alexanderCreditLabel.AutoSize = true;
            alexanderCreditLabel.Depth = 0;
            alexanderCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            alexanderCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            alexanderCreditLabel.Location = new Point(72, 92);
            alexanderCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            alexanderCreditLabel.Name = "alexanderCreditLabel";
            alexanderCreditLabel.Size = new Size(213, 17);
            alexanderCreditLabel.TabIndex = 5;
            alexanderCreditLabel.Text = "Alexandre Mutel - Markdig library";
            // 
            // taiizorCreditLabel
            // 
            taiizorCreditLabel.Anchor = AnchorStyles.Top;
            taiizorCreditLabel.AutoSize = true;
            taiizorCreditLabel.Depth = 0;
            taiizorCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            taiizorCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            taiizorCreditLabel.Location = new Point(88, 109);
            taiizorCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            taiizorCreditLabel.Name = "taiizorCreditLabel";
            taiizorCreditLabel.Size = new Size(182, 17);
            taiizorCreditLabel.TabIndex = 6;
            taiizorCreditLabel.Text = "Taiizor - Material UI controls";
            // 
            // serilogCreditLabel
            // 
            serilogCreditLabel.Anchor = AnchorStyles.Top;
            serilogCreditLabel.AutoSize = true;
            serilogCreditLabel.Depth = 0;
            serilogCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            serilogCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            serilogCreditLabel.Location = new Point(87, 126);
            serilogCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            serilogCreditLabel.Name = "serilogCreditLabel";
            serilogCreditLabel.Size = new Size(183, 17);
            serilogCreditLabel.TabIndex = 8;
            serilogCreditLabel.Text = "Serilog - Logging Framework";
            // 
            // hapCreditLabel
            // 
            hapCreditLabel.Anchor = AnchorStyles.Top;
            hapCreditLabel.AutoSize = true;
            hapCreditLabel.Depth = 0;
            hapCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            hapCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            hapCreditLabel.Location = new Point(84, 143);
            hapCreditLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            hapCreditLabel.Name = "hapCreditLabel";
            hapCreditLabel.Size = new Size(189, 17);
            hapCreditLabel.TabIndex = 9;
            hapCreditLabel.Text = "Zzzprojects - HtmlAgilityPack";
            // 
            // identityRefreshTimer
            // 
            identityRefreshTimer.Enabled = true;
            identityRefreshTimer.Interval = 1000;
            identityRefreshTimer.Tick += identityRefreshTimer_Tick;
            // 
            // historyRefreshTimer
            // 
            historyRefreshTimer.Enabled = true;
            historyRefreshTimer.Interval = 1000;
            historyRefreshTimer.Tick += historyRefreshTimer_Tick;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Test";
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 671);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerHamburgerCursor = Cursors.No;
            DrawerIsOpen = true;
            DrawerNonClickTabPage = new TabPage[]
    {
    tabPage1
    };
            DrawerTabControl = materialTabControl1;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "EntryForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Career Canvas";
            FormClosing += EntryForm_FormClosing;
            Load += EntryForm_Load;
            materialTabControl1.ResumeLayout(false);
            welcomePage.ResumeLayout(false);
            identityPage.ResumeLayout(false);
            identityConfigExpansionPanel.ResumeLayout(false);
            identityConfigExpansionPanel.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            industryPage.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            resumePage.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            creditsPage.ResumeLayout(false);
            creditsFlowPanel.ResumeLayout(false);
            creditsFlowPanel.PerformLayout();
            libraryCreditsFlowPanel.ResumeLayout(false);
            libraryCreditsFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage resumePage;
        private TabPage creditsPage;
        private TabPage welcomePage;
        private TabPage cvPage;
        private TabPage identityPage;
        private ReaLTaiizor.Controls.MaterialButton newIdentityButton;
        private ReaLTaiizor.Controls.MaterialListBox identitiesListBox;
        private ReaLTaiizor.Controls.MaterialLabel identitiesLabel;
        private ReaLTaiizor.Controls.MaterialButton openIdentityButton;
        private TabPage industryPage;
        private ReaLTaiizor.Controls.MaterialLabel historiesLabel;
        private ReaLTaiizor.Controls.MaterialButton newHistoryButton;
        private ReaLTaiizor.Controls.MaterialButton importHistoryButton;
        private System.Windows.Forms.Timer identityRefreshTimer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialExpansionPanel identityConfigExpansionPanel;
        private ReaLTaiizor.Controls.MaterialCheckBox identityEncryptionCheckbox;
        private FlowLayoutPanel creditsFlowPanel;
        private ReaLTaiizor.Controls.MaterialLabel brandenCreditLabel;
        private FlowLayoutPanel libraryCreditsFlowPanel;
        private ReaLTaiizor.Controls.MaterialLabel googleCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel newtonsoftCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel microsoftCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel asposeCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel alexanderCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel taiizorCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel peopleCreditTitleLabel;
        private ReaLTaiizor.Controls.MaterialLabel librariesCreditTitleLabel;
        private ReaLTaiizor.Controls.MaterialLabel serilogCreditLabel;
        private ReaLTaiizor.Controls.MaterialLabel hapCreditLabel;
        private System.Windows.Forms.Timer historyRefreshTimer;
        private ReaLTaiizor.Controls.MaterialButton openIdentityFolderButton;
        private ReaLTaiizor.Controls.MaterialButton openIndustryFolderButton;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private ReaLTaiizor.Controls.MaterialListBox historiesListBox;
        private ReaLTaiizor.Controls.MaterialLabel entryTitleLabel;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialCard materialCard5;
        private ReaLTaiizor.Controls.MaterialButton openResumeWorkspaceButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}
