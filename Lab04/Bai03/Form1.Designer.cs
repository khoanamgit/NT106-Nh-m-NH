namespace Bai_3
{
    partial class Form1
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.rtxtHtml = new System.Windows.Forms.RichTextBox();
            this.txtFileUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(34, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(686, 27);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://www.uit.edu.vn/";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(768, 33);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(94, 29);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "DownLoad";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // rtxtHtml
            // 
            this.rtxtHtml.Location = new System.Drawing.Point(23, 112);
            this.rtxtHtml.Name = "rtxtHtml";
            this.rtxtHtml.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtxtHtml.Size = new System.Drawing.Size(829, 383);
            this.rtxtHtml.TabIndex = 3;
            this.rtxtHtml.Text = "";
            // 
            // txtFileUrl
            // 
            this.txtFileUrl.Location = new System.Drawing.Point(32, 70);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(688, 27);
            this.txtFileUrl.TabIndex = 4;
            this.txtFileUrl.Text = "D:\\Lập trình mạng căn bản\\TH\\Lab 4\\Bai 3\\file.html";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 518);
            this.Controls.Add(this.txtFileUrl);
            this.Controls.Add(this.rtxtHtml);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrl;
        private Button btnDown;
        private RichTextBox rtxtHtml;
        private TextBox txtFileUrl;
    }
}