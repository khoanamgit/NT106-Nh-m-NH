namespace Bai_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnSources = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(113, 32);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(589, 27);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://www.google.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(724, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(782, 31);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(49, 29);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(837, 32);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 29);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(937, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 29);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlWeb
            // 
            this.pnlWeb.Location = new System.Drawing.Point(12, 115);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(1247, 598);
            this.pnlWeb.TabIndex = 6;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1037, 32);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(106, 29);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "DownHTML";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnSources
            // 
            this.btnSources.Location = new System.Drawing.Point(1149, 31);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(94, 29);
            this.btnSources.TabIndex = 8;
            this.btnSources.Text = "Sources";
            this.btnSources.UseVisualStyleBackColor = true;
            this.btnSources.Click += new System.EventHandler(this.btnSources_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(113, 68);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(589, 27);
            this.txtSave.TabIndex = 9;
            this.txtSave.Text = "E:\\out.html";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "SaveUrl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnSources);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.pnlWeb);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrl;
        private Label label1;
        private Button btnBack;
        private Button btnForward;
        private Button btnGo;
        private Button btnHome;
        private Panel pnlWeb;
        private Button btnDown;
        private Button btnSources;
        private TextBox txtSave;
        private Label label2;
    }
}