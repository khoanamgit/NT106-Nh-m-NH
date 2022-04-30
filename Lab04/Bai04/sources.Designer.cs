namespace Bai_4
{
    partial class sources
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
            this.rtxtHtml = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtHtml
            // 
            this.rtxtHtml.Location = new System.Drawing.Point(12, 12);
            this.rtxtHtml.Name = "rtxtHtml";
            this.rtxtHtml.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtHtml.Size = new System.Drawing.Size(1021, 519);
            this.rtxtHtml.TabIndex = 0;
            this.rtxtHtml.Text = "";
            // 
            // sources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 534);
            this.Controls.Add(this.rtxtHtml);
            this.Name = "sources";
            this.Text = "sources";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtxtHtml;
    }
}