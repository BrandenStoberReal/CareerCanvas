namespace CareerCanvas.Forms.Workspaces
{
    partial class CoverLetterWorkspace
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
            cvWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            changeTemplateButton = new ReaLTaiizor.Controls.MaterialButton();
            editInfoButton = new ReaLTaiizor.Controls.MaterialButton();
            exportToPdfButton = new ReaLTaiizor.Controls.MaterialButton();
            exportToHtmlButton = new ReaLTaiizor.Controls.MaterialButton();
            useShadowsToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            optimizeToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            scaleToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            backgroundToggle = new ReaLTaiizor.Controls.MaterialSwitch();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)cvWebView).BeginInit();
            materialCard1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cvWebView
            // 
            cvWebView.AllowExternalDrop = true;
            cvWebView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cvWebView.CreationProperties = null;
            cvWebView.DefaultBackgroundColor = Color.White;
            cvWebView.Location = new Point(6, 27);
            cvWebView.Name = "cvWebView";
            cvWebView.Size = new Size(747, 962);
            cvWebView.TabIndex = 0;
            cvWebView.ZoomFactor = 1D;
            cvWebView.CoreWebView2InitializationCompleted += cvWebView_CoreWebView2InitializationCompleted;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(770, 38);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(585, 940);
            materialCard1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(changeTemplateButton, 0, 0);
            tableLayoutPanel1.Controls.Add(editInfoButton, 1, 0);
            tableLayoutPanel1.Controls.Add(exportToPdfButton, 1, 1);
            tableLayoutPanel1.Controls.Add(exportToHtmlButton, 1, 2);
            tableLayoutPanel1.Controls.Add(useShadowsToggle, 0, 3);
            tableLayoutPanel1.Controls.Add(optimizeToggle, 0, 4);
            tableLayoutPanel1.Controls.Add(scaleToggle, 0, 5);
            tableLayoutPanel1.Controls.Add(backgroundToggle, 0, 6);
            tableLayoutPanel1.Controls.Add(materialLabel3, 1, 3);
            tableLayoutPanel1.Controls.Add(materialLabel5, 1, 4);
            tableLayoutPanel1.Controls.Add(materialLabel4, 1, 5);
            tableLayoutPanel1.Controls.Add(materialLabel6, 1, 6);
            tableLayoutPanel1.Location = new Point(17, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.Size = new Size(551, 906);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // changeTemplateButton
            // 
            changeTemplateButton.Anchor = AnchorStyles.Left;
            changeTemplateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            changeTemplateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            changeTemplateButton.Depth = 0;
            changeTemplateButton.HighEmphasis = true;
            changeTemplateButton.Icon = null;
            changeTemplateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            changeTemplateButton.Location = new Point(4, 14);
            changeTemplateButton.Margin = new Padding(4, 6, 4, 6);
            changeTemplateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            changeTemplateButton.Name = "changeTemplateButton";
            changeTemplateButton.NoAccentTextColor = Color.Empty;
            changeTemplateButton.Size = new Size(159, 36);
            changeTemplateButton.TabIndex = 1;
            changeTemplateButton.Text = "Change Template";
            changeTemplateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            changeTemplateButton.UseAccentColor = false;
            changeTemplateButton.UseVisualStyleBackColor = true;
            changeTemplateButton.Click += changeTemplateButton_Click;
            // 
            // editInfoButton
            // 
            editInfoButton.Anchor = AnchorStyles.Right;
            editInfoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editInfoButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            editInfoButton.Depth = 0;
            editInfoButton.HighEmphasis = true;
            editInfoButton.Icon = null;
            editInfoButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            editInfoButton.Location = new Point(392, 14);
            editInfoButton.Margin = new Padding(4, 6, 4, 6);
            editInfoButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            editInfoButton.Name = "editInfoButton";
            editInfoButton.NoAccentTextColor = Color.Empty;
            editInfoButton.Size = new Size(155, 36);
            editInfoButton.TabIndex = 0;
            editInfoButton.Text = "Edit Information";
            editInfoButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            editInfoButton.UseAccentColor = false;
            editInfoButton.UseVisualStyleBackColor = true;
            editInfoButton.Click += editInfoButton_Click;
            // 
            // exportToPdfButton
            // 
            exportToPdfButton.Anchor = AnchorStyles.Right;
            exportToPdfButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportToPdfButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportToPdfButton.Depth = 0;
            exportToPdfButton.HighEmphasis = true;
            exportToPdfButton.Icon = null;
            exportToPdfButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            exportToPdfButton.Location = new Point(417, 78);
            exportToPdfButton.Margin = new Padding(4, 6, 4, 6);
            exportToPdfButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exportToPdfButton.Name = "exportToPdfButton";
            exportToPdfButton.NoAccentTextColor = Color.Empty;
            exportToPdfButton.Size = new Size(130, 36);
            exportToPdfButton.TabIndex = 14;
            exportToPdfButton.Text = "Export to PDF";
            exportToPdfButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            exportToPdfButton.UseAccentColor = false;
            exportToPdfButton.UseVisualStyleBackColor = true;
            exportToPdfButton.Click += exportToPdfButton_Click;
            // 
            // exportToHtmlButton
            // 
            exportToHtmlButton.Anchor = AnchorStyles.Right;
            exportToHtmlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportToHtmlButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportToHtmlButton.Depth = 0;
            exportToHtmlButton.HighEmphasis = true;
            exportToHtmlButton.Icon = null;
            exportToHtmlButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            exportToHtmlButton.Location = new Point(404, 142);
            exportToHtmlButton.Margin = new Padding(4, 6, 4, 6);
            exportToHtmlButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            exportToHtmlButton.Name = "exportToHtmlButton";
            exportToHtmlButton.NoAccentTextColor = Color.Empty;
            exportToHtmlButton.Size = new Size(143, 36);
            exportToHtmlButton.TabIndex = 15;
            exportToHtmlButton.Text = "Export to HTML";
            exportToHtmlButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            exportToHtmlButton.UseAccentColor = false;
            exportToHtmlButton.UseVisualStyleBackColor = true;
            exportToHtmlButton.Click += exportToHtmlButton_Click;
            // 
            // useShadowsToggle
            // 
            useShadowsToggle.Anchor = AnchorStyles.Left;
            useShadowsToggle.AutoSize = true;
            useShadowsToggle.Depth = 0;
            useShadowsToggle.Location = new Point(0, 205);
            useShadowsToggle.Margin = new Padding(0);
            useShadowsToggle.MouseLocation = new Point(-1, -1);
            useShadowsToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            useShadowsToggle.Name = "useShadowsToggle";
            useShadowsToggle.Ripple = true;
            useShadowsToggle.Size = new Size(124, 37);
            useShadowsToggle.TabIndex = 6;
            useShadowsToggle.Text = "Shadows";
            useShadowsToggle.UseAccentColor = false;
            useShadowsToggle.UseVisualStyleBackColor = true;
            // 
            // optimizeToggle
            // 
            optimizeToggle.Anchor = AnchorStyles.Left;
            optimizeToggle.AutoSize = true;
            optimizeToggle.Depth = 0;
            optimizeToggle.Location = new Point(0, 269);
            optimizeToggle.Margin = new Padding(0);
            optimizeToggle.MouseLocation = new Point(-1, -1);
            optimizeToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            optimizeToggle.Name = "optimizeToggle";
            optimizeToggle.Ripple = true;
            optimizeToggle.Size = new Size(169, 37);
            optimizeToggle.TabIndex = 8;
            optimizeToggle.Text = "Optimize HTML";
            optimizeToggle.UseAccentColor = false;
            optimizeToggle.UseVisualStyleBackColor = true;
            // 
            // scaleToggle
            // 
            scaleToggle.Anchor = AnchorStyles.Left;
            scaleToggle.AutoSize = true;
            scaleToggle.Checked = true;
            scaleToggle.CheckState = CheckState.Indeterminate;
            scaleToggle.Depth = 0;
            scaleToggle.Location = new Point(0, 333);
            scaleToggle.Margin = new Padding(0);
            scaleToggle.MouseLocation = new Point(-1, -1);
            scaleToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            scaleToggle.Name = "scaleToggle";
            scaleToggle.Ripple = true;
            scaleToggle.Size = new Size(137, 37);
            scaleToggle.TabIndex = 7;
            scaleToggle.Text = "Scale to Fit";
            scaleToggle.UseAccentColor = false;
            scaleToggle.UseVisualStyleBackColor = true;
            // 
            // backgroundToggle
            // 
            backgroundToggle.Anchor = AnchorStyles.Left;
            backgroundToggle.AutoSize = true;
            backgroundToggle.Checked = true;
            backgroundToggle.CheckState = CheckState.Checked;
            backgroundToggle.Depth = 0;
            backgroundToggle.Location = new Point(0, 397);
            backgroundToggle.Margin = new Padding(0);
            backgroundToggle.MouseLocation = new Point(-1, -1);
            backgroundToggle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            backgroundToggle.Name = "backgroundToggle";
            backgroundToggle.Ripple = true;
            backgroundToggle.Size = new Size(162, 37);
            backgroundToggle.TabIndex = 9;
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
            materialLabel3.Location = new Point(410, 214);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(138, 19);
            materialLabel3.TabIndex = 10;
            materialLabel3.Text = "Recommended: Off";
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Right;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(410, 278);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(138, 19);
            materialLabel5.TabIndex = 12;
            materialLabel5.Text = "Recommended: Off";
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Right;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(413, 342);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(135, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Recommended: On";
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Right;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(413, 406);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(135, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Recommended: On";
            // 
            // CoverLetterWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 995);
            Controls.Add(materialCard1);
            Controls.Add(cvWebView);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "CoverLetterWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Cover Letter Workspace";
            Load += CoverLetterWorkspace_Load;
            ((System.ComponentModel.ISupportInitialize)cvWebView).EndInit();
            materialCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 cvWebView;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MaterialButton editInfoButton;
        private ReaLTaiizor.Controls.MaterialButton changeTemplateButton;
        private ReaLTaiizor.Controls.MaterialSwitch useShadowsToggle;
        private ReaLTaiizor.Controls.MaterialSwitch optimizeToggle;
        private ReaLTaiizor.Controls.MaterialSwitch scaleToggle;
        private ReaLTaiizor.Controls.MaterialSwitch backgroundToggle;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialButton exportToPdfButton;
        private ReaLTaiizor.Controls.MaterialButton exportToHtmlButton;
    }
}