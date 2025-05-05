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
            tableLayoutPanel1.Location = new Point(17, 17);
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
            changeTemplateButton.Location = new Point(4, 7);
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
            editInfoButton.Location = new Point(392, 7);
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
    }
}