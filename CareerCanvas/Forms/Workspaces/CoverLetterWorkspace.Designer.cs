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
            ((System.ComponentModel.ISupportInitialize)cvWebView).BeginInit();
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
            // CoverLetterWorkspace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 995);
            Controls.Add(cvWebView);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "CoverLetterWorkspace";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Cover Letter Workspace";
            Load += CoverLetterWorkspace_Load;
            ((System.ComponentModel.ISupportInitialize)cvWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 cvWebView;
    }
}