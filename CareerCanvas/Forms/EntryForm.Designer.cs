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
            identityEncryptionCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            openIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            newIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            flowLayoutPanel1 = new FlowLayoutPanel();
            identitiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identitiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            industryPage = new TabPage();
            historyListFlowPanel = new FlowLayoutPanel();
            historiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            historiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            historyButtonFlowPanel = new FlowLayoutPanel();
            newHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            importHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            resumePage = new TabPage();
            recentResumesFlow = new FlowLayoutPanel();
            recentResumesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            recentResumesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            mainMenuButtonFlowPanel = new FlowLayoutPanel();
            newResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            loadResumeButton = new ReaLTaiizor.Controls.MaterialButton();
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
            materialTabControl1.SuspendLayout();
            welcomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readMeView).BeginInit();
            identityPage.SuspendLayout();
            identityConfigExpansionPanel.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            industryPage.SuspendLayout();
            historyListFlowPanel.SuspendLayout();
            historyButtonFlowPanel.SuspendLayout();
            resumePage.SuspendLayout();
            recentResumesFlow.SuspendLayout();
            mainMenuButtonFlowPanel.SuspendLayout();
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
            identityConfigExpansionPanel.Collapse = true;
            identityConfigExpansionPanel.Controls.Add(identityEncryptionCheckbox);
            identityConfigExpansionPanel.Depth = 0;
            identityConfigExpansionPanel.Description = "Settings related to how identities are stored and handled";
            identityConfigExpansionPanel.ExpandHeight = 542;
            identityConfigExpansionPanel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            identityConfigExpansionPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            identityConfigExpansionPanel.Location = new Point(198, 14);
            identityConfigExpansionPanel.Margin = new Padding(16, 1, 16, 0);
            identityConfigExpansionPanel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityConfigExpansionPanel.Name = "identityConfigExpansionPanel";
            identityConfigExpansionPanel.Padding = new Padding(24, 64, 24, 16);
            identityConfigExpansionPanel.Size = new Size(663, 48);
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
            identityEncryptionCheckbox.Size = new Size(245, 37);
            identityEncryptionCheckbox.TabIndex = 2;
            identityEncryptionCheckbox.Text = "Use encryption (experimental)";
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
            // industryPage
            // 
            industryPage.Controls.Add(historyListFlowPanel);
            industryPage.Controls.Add(historyButtonFlowPanel);
            industryPage.Location = new Point(4, 24);
            industryPage.Name = "industryPage";
            industryPage.Size = new Size(1274, 570);
            industryPage.TabIndex = 5;
            industryPage.Text = "History";
            industryPage.UseVisualStyleBackColor = true;
            // 
            // historyListFlowPanel
            // 
            historyListFlowPanel.Controls.Add(historiesLabel);
            historyListFlowPanel.Controls.Add(historiesListBox);
            historyListFlowPanel.Dock = DockStyle.Right;
            historyListFlowPanel.FlowDirection = FlowDirection.TopDown;
            historyListFlowPanel.Location = new Point(924, 0);
            historyListFlowPanel.Name = "historyListFlowPanel";
            historyListFlowPanel.Size = new Size(350, 570);
            historyListFlowPanel.TabIndex = 5;
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
            historiesLabel.Text = "Industries";
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
            historiesListBox.SelectedIndexChanged += historiesListBox_SelectedIndexChanged;
            // 
            // historyButtonFlowPanel
            // 
            historyButtonFlowPanel.Controls.Add(newHistoryButton);
            historyButtonFlowPanel.Controls.Add(importHistoryButton);
            historyButtonFlowPanel.Dock = DockStyle.Left;
            historyButtonFlowPanel.Location = new Point(0, 0);
            historyButtonFlowPanel.Name = "historyButtonFlowPanel";
            historyButtonFlowPanel.Size = new Size(158, 570);
            historyButtonFlowPanel.TabIndex = 4;
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
            newHistoryButton.Text = "New Industry";
            newHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newHistoryButton.UseAccentColor = false;
            newHistoryButton.UseVisualStyleBackColor = true;
            newHistoryButton.Click += newHistoryButton_Click;
            // 
            // importHistoryButton
            // 
            importHistoryButton.Anchor = AnchorStyles.None;
            importHistoryButton.AutoSize = false;
            importHistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            importHistoryButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            importHistoryButton.Depth = 0;
            importHistoryButton.HighEmphasis = true;
            importHistoryButton.Icon = null;
            importHistoryButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            importHistoryButton.Location = new Point(6, 54);
            importHistoryButton.Margin = new Padding(6);
            importHistoryButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            importHistoryButton.Name = "importHistoryButton";
            importHistoryButton.NoAccentTextColor = Color.Empty;
            importHistoryButton.Size = new Size(136, 36);
            importHistoryButton.TabIndex = 101;
            importHistoryButton.TabStop = false;
            importHistoryButton.Text = "Import Industry";
            importHistoryButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            importHistoryButton.UseAccentColor = false;
            importHistoryButton.UseVisualStyleBackColor = true;
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
            creditsPage.Controls.Add(creditsFlowPanel);
            creditsPage.Controls.Add(libraryCreditsFlowPanel);
            creditsPage.Location = new Point(4, 24);
            creditsPage.Name = "creditsPage";
            creditsPage.Size = new Size(1274, 570);
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
            creditsFlowPanel.Size = new Size(261, 570);
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
            libraryCreditsFlowPanel.Location = new Point(913, 0);
            libraryCreditsFlowPanel.Name = "libraryCreditsFlowPanel";
            libraryCreditsFlowPanel.Size = new Size(361, 570);
            libraryCreditsFlowPanel.TabIndex = 4;
            // 
            // librariesCreditTitleLabel
            // 
            librariesCreditTitleLabel.Anchor = AnchorStyles.Top;
            librariesCreditTitleLabel.AutoSize = true;
            librariesCreditTitleLabel.Depth = 0;
            librariesCreditTitleLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            librariesCreditTitleLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            librariesCreditTitleLabel.Location = new Point(135, 0);
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
            googleCreditLabel.Location = new Point(95, 24);
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
            newtonsoftCreditLabel.Location = new Point(91, 41);
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
            microsoftCreditLabel.Size = new Size(343, 17);
            microsoftCreditLabel.TabIndex = 3;
            microsoftCreditLabel.Text = "Microsoft - WinForms Framework and DotNet Runtime";
            // 
            // asposeCreditLabel
            // 
            asposeCreditLabel.Anchor = AnchorStyles.Top;
            asposeCreditLabel.AutoSize = true;
            asposeCreditLabel.Depth = 0;
            asposeCreditLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            asposeCreditLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            asposeCreditLabel.Location = new Point(69, 75);
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
            alexanderCreditLabel.Location = new Point(68, 92);
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
            taiizorCreditLabel.Location = new Point(83, 109);
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
            serilogCreditLabel.Location = new Point(83, 126);
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
            hapCreditLabel.Location = new Point(80, 143);
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
            industryPage.ResumeLayout(false);
            historyListFlowPanel.ResumeLayout(false);
            historyButtonFlowPanel.ResumeLayout(false);
            resumePage.ResumeLayout(false);
            recentResumesFlow.ResumeLayout(false);
            mainMenuButtonFlowPanel.ResumeLayout(false);
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
        private TabPage industryPage;
        private FlowLayoutPanel historyListFlowPanel;
        private ReaLTaiizor.Controls.MaterialLabel historiesLabel;
        private ReaLTaiizor.Controls.MaterialListBox historiesListBox;
        private FlowLayoutPanel historyButtonFlowPanel;
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
    }
}
