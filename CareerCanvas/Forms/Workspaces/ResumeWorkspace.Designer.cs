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
            tableLayoutPanel2 = new TableLayoutPanel();
            exportHtmlButton = new ReaLTaiizor.Controls.MaterialButton();
            exportPdfButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            openTemplateFolderButton = new ReaLTaiizor.Controls.MaterialButton();
            loadTemplateButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            useShadowsToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            scaleToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            optimizeToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            backgroundToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialSlider1 = new ReaLTaiizor.Controls.MaterialSlider();
            ((System.ComponentModel.ISupportInitialize)resumeViewer).BeginInit();
            materialCard1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // resumeViewer
            // 
            resumeViewer.AllowExternalDrop = true;
            resumeViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resumeViewer.CreationProperties = null;
            resumeViewer.DefaultBackgroundColor = Color.White;
            resumeViewer.Location = new Point(486, 34);
            resumeViewer.Margin = new Padding(10);
            resumeViewer.Name = "resumeViewer";
            resumeViewer.Size = new Size(826, 878);
            resumeViewer.TabIndex = 0;
            resumeViewer.ZoomFactor = 1D;
            resumeViewer.CoreWebView2InitializationCompleted += resumeViewer_CoreWebView2InitializationCompleted;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel2);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Left;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 24);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(471, 898);
            materialCard1.TabIndex = 1;
            materialCard1.Click += materialCard1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(exportHtmlButton, 0, 0);
            tableLayoutPanel2.Controls.Add(exportPdfButton, 0, 1);
            tableLayoutPanel2.Controls.Add(materialSlider1, 1, 0);
            tableLayoutPanel2.Location = new Point(17, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(437, 828);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Click += tableLayoutPanel2_Click;
            // 
            // exportHtmlButton
            // 
            exportHtmlButton.Anchor = AnchorStyles.Left;
            exportHtmlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportHtmlButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportHtmlButton.Depth = 0;
            exportHtmlButton.HighEmphasis = true;
            exportHtmlButton.Icon = null;
            exportHtmlButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            exportHtmlButton.Location = new Point(4, 7);
            exportHtmlButton.Margin = new Padding(4, 6, 4, 6);
            exportHtmlButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exportHtmlButton.Name = "exportHtmlButton";
            exportHtmlButton.NoAccentTextColor = Color.Empty;
            exportHtmlButton.Size = new Size(143, 36);
            exportHtmlButton.TabIndex = 1;
            exportHtmlButton.Text = "Export to HTML";
            exportHtmlButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            exportHtmlButton.UseAccentColor = false;
            exportHtmlButton.UseVisualStyleBackColor = true;
            exportHtmlButton.Click += exportHtmlButton_Click;
            // 
            // exportPdfButton
            // 
            exportPdfButton.Anchor = AnchorStyles.Left;
            exportPdfButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportPdfButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportPdfButton.Depth = 0;
            exportPdfButton.HighEmphasis = true;
            exportPdfButton.Icon = null;
            exportPdfButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            exportPdfButton.Location = new Point(4, 57);
            exportPdfButton.Margin = new Padding(4, 6, 4, 6);
            exportPdfButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exportPdfButton.Name = "exportPdfButton";
            exportPdfButton.NoAccentTextColor = Color.Empty;
            exportPdfButton.Size = new Size(130, 36);
            exportPdfButton.TabIndex = 0;
            exportPdfButton.Text = "Export to PDF";
            exportPdfButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            exportPdfButton.UseAccentColor = false;
            exportPdfButton.UseVisualStyleBackColor = true;
            exportPdfButton.Click += exportPdfButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel2.Location = new Point(17, 10);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(437, 23);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "System Options";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openTemplateFolderButton
            // 
            openTemplateFolderButton.Anchor = AnchorStyles.Right;
            openTemplateFolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openTemplateFolderButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openTemplateFolderButton.Depth = 0;
            openTemplateFolderButton.HighEmphasis = true;
            openTemplateFolderButton.Icon = null;
            openTemplateFolderButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openTemplateFolderButton.Location = new Point(280, 7);
            openTemplateFolderButton.Margin = new Padding(4, 6, 4, 6);
            openTemplateFolderButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openTemplateFolderButton.Name = "openTemplateFolderButton";
            openTemplateFolderButton.NoAccentTextColor = Color.Empty;
            openTemplateFolderButton.Size = new Size(153, 36);
            openTemplateFolderButton.TabIndex = 1;
            openTemplateFolderButton.Text = "Template Folder";
            openTemplateFolderButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openTemplateFolderButton.UseAccentColor = false;
            openTemplateFolderButton.UseVisualStyleBackColor = true;
            openTemplateFolderButton.Click += openTemplateFolderButton_Click;
            // 
            // loadTemplateButton
            // 
            loadTemplateButton.Anchor = AnchorStyles.Left;
            loadTemplateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadTemplateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadTemplateButton.Depth = 0;
            loadTemplateButton.HighEmphasis = true;
            loadTemplateButton.Icon = null;
            loadTemplateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loadTemplateButton.Location = new Point(4, 7);
            loadTemplateButton.Margin = new Padding(4, 6, 4, 6);
            loadTemplateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loadTemplateButton.Name = "loadTemplateButton";
            loadTemplateButton.NoAccentTextColor = Color.Empty;
            loadTemplateButton.Size = new Size(137, 36);
            loadTemplateButton.TabIndex = 0;
            loadTemplateButton.Text = "Load Template";
            loadTemplateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loadTemplateButton.UseAccentColor = false;
            loadTemplateButton.UseVisualStyleBackColor = true;
            loadTemplateButton.Click += loadTemplateButton_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(tableLayoutPanel1);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Right;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(1324, 24);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(471, 898);
            materialCard2.TabIndex = 2;
            materialCard2.Click += materialCard2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialLabel6, 1, 4);
            tableLayoutPanel1.Controls.Add(materialLabel5, 1, 3);
            tableLayoutPanel1.Controls.Add(materialLabel4, 1, 2);
            tableLayoutPanel1.Controls.Add(loadTemplateButton, 0, 0);
            tableLayoutPanel1.Controls.Add(openTemplateFolderButton, 1, 0);
            tableLayoutPanel1.Controls.Add(useShadowsToggle, 0, 1);
            tableLayoutPanel1.Controls.Add(scaleToggle, 0, 2);
            tableLayoutPanel1.Controls.Add(optimizeToggle, 0, 3);
            tableLayoutPanel1.Controls.Add(backgroundToggle, 0, 4);
            tableLayoutPanel1.Controls.Add(materialLabel3, 1, 1);
            tableLayoutPanel1.Location = new Point(17, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(437, 828);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Click += tableLayoutPanel1_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Right;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(299, 215);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(135, 19);
            materialLabel6.TabIndex = 9;
            materialLabel6.Text = "Recommended: On";
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Right;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(299, 165);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(135, 19);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Recommended: On";
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Right;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(299, 115);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(135, 19);
            materialLabel4.TabIndex = 7;
            materialLabel4.Text = "Recommended: On";
            // 
            // useShadowsToggle
            // 
            useShadowsToggle.Anchor = AnchorStyles.Left;
            useShadowsToggle.AutoSize = true;
            useShadowsToggle.Depth = 0;
            useShadowsToggle.Location = new Point(0, 56);
            useShadowsToggle.Margin = new Padding(0);
            useShadowsToggle.MouseLocation = new Point(-1, -1);
            useShadowsToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            useShadowsToggle.Name = "useShadowsToggle";
            useShadowsToggle.Ripple = true;
            useShadowsToggle.Size = new Size(124, 37);
            useShadowsToggle.TabIndex = 2;
            useShadowsToggle.Text = "Shadows";
            useShadowsToggle.UseAccentColor = false;
            useShadowsToggle.UseVisualStyleBackColor = true;
            // 
            // scaleToggle
            // 
            scaleToggle.Anchor = AnchorStyles.Left;
            scaleToggle.AutoSize = true;
            scaleToggle.Checked = true;
            scaleToggle.CheckState = CheckState.Indeterminate;
            scaleToggle.Depth = 0;
            scaleToggle.Location = new Point(0, 106);
            scaleToggle.Margin = new Padding(0);
            scaleToggle.MouseLocation = new Point(-1, -1);
            scaleToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            scaleToggle.Name = "scaleToggle";
            scaleToggle.Ripple = true;
            scaleToggle.Size = new Size(137, 37);
            scaleToggle.TabIndex = 3;
            scaleToggle.Text = "Scale to Fit";
            scaleToggle.UseAccentColor = false;
            scaleToggle.UseVisualStyleBackColor = true;
            // 
            // optimizeToggle
            // 
            optimizeToggle.Anchor = AnchorStyles.Left;
            optimizeToggle.AutoSize = true;
            optimizeToggle.Checked = true;
            optimizeToggle.CheckState = CheckState.Indeterminate;
            optimizeToggle.Depth = 0;
            optimizeToggle.Location = new Point(0, 156);
            optimizeToggle.Margin = new Padding(0);
            optimizeToggle.MouseLocation = new Point(-1, -1);
            optimizeToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            optimizeToggle.Name = "optimizeToggle";
            optimizeToggle.Ripple = true;
            optimizeToggle.Size = new Size(169, 37);
            optimizeToggle.TabIndex = 4;
            optimizeToggle.Text = "Optimize HTML";
            optimizeToggle.UseAccentColor = false;
            optimizeToggle.UseVisualStyleBackColor = true;
            // 
            // backgroundToggle
            // 
            backgroundToggle.Anchor = AnchorStyles.Left;
            backgroundToggle.AutoSize = true;
            backgroundToggle.Checked = true;
            backgroundToggle.CheckState = CheckState.Checked;
            backgroundToggle.Depth = 0;
            backgroundToggle.Location = new Point(0, 206);
            backgroundToggle.Margin = new Padding(0);
            backgroundToggle.MouseLocation = new Point(-1, -1);
            backgroundToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            backgroundToggle.Name = "backgroundToggle";
            backgroundToggle.Ripple = true;
            backgroundToggle.Size = new Size(162, 37);
            backgroundToggle.TabIndex = 5;
            backgroundToggle.Text = "Colormatching";
            backgroundToggle.UseAccentColor = false;
            backgroundToggle.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(296, 65);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(138, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Recommended: Off";
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(437, 23);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Customization";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialSlider1
            // 
            materialSlider1.Depth = 0;
            materialSlider1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider1.Location = new Point(221, 3);
            materialSlider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.RangeMax = 5;
            materialSlider1.RangeMin = 1;
            materialSlider1.Size = new Size(213, 40);
            materialSlider1.StepChange = 1;
            materialSlider1.TabIndex = 10;
            materialSlider1.Text = "AI Paragraphs";
            materialSlider1.Value = 3;
            materialSlider1.ValueMax = 5;
            // 
            // ResumeWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1798, 925);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            materialCard2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 resumeViewer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialButton openTemplateFolderButton;
        private ReaLTaiizor.Controls.MaterialButton loadTemplateButton;
        private ReaLTaiizor.Controls.MaterialButton exportPdfButton;
        private ReaLTaiizor.Controls.MaterialButton exportHtmlButton;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialSwitch useShadowsToggle;
        private ReaLTaiizor.Controls.MaterialSwitch scaleToggle;
        private ReaLTaiizor.Controls.MaterialSwitch optimizeToggle;
        private ReaLTaiizor.Controls.MaterialSwitch backgroundToggle;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialSlider materialSlider1;
    }
}