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
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)resumeViewer).BeginInit();
            SuspendLayout();
            // 
            // resumeViewer
            // 
            resumeViewer.AllowExternalDrop = true;
            resumeViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom));
            resumeViewer.CreationProperties = null;
            resumeViewer.DefaultBackgroundColor = System.Drawing.Color.White;
            resumeViewer.Location = new System.Drawing.Point(493, -53);
            resumeViewer.Name = "resumeViewer";
            resumeViewer.Size = new System.Drawing.Size(812, 972);
            resumeViewer.TabIndex = 0;
            resumeViewer.ZoomFactor = 1D;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            materialCard1.Depth = 0;
            materialCard1.Dock = System.Windows.Forms.DockStyle.Left;
            materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            materialCard1.Location = new System.Drawing.Point(3, 24);
            materialCard1.Margin = new System.Windows.Forms.Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new System.Windows.Forms.Padding(14);
            materialCard1.Size = new System.Drawing.Size(459, 898);
            materialCard1.TabIndex = 1;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            materialCard2.Depth = 0;
            materialCard2.Dock = System.Windows.Forms.DockStyle.Right;
            materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            materialCard2.Location = new System.Drawing.Point(1336, 24);
            materialCard2.Margin = new System.Windows.Forms.Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new System.Windows.Forms.Padding(14);
            materialCard2.Size = new System.Drawing.Size(459, 898);
            materialCard2.TabIndex = 2;
            // 
            // ResumeWorkspace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1798, 925);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(resumeViewer);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Resume Workspace";
            Load += ResumeWorkspace_Load;
            ((System.ComponentModel.ISupportInitialize)resumeViewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 resumeViewer;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
    }
}