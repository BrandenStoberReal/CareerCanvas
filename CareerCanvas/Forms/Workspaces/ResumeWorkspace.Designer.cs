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
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            flowLayoutPanel2 = new FlowLayoutPanel();
            changeTemplateButton = new ReaLTaiizor.Controls.MaterialButton();
            addSectionButton = new ReaLTaiizor.Controls.MaterialButton();
            removeSectionButton = new ReaLTaiizor.Controls.MaterialButton();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)resumeViewer).BeginInit();
            materialCard1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            materialCard2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // resumeViewer
            // 
            resumeViewer.AllowExternalDrop = true;
            resumeViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resumeViewer.CreationProperties = null;
            resumeViewer.DefaultBackgroundColor = Color.White;
            resumeViewer.Location = new Point(493, 27);
            resumeViewer.Name = "resumeViewer";
            resumeViewer.Size = new Size(812, 892);
            resumeViewer.TabIndex = 0;
            resumeViewer.ZoomFactor = 1D;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(flowLayoutPanel3);
            materialCard1.Controls.Add(flowLayoutPanel1);
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(addSectionButton);
            flowLayoutPanel1.Controls.Add(removeSectionButton);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(14, 14);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(180, 870);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(flowLayoutPanel4);
            materialCard2.Controls.Add(flowLayoutPanel2);
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
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(changeTemplateButton);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(266, 14);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(179, 870);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // changeTemplateButton
            // 
            changeTemplateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            changeTemplateButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            changeTemplateButton.Depth = 0;
            changeTemplateButton.HighEmphasis = true;
            changeTemplateButton.Icon = null;
            changeTemplateButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            changeTemplateButton.Location = new Point(16, 6);
            changeTemplateButton.Margin = new Padding(4, 6, 4, 6);
            changeTemplateButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            changeTemplateButton.Name = "changeTemplateButton";
            changeTemplateButton.NoAccentTextColor = Color.Empty;
            changeTemplateButton.Size = new Size(159, 36);
            changeTemplateButton.TabIndex = 0;
            changeTemplateButton.Text = "Change Template";
            changeTemplateButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            changeTemplateButton.UseAccentColor = false;
            changeTemplateButton.UseVisualStyleBackColor = true;
            // 
            // addSectionButton
            // 
            addSectionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addSectionButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            addSectionButton.Depth = 0;
            addSectionButton.HighEmphasis = true;
            addSectionButton.Icon = null;
            addSectionButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            addSectionButton.Location = new Point(4, 6);
            addSectionButton.Margin = new Padding(4, 6, 4, 6);
            addSectionButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            addSectionButton.Name = "addSectionButton";
            addSectionButton.NoAccentTextColor = Color.Empty;
            addSectionButton.Size = new Size(115, 36);
            addSectionButton.TabIndex = 0;
            addSectionButton.Text = "Add Section";
            addSectionButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            addSectionButton.UseAccentColor = false;
            addSectionButton.UseVisualStyleBackColor = true;
            // 
            // removeSectionButton
            // 
            removeSectionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeSectionButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeSectionButton.Depth = 0;
            removeSectionButton.HighEmphasis = true;
            removeSectionButton.Icon = null;
            removeSectionButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            removeSectionButton.Location = new Point(4, 54);
            removeSectionButton.Margin = new Padding(4, 6, 4, 6);
            removeSectionButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            removeSectionButton.Name = "removeSectionButton";
            removeSectionButton.NoAccentTextColor = Color.Empty;
            removeSectionButton.Size = new Size(144, 36);
            removeSectionButton.TabIndex = 1;
            removeSectionButton.Text = "Remove Section";
            removeSectionButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            removeSectionButton.UseAccentColor = false;
            removeSectionButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Dock = DockStyle.Right;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(245, 14);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(200, 870);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Dock = DockStyle.Left;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(14, 14);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(200, 870);
            flowLayoutPanel4.TabIndex = 1;
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 resumeViewer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton changeTemplateButton;
        private ReaLTaiizor.Controls.MaterialButton addSectionButton;
        private ReaLTaiizor.Controls.MaterialButton removeSectionButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
    }
}