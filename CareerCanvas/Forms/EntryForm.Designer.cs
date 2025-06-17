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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            identityRefreshTimer = new System.Windows.Forms.Timer(components);
            historyRefreshTimer = new System.Windows.Forms.Timer(components);
            tabPage1 = new TabPage();
            aiPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            geminiKeyBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            anthropicKeyBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            openAiKeyBox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            geminiLinkLabel = new LinkLabel();
            cvPage = new TabPage();
            materialCard6 = new ReaLTaiizor.Controls.MaterialCard();
            openCvBuilderButton = new ReaLTaiizor.Controls.MaterialButton();
            resumePage = new TabPage();
            materialCard5 = new ReaLTaiizor.Controls.MaterialCard();
            openResumeWorkspaceButton = new ReaLTaiizor.Controls.MaterialButton();
            industryPage = new TabPage();
            materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            newHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            openIndustryFolderButton = new ReaLTaiizor.Controls.MaterialButton();
            importHistoryButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            historiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            historiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
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
            welcomePage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialCard12 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard11 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard10 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard9 = new ReaLTaiizor.Controls.MaterialCard();
            industryCountLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identityCountLabel = new ReaLTaiizor.Controls.MaterialLabel();
            coverLetterTemplatesCountLabel = new ReaLTaiizor.Controls.MaterialLabel();
            resumeTemplatesCountLabel = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel9 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard8 = new ReaLTaiizor.Controls.MaterialCard();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            materialCard7 = new ReaLTaiizor.Controls.MaterialCard();
            clearLogsButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            entryTitleLabel = new ReaLTaiizor.Controls.MaterialLabel();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            prefsPage = new TabPage();
            aiPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cvPage.SuspendLayout();
            materialCard6.SuspendLayout();
            resumePage.SuspendLayout();
            materialCard5.SuspendLayout();
            industryPage.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            identityPage.SuspendLayout();
            identityConfigExpansionPanel.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            welcomePage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard9.SuspendLayout();
            materialCard8.SuspendLayout();
            materialCard7.SuspendLayout();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
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
            // aiPage
            // 
            aiPage.Controls.Add(tableLayoutPanel1);
            aiPage.Location = new Point(4, 24);
            aiPage.Name = "aiPage";
            aiPage.Padding = new Padding(3);
            aiPage.Size = new Size(1077, 616);
            aiPage.TabIndex = 6;
            aiPage.Text = "AI Secrets";
            aiPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(geminiKeyBox, 2, 2);
            tableLayoutPanel1.Controls.Add(anthropicKeyBox, 2, 1);
            tableLayoutPanel1.Controls.Add(openAiKeyBox, 2, 0);
            tableLayoutPanel1.Controls.Add(materialLabel1, 1, 0);
            tableLayoutPanel1.Controls.Add(materialLabel3, 1, 1);
            tableLayoutPanel1.Controls.Add(materialLabel4, 1, 2);
            tableLayoutPanel1.Controls.Add(geminiLinkLabel, 0, 2);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1065, 604);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // geminiKeyBox
            // 
            geminiKeyBox.AnimateReadOnly = false;
            geminiKeyBox.AutoCompleteMode = AutoCompleteMode.None;
            geminiKeyBox.AutoCompleteSource = AutoCompleteSource.None;
            geminiKeyBox.BackgroundImageLayout = ImageLayout.None;
            geminiKeyBox.CharacterCasing = CharacterCasing.Normal;
            geminiKeyBox.Depth = 0;
            geminiKeyBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            geminiKeyBox.HideSelection = true;
            geminiKeyBox.Hint = "Key goes here...";
            geminiKeyBox.LeadingIcon = null;
            geminiKeyBox.Location = new Point(292, 111);
            geminiKeyBox.MaxLength = 32767;
            geminiKeyBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            geminiKeyBox.Name = "geminiKeyBox";
            geminiKeyBox.PasswordChar = '●';
            geminiKeyBox.PrefixSuffixText = null;
            geminiKeyBox.ReadOnly = false;
            geminiKeyBox.RightToLeft = RightToLeft.No;
            geminiKeyBox.SelectedText = "";
            geminiKeyBox.SelectionLength = 0;
            geminiKeyBox.SelectionStart = 0;
            geminiKeyBox.ShortcutsEnabled = true;
            geminiKeyBox.Size = new Size(773, 48);
            geminiKeyBox.TabIndex = 5;
            geminiKeyBox.TabStop = false;
            geminiKeyBox.TextAlign = HorizontalAlignment.Left;
            geminiKeyBox.TrailingIcon = null;
            geminiKeyBox.UseSystemPasswordChar = true;
            geminiKeyBox.TextChanged += geminiKeyBox_TextChanged;
            // 
            // anthropicKeyBox
            // 
            anthropicKeyBox.AnimateReadOnly = false;
            anthropicKeyBox.AutoCompleteMode = AutoCompleteMode.None;
            anthropicKeyBox.AutoCompleteSource = AutoCompleteSource.None;
            anthropicKeyBox.BackgroundImageLayout = ImageLayout.None;
            anthropicKeyBox.CharacterCasing = CharacterCasing.Normal;
            anthropicKeyBox.Depth = 0;
            anthropicKeyBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            anthropicKeyBox.HideSelection = true;
            anthropicKeyBox.Hint = "Key goes here...";
            anthropicKeyBox.LeadingIcon = null;
            anthropicKeyBox.Location = new Point(292, 57);
            anthropicKeyBox.MaxLength = 32767;
            anthropicKeyBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            anthropicKeyBox.Name = "anthropicKeyBox";
            anthropicKeyBox.PasswordChar = '●';
            anthropicKeyBox.PrefixSuffixText = null;
            anthropicKeyBox.ReadOnly = false;
            anthropicKeyBox.RightToLeft = RightToLeft.No;
            anthropicKeyBox.SelectedText = "";
            anthropicKeyBox.SelectionLength = 0;
            anthropicKeyBox.SelectionStart = 0;
            anthropicKeyBox.ShortcutsEnabled = true;
            anthropicKeyBox.Size = new Size(773, 48);
            anthropicKeyBox.TabIndex = 3;
            anthropicKeyBox.TabStop = false;
            anthropicKeyBox.TextAlign = HorizontalAlignment.Left;
            anthropicKeyBox.TrailingIcon = null;
            anthropicKeyBox.UseSystemPasswordChar = true;
            anthropicKeyBox.TextChanged += anthropicKeyBox_TextChanged;
            // 
            // openAiKeyBox
            // 
            openAiKeyBox.AnimateReadOnly = false;
            openAiKeyBox.AutoCompleteMode = AutoCompleteMode.None;
            openAiKeyBox.AutoCompleteSource = AutoCompleteSource.None;
            openAiKeyBox.BackgroundImageLayout = ImageLayout.None;
            openAiKeyBox.CharacterCasing = CharacterCasing.Normal;
            openAiKeyBox.Depth = 0;
            openAiKeyBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            openAiKeyBox.HideSelection = true;
            openAiKeyBox.Hint = "Key goes here...";
            openAiKeyBox.LeadingIcon = null;
            openAiKeyBox.Location = new Point(292, 3);
            openAiKeyBox.MaxLength = 32767;
            openAiKeyBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            openAiKeyBox.Name = "openAiKeyBox";
            openAiKeyBox.PasswordChar = '●';
            openAiKeyBox.PrefixSuffixText = null;
            openAiKeyBox.ReadOnly = false;
            openAiKeyBox.RightToLeft = RightToLeft.No;
            openAiKeyBox.SelectedText = "";
            openAiKeyBox.SelectionLength = 0;
            openAiKeyBox.SelectionStart = 0;
            openAiKeyBox.ShortcutsEnabled = true;
            openAiKeyBox.Size = new Size(773, 48);
            openAiKeyBox.TabIndex = 1;
            openAiKeyBox.TabStop = false;
            openAiKeyBox.TextAlign = HorizontalAlignment.Left;
            openAiKeyBox.TrailingIcon = null;
            openAiKeyBox.UseSystemPasswordChar = true;
            openAiKeyBox.TextChanged += openAiKeyBox_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.Location = new Point(182, 18);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(104, 17);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "OpenAI API Key:";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel3.Location = new Point(167, 72);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(119, 17);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Anthropic API Key:";
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Right;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel4.Location = new Point(134, 126);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(152, 17);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Google Gemini API Key:";
            // 
            // geminiLinkLabel
            // 
            geminiLinkLabel.Anchor = AnchorStyles.Right;
            geminiLinkLabel.AutoSize = true;
            geminiLinkLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            geminiLinkLabel.LinkColor = Color.FromArgb(255, 128, 128);
            geminiLinkLabel.Location = new Point(3, 127);
            geminiLinkLabel.Name = "geminiLinkLabel";
            geminiLinkLabel.Size = new Size(125, 15);
            geminiLinkLabel.TabIndex = 6;
            geminiLinkLabel.TabStop = true;
            geminiLinkLabel.Text = "Grab a free Gemini key";
            geminiLinkLabel.LinkClicked += geminiLinkLabel_LinkClicked;
            // 
            // cvPage
            // 
            cvPage.Controls.Add(materialCard6);
            cvPage.Location = new Point(4, 24);
            cvPage.Name = "cvPage";
            cvPage.Size = new Size(1077, 616);
            cvPage.TabIndex = 3;
            cvPage.Text = "Cover Letter";
            cvPage.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(openCvBuilderButton);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(14, 14);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(1049, 78);
            materialCard6.TabIndex = 1;
            // 
            // openCvBuilderButton
            // 
            openCvBuilderButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openCvBuilderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openCvBuilderButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openCvBuilderButton.Depth = 0;
            openCvBuilderButton.HighEmphasis = true;
            openCvBuilderButton.Icon = null;
            openCvBuilderButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openCvBuilderButton.Location = new Point(452, 20);
            openCvBuilderButton.Margin = new Padding(4, 6, 4, 6);
            openCvBuilderButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openCvBuilderButton.Name = "openCvBuilderButton";
            openCvBuilderButton.NoAccentTextColor = Color.Empty;
            openCvBuilderButton.Size = new Size(145, 36);
            openCvBuilderButton.TabIndex = 0;
            openCvBuilderButton.Text = "Open CV Builder";
            openCvBuilderButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openCvBuilderButton.UseAccentColor = false;
            openCvBuilderButton.UseVisualStyleBackColor = true;
            openCvBuilderButton.Click += openCvBuilderButton_Click;
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
            materialCard5.Size = new Size(1049, 78);
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
            openResumeWorkspaceButton.Location = new Point(437, 20);
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
            historiesLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            historiesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            historiesLabel.Location = new Point(17, 14);
            historiesLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            historiesLabel.Name = "historiesLabel";
            historiesLabel.Size = new Size(391, 23);
            historiesLabel.TabIndex = 4;
            historiesLabel.Text = "Industries";
            historiesLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            identityConfigExpansionPanel.Description = "Identity storage options";
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
            identitiesLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            identitiesLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
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
            // welcomePage
            // 
            welcomePage.Controls.Add(tableLayoutPanel2);
            welcomePage.Controls.Add(materialLabel2);
            welcomePage.Controls.Add(entryTitleLabel);
            welcomePage.Location = new Point(4, 24);
            welcomePage.Name = "welcomePage";
            welcomePage.Size = new Size(1077, 616);
            welcomePage.TabIndex = 2;
            welcomePage.Text = "Welcome";
            welcomePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(materialCard12, 0, 1);
            tableLayoutPanel2.Controls.Add(materialCard11, 1, 1);
            tableLayoutPanel2.Controls.Add(materialCard10, 2, 1);
            tableLayoutPanel2.Controls.Add(materialCard9, 2, 0);
            tableLayoutPanel2.Controls.Add(materialCard8, 1, 0);
            tableLayoutPanel2.Controls.Add(materialCard7, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 72);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1071, 541);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // materialCard12
            // 
            materialCard12.BackColor = Color.FromArgb(255, 255, 255);
            materialCard12.Depth = 0;
            materialCard12.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard12.Location = new Point(14, 284);
            materialCard12.Margin = new Padding(14);
            materialCard12.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard12.Name = "materialCard12";
            materialCard12.Padding = new Padding(14);
            materialCard12.Size = new Size(329, 242);
            materialCard12.TabIndex = 1;
            // 
            // materialCard11
            // 
            materialCard11.BackColor = Color.FromArgb(255, 255, 255);
            materialCard11.Depth = 0;
            materialCard11.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard11.Location = new Point(371, 284);
            materialCard11.Margin = new Padding(14);
            materialCard11.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard11.Name = "materialCard11";
            materialCard11.Padding = new Padding(14);
            materialCard11.Size = new Size(329, 242);
            materialCard11.TabIndex = 1;
            // 
            // materialCard10
            // 
            materialCard10.BackColor = Color.FromArgb(255, 255, 255);
            materialCard10.Depth = 0;
            materialCard10.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard10.Location = new Point(728, 284);
            materialCard10.Margin = new Padding(14);
            materialCard10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard10.Name = "materialCard10";
            materialCard10.Padding = new Padding(14);
            materialCard10.Size = new Size(329, 242);
            materialCard10.TabIndex = 1;
            // 
            // materialCard9
            // 
            materialCard9.BackColor = Color.FromArgb(255, 255, 255);
            materialCard9.Controls.Add(industryCountLabel);
            materialCard9.Controls.Add(identityCountLabel);
            materialCard9.Controls.Add(coverLetterTemplatesCountLabel);
            materialCard9.Controls.Add(resumeTemplatesCountLabel);
            materialCard9.Controls.Add(materialLabel9);
            materialCard9.Depth = 0;
            materialCard9.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard9.Location = new Point(728, 14);
            materialCard9.Margin = new Padding(14);
            materialCard9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard9.Name = "materialCard9";
            materialCard9.Padding = new Padding(14);
            materialCard9.Size = new Size(329, 242);
            materialCard9.TabIndex = 1;
            // 
            // industryCountLabel
            // 
            industryCountLabel.Depth = 0;
            industryCountLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            industryCountLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            industryCountLabel.Location = new Point(17, 110);
            industryCountLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            industryCountLabel.Name = "industryCountLabel";
            industryCountLabel.Size = new Size(295, 23);
            industryCountLabel.TabIndex = 7;
            industryCountLabel.Text = "industries";
            industryCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identityCountLabel
            // 
            identityCountLabel.Depth = 0;
            identityCountLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            identityCountLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            identityCountLabel.Location = new Point(17, 83);
            identityCountLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            identityCountLabel.Name = "identityCountLabel";
            identityCountLabel.Size = new Size(295, 23);
            identityCountLabel.TabIndex = 6;
            identityCountLabel.Text = "identities";
            identityCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // coverLetterTemplatesCountLabel
            // 
            coverLetterTemplatesCountLabel.Depth = 0;
            coverLetterTemplatesCountLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            coverLetterTemplatesCountLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            coverLetterTemplatesCountLabel.Location = new Point(17, 60);
            coverLetterTemplatesCountLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            coverLetterTemplatesCountLabel.Name = "coverLetterTemplatesCountLabel";
            coverLetterTemplatesCountLabel.Size = new Size(295, 23);
            coverLetterTemplatesCountLabel.TabIndex = 5;
            coverLetterTemplatesCountLabel.Text = "cover letter template(s)";
            coverLetterTemplatesCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resumeTemplatesCountLabel
            // 
            resumeTemplatesCountLabel.Depth = 0;
            resumeTemplatesCountLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            resumeTemplatesCountLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            resumeTemplatesCountLabel.Location = new Point(17, 37);
            resumeTemplatesCountLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            resumeTemplatesCountLabel.Name = "resumeTemplatesCountLabel";
            resumeTemplatesCountLabel.Size = new Size(295, 23);
            resumeTemplatesCountLabel.TabIndex = 4;
            resumeTemplatesCountLabel.Text = "resume template(s)";
            resumeTemplatesCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel9.Location = new Point(17, 14);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(295, 23);
            materialLabel9.TabIndex = 4;
            materialLabel9.Text = "Currently Loaded";
            materialLabel9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(materialLabel8);
            materialCard8.Controls.Add(materialLabel7);
            materialCard8.Controls.Add(materialLabel6);
            materialCard8.Controls.Add(materialLabel5);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(371, 14);
            materialCard8.Margin = new Padding(14);
            materialCard8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(14);
            materialCard8.Size = new Size(329, 242);
            materialCard8.TabIndex = 1;
            // 
            // materialLabel8
            // 
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel8.Location = new Point(17, 83);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(295, 23);
            materialLabel8.TabIndex = 3;
            materialLabel8.Text = "Various OSS Developers - Libraries";
            materialLabel8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel7.Location = new Point(17, 60);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(295, 23);
            materialLabel7.TabIndex = 2;
            materialLabel7.Text = "Travis Geisinger - Machine Learning";
            materialLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel6.Location = new Point(17, 37);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(295, 23);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "Branden Stober - UI and Backend";
            materialLabel6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel5.Location = new Point(17, 14);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(295, 23);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Credits";
            materialLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(clearLogsButton);
            materialCard7.Controls.Add(materialLabel10);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(14, 14);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(329, 242);
            materialCard7.TabIndex = 0;
            // 
            // clearLogsButton
            // 
            clearLogsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearLogsButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            clearLogsButton.Depth = 0;
            clearLogsButton.HighEmphasis = true;
            clearLogsButton.Icon = null;
            clearLogsButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            clearLogsButton.Location = new Point(111, 43);
            clearLogsButton.Margin = new Padding(4, 6, 4, 6);
            clearLogsButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            clearLogsButton.Name = "clearLogsButton";
            clearLogsButton.NoAccentTextColor = Color.Empty;
            clearLogsButton.Size = new Size(107, 36);
            clearLogsButton.TabIndex = 5;
            clearLogsButton.Text = "Clear Logs";
            clearLogsButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            clearLogsButton.UseAccentColor = false;
            clearLogsButton.UseVisualStyleBackColor = true;
            clearLogsButton.Click += clearLogsButton_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel10.Location = new Point(17, 14);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(295, 23);
            materialLabel10.TabIndex = 4;
            materialLabel10.Text = "Operations";
            materialLabel10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
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
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(welcomePage);
            materialTabControl1.Controls.Add(identityPage);
            materialTabControl1.Controls.Add(industryPage);
            materialTabControl1.Controls.Add(resumePage);
            materialTabControl1.Controls.Add(cvPage);
            materialTabControl1.Controls.Add(aiPage);
            materialTabControl1.Controls.Add(prefsPage);
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
            // prefsPage
            // 
            prefsPage.Location = new Point(4, 24);
            prefsPage.Name = "prefsPage";
            prefsPage.Size = new Size(1077, 616);
            prefsPage.TabIndex = 7;
            prefsPage.Text = "Preferences";
            prefsPage.UseVisualStyleBackColor = true;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntryForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Career Canvas";
            FormClosing += EntryForm_FormClosing;
            Load += EntryForm_Load;
            aiPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            cvPage.ResumeLayout(false);
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            resumePage.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            industryPage.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            identityPage.ResumeLayout(false);
            identityConfigExpansionPanel.ResumeLayout(false);
            identityConfigExpansionPanel.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            welcomePage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            materialCard9.ResumeLayout(false);
            materialCard8.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer identityRefreshTimer;
        private System.Windows.Forms.Timer historyRefreshTimer;
        private TabPage tabPage1;
        private TabPage aiPage;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit geminiKeyBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit anthropicKeyBox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit openAiKeyBox;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private LinkLabel geminiLinkLabel;
        private TabPage cvPage;
        private ReaLTaiizor.Controls.MaterialCard materialCard6;
        private ReaLTaiizor.Controls.MaterialButton openCvBuilderButton;
        private TabPage resumePage;
        private ReaLTaiizor.Controls.MaterialCard materialCard5;
        private ReaLTaiizor.Controls.MaterialButton openResumeWorkspaceButton;
        private TabPage industryPage;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private ReaLTaiizor.Controls.MaterialButton newHistoryButton;
        private ReaLTaiizor.Controls.MaterialButton openIndustryFolderButton;
        private ReaLTaiizor.Controls.MaterialButton importHistoryButton;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialListBox historiesListBox;
        private ReaLTaiizor.Controls.MaterialLabel historiesLabel;
        private TabPage identityPage;
        private ReaLTaiizor.Controls.MaterialExpansionPanel identityConfigExpansionPanel;
        private ReaLTaiizor.Controls.MaterialCheckBox identityEncryptionCheckbox;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialButton openIdentityFolderButton;
        private ReaLTaiizor.Controls.MaterialButton openIdentityButton;
        private ReaLTaiizor.Controls.MaterialButton newIdentityButton;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel identitiesLabel;
        private ReaLTaiizor.Controls.MaterialListBox identitiesListBox;
        private TabPage welcomePage;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialCard materialCard12;
        private ReaLTaiizor.Controls.MaterialCard materialCard11;
        private ReaLTaiizor.Controls.MaterialCard materialCard10;
        private ReaLTaiizor.Controls.MaterialCard materialCard9;
        private ReaLTaiizor.Controls.MaterialCard materialCard8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialCard materialCard7;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel entryTitleLabel;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private ReaLTaiizor.Controls.MaterialLabel coverLetterTemplatesCountLabel;
        private ReaLTaiizor.Controls.MaterialLabel resumeTemplatesCountLabel;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel9;
        private ReaLTaiizor.Controls.MaterialLabel industryCountLabel;
        private ReaLTaiizor.Controls.MaterialLabel identityCountLabel;
        private ReaLTaiizor.Controls.MaterialButton clearLogsButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private TabPage prefsPage;
    }
}
