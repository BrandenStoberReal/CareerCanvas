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
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            welcomePage = new TabPage();
            readMeView = new Microsoft.Web.WebView2.WinForms.WebView2();
            welcomeLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identityPage = new TabPage();
            resumePage = new TabPage();
            recentsFlowPanel = new FlowLayoutPanel();
            recentsLabel = new ReaLTaiizor.Controls.MaterialLabel();
            recentResumesFlow = new FlowLayoutPanel();
            mainMenuButtonFlowPanel = new FlowLayoutPanel();
            newResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            loadResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            cvPage = new TabPage();
            creditsPage = new TabPage();
            materialTabControl1.SuspendLayout();
            welcomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readMeView).BeginInit();
            resumePage.SuspendLayout();
            recentsFlowPanel.SuspendLayout();
            mainMenuButtonFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(welcomePage);
            materialTabControl1.Controls.Add(identityPage);
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
            welcomePage.Controls.Add(welcomeLabel);
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
            readMeView.Dock = DockStyle.Bottom;
            readMeView.ForeColor = SystemColors.Control;
            readMeView.Location = new Point(0, 60);
            readMeView.Name = "readMeView";
            readMeView.Size = new Size(1274, 510);
            readMeView.TabIndex = 1;
            readMeView.ZoomFactor = 1D;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Depth = 0;
            welcomeLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            welcomeLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            welcomeLabel.HighEmphasis = true;
            welcomeLabel.Location = new Point(84, 0);
            welcomeLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(1106, 57);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Career Canvas!";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // identityPage
            // 
            identityPage.Location = new Point(4, 24);
            identityPage.Name = "identityPage";
            identityPage.Size = new Size(1274, 570);
            identityPage.TabIndex = 4;
            identityPage.Text = "Identities";
            identityPage.UseVisualStyleBackColor = true;
            // 
            // resumePage
            // 
            resumePage.Controls.Add(recentsFlowPanel);
            resumePage.Controls.Add(mainMenuButtonFlowPanel);
            resumePage.Location = new Point(4, 24);
            resumePage.Name = "resumePage";
            resumePage.Size = new Size(1274, 570);
            resumePage.TabIndex = 0;
            resumePage.Text = "Resume";
            resumePage.UseVisualStyleBackColor = true;
            // 
            // recentsFlowPanel
            // 
            recentsFlowPanel.Controls.Add(recentsLabel);
            recentsFlowPanel.Controls.Add(recentResumesFlow);
            recentsFlowPanel.FlowDirection = FlowDirection.TopDown;
            recentsFlowPanel.Location = new Point(759, 3);
            recentsFlowPanel.Name = "recentsFlowPanel";
            recentsFlowPanel.Size = new Size(512, 564);
            recentsFlowPanel.TabIndex = 3;
            // 
            // recentsLabel
            // 
            recentsLabel.Anchor = AnchorStyles.Top;
            recentsLabel.Depth = 0;
            recentsLabel.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            recentsLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            recentsLabel.HighEmphasis = true;
            recentsLabel.Location = new Point(3, 0);
            recentsLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            recentsLabel.Name = "recentsLabel";
            recentsLabel.Size = new Size(503, 29);
            recentsLabel.TabIndex = 3;
            recentsLabel.Text = "Recent Resumes";
            recentsLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // recentResumesFlow
            // 
            recentResumesFlow.Dock = DockStyle.Bottom;
            recentResumesFlow.Location = new Point(3, 32);
            recentResumesFlow.Name = "recentResumesFlow";
            recentResumesFlow.Size = new Size(503, 527);
            recentResumesFlow.TabIndex = 4;
            // 
            // mainMenuButtonFlowPanel
            // 
            mainMenuButtonFlowPanel.Controls.Add(newResumeButton);
            mainMenuButtonFlowPanel.Controls.Add(loadResumeButton);
            mainMenuButtonFlowPanel.FlowDirection = FlowDirection.TopDown;
            mainMenuButtonFlowPanel.Location = new Point(3, 3);
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
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            welcomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readMeView).EndInit();
            resumePage.ResumeLayout(false);
            recentsFlowPanel.ResumeLayout(false);
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
        private FlowLayoutPanel recentsFlowPanel;
        private ReaLTaiizor.Controls.MaterialLabel recentsLabel;
        private FlowLayoutPanel recentResumesFlow;
        private TabPage welcomePage;
        private ReaLTaiizor.Controls.MaterialLabel welcomeLabel;
        private TabPage cvPage;
        private TabPage identityPage;
        private Microsoft.Web.WebView2.WinForms.WebView2 readMeView;
    }
}
