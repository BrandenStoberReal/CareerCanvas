namespace CareerCanvas.Forms.Workspaces
{
    partial class ResumeWorkspace
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
            resumeViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            openTemplateFolderButton = new ReaLTaiizor.Controls.MaterialButton();
            loadTemplateButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            logLabel = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)resumeViewer).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // resumeViewer
            // 
            resumeViewer.AllowExternalDrop = true;
            resumeViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resumeViewer.CreationProperties = null;
            resumeViewer.DefaultBackgroundColor = Color.White;
            resumeViewer.Location = new Point(493, 50);
            resumeViewer.Name = "resumeViewer";
            resumeViewer.Size = new Size(812, 872);
            resumeViewer.TabIndex = 0;
            resumeViewer.ZoomFactor = 1D;
            resumeViewer.CoreWebView2InitializationCompleted += resumeViewer_CoreWebView2InitializationCompleted;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(openTemplateFolderButton);
            materialCard1.Controls.Add(loadTemplateButton);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Left;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 24);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(459, 898);
            materialCard1.TabIndex = 1;
            materialCard1.Click += materialCard1_Click;
            // 
            // openTemplateFolderButton
            // 
            openTemplateFolderButton.AutoSize = false;
            openTemplateFolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openTemplateFolderButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openTemplateFolderButton.Depth = 0;
            openTemplateFolderButton.HighEmphasis = true;
            openTemplateFolderButton.Icon = null;
            openTemplateFolderButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openTemplateFolderButton.Location = new Point(237, 20);
            openTemplateFolderButton.Margin = new Padding(4, 6, 4, 6);
            openTemplateFolderButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openTemplateFolderButton.Name = "openTemplateFolderButton";
            openTemplateFolderButton.NoAccentTextColor = Color.Empty;
            openTemplateFolderButton.Size = new Size(204, 36);
            openTemplateFolderButton.TabIndex = 1;
            openTemplateFolderButton.Text = "Open Templates Folder";
            openTemplateFolderButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openTemplateFolderButton.UseAccentColor = false;
            openTemplateFolderButton.UseVisualStyleBackColor = true;
            openTemplateFolderButton.Click += openTemplateFolderButton_Click;
            // 
            // loadTemplateButton
            // 
            loadTemplateButton.AutoSize = false;
            loadTemplateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadTemplateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadTemplateButton.Depth = 0;
            loadTemplateButton.HighEmphasis = true;
            loadTemplateButton.Icon = null;
            loadTemplateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loadTemplateButton.Location = new Point(18, 20);
            loadTemplateButton.Margin = new Padding(4, 6, 4, 6);
            loadTemplateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loadTemplateButton.Name = "loadTemplateButton";
            loadTemplateButton.NoAccentTextColor = Color.Empty;
            loadTemplateButton.Size = new Size(144, 36);
            loadTemplateButton.TabIndex = 0;
            loadTemplateButton.Text = "Load Template";
            loadTemplateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loadTemplateButton.UseAccentColor = false;
            loadTemplateButton.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Right;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(1336, 24);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(459, 898);
            materialCard2.TabIndex = 2;
            materialCard2.Click += materialCard2_Click;
            // 
            // logLabel
            // 
            logLabel.Depth = 0;
            logLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            logLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            logLabel.Location = new Point(479, 25);
            logLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(826, 23);
            logLabel.TabIndex = 3;
            logLabel.Text = "Preview:";
            logLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResumeWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1798, 925);
            Controls.Add(logLabel);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(resumeViewer);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "ResumeWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resume Workspace";
            Load += ResumeWorkspace_Load;
            ((System.ComponentModel.ISupportInitialize)resumeViewer).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 resumeViewer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialButton openTemplateFolderButton;
        private ReaLTaiizor.Controls.MaterialButton loadTemplateButton;
        private ReaLTaiizor.Controls.MaterialLabel logLabel;
    }
}