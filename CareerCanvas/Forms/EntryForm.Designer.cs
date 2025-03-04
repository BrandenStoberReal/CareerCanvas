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
            identityPage = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            identitiesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            identitiesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            identityButtonsFlow = new FlowLayoutPanel();
            newIdentityButton = new ReaLTaiizor.Controls.MaterialButton();
            resumePage = new TabPage();
            recentResumesFlow = new FlowLayoutPanel();
            recentResumesLabel = new ReaLTaiizor.Controls.MaterialLabel();
            recentResumesListBox = new ReaLTaiizor.Controls.MaterialListBox();
            mainMenuButtonFlowPanel = new FlowLayoutPanel();
            newResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            loadResumeButton = new ReaLTaiizor.Controls.MaterialButton();
            cvPage = new TabPage();
            creditsPage = new TabPage();
            materialTabControl1.SuspendLayout();
            welcomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readMeView).BeginInit();
            identityPage.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            identityButtonsFlow.SuspendLayout();
            resumePage.SuspendLayout();
            recentResumesFlow.SuspendLayout();
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
            identityPage.Controls.Add(flowLayoutPanel1);
            identityPage.Controls.Add(identityButtonsFlow);
            identityPage.Location = new Point(4, 24);
            identityPage.Name = "identityPage";
            identityPage.Size = new Size(1274, 570);
            identityPage.TabIndex = 4;
            identityPage.Text = "Identities";
            identityPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(identitiesLabel);
            flowLayoutPanel1.Controls.Add(identitiesListBox);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(924, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 570);
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
            identitiesListBox.Size = new Size(334, 535);
            identitiesListBox.TabIndex = 2;
            // 
            // identityButtonsFlow
            // 
            identityButtonsFlow.Controls.Add(newIdentityButton);
            identityButtonsFlow.Dock = DockStyle.Left;
            identityButtonsFlow.Location = new Point(0, 0);
            identityButtonsFlow.Name = "identityButtonsFlow";
            identityButtonsFlow.Size = new Size(158, 570);
            identityButtonsFlow.TabIndex = 0;
            // 
            // newIdentityButton
            // 
            newIdentityButton.Anchor = AnchorStyles.None;
            newIdentityButton.AutoSize = false;
            newIdentityButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newIdentityButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            newIdentityButton.Depth = 0;
            newIdentityButton.HighEmphasis = true;
            newIdentityButton.Icon = null;
            newIdentityButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            newIdentityButton.Location = new Point(6, 6);
            newIdentityButton.Margin = new Padding(6);
            newIdentityButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            newIdentityButton.Name = "newIdentityButton";
            newIdentityButton.NoAccentTextColor = Color.Empty;
            newIdentityButton.Size = new Size(136, 36);
            newIdentityButton.TabIndex = 1;
            newIdentityButton.Text = "New Identity";
            newIdentityButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            newIdentityButton.UseAccentColor = false;
            newIdentityButton.UseVisualStyleBackColor = true;
            newIdentityButton.Click += newIdentityButton_Click;
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
            identityPage.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            identityButtonsFlow.ResumeLayout(false);
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
        private FlowLayoutPanel identityButtonsFlow;
        private ReaLTaiizor.Controls.MaterialButton newIdentityButton;
        private ReaLTaiizor.Controls.MaterialListBox identitiesListBox;
        private FlowLayoutPanel recentResumesFlow;
        private ReaLTaiizor.Controls.MaterialLabel recentResumesLabel;
        private ReaLTaiizor.Controls.MaterialListBox recentResumesListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel identitiesLabel;
    }
}
