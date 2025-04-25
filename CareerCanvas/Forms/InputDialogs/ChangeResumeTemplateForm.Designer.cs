namespace CareerCanvas.Forms.InputDialogs
{
    partial class ChangeResumeTemplateForm
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            templateListBox = new ReaLTaiizor.Controls.MaterialListBox();
            previewWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            saveChangeButton = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewWebView).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(templateListBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 81);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(200, 877);
            materialCard1.TabIndex = 0;
            materialCard1.Click += materialCard1_Click;
            // 
            // templateListBox
            // 
            templateListBox.BackColor = Color.White;
            templateListBox.BorderColor = Color.LightGray;
            templateListBox.Depth = 0;
            templateListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            templateListBox.Location = new Point(17, 17);
            templateListBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            templateListBox.Name = "templateListBox";
            templateListBox.SelectedIndex = -1;
            templateListBox.SelectedItem = null;
            templateListBox.Size = new Size(166, 843);
            templateListBox.TabIndex = 0;
            templateListBox.SelectedIndexChanged += templateListBox_SelectedIndexChanged;
            // 
            // previewWebView
            // 
            previewWebView.AllowExternalDrop = true;
            previewWebView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            previewWebView.CreationProperties = null;
            previewWebView.DefaultBackgroundColor = Color.White;
            previewWebView.Location = new Point(245, 38);
            previewWebView.Margin = new Padding(14);
            previewWebView.Name = "previewWebView";
            previewWebView.Size = new Size(892, 920);
            previewWebView.TabIndex = 1;
            previewWebView.ZoomFactor = 1D;
            previewWebView.CoreWebView2InitializationCompleted += previewWebView_CoreWebView2InitializationCompleted;
            // 
            // saveChangeButton
            // 
            saveChangeButton.AutoSize = false;
            saveChangeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveChangeButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveChangeButton.Depth = 0;
            saveChangeButton.HighEmphasis = true;
            saveChangeButton.Icon = null;
            saveChangeButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            saveChangeButton.Location = new Point(17, 38);
            saveChangeButton.Margin = new Padding(4, 6, 4, 6);
            saveChangeButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            saveChangeButton.Name = "saveChangeButton";
            saveChangeButton.NoAccentTextColor = Color.Empty;
            saveChangeButton.Size = new Size(200, 36);
            saveChangeButton.TabIndex = 2;
            saveChangeButton.Text = "Load Selected Template";
            saveChangeButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            saveChangeButton.UseAccentColor = false;
            saveChangeButton.UseVisualStyleBackColor = true;
            saveChangeButton.Click += saveChangeButton_Click;
            // 
            // ChangeResumeTemplateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 975);
            Controls.Add(saveChangeButton);
            Controls.Add(previewWebView);
            Controls.Add(materialCard1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            Name = "ChangeResumeTemplateForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "Change Template";
            Load += ChangeResumeTemplateForm_Load;
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)previewWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialListBox templateListBox;
        private Microsoft.Web.WebView2.WinForms.WebView2 previewWebView;
        private ReaLTaiizor.Controls.MaterialButton saveChangeButton;
    }
}