namespace Lab_2
{
    partial class Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLInput = new System.Windows.Forms.Button();
            this.btnLOutput = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(120, 44);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(359, 220);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.Text = "1234567, NguyenVanA, 1234567890, 7.0, 6.0\r\n1234568, NguyenVanB, 1234567891, 8.0, " +
    "8.0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(597, 44);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(359, 220);
            this.txtInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Input";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(1137, 47);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(359, 220);
            this.txtOutput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1059, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flie Output";
            // 
            // btnLInput
            // 
            this.btnLInput.Location = new System.Drawing.Point(519, 290);
            this.btnLInput.Name = "btnLInput";
            this.btnLInput.Size = new System.Drawing.Size(94, 29);
            this.btnLInput.TabIndex = 7;
            this.btnLInput.Text = "Load Input";
            this.btnLInput.UseVisualStyleBackColor = true;
            this.btnLInput.Click += new System.EventHandler(this.btnLInput_Click);
            // 
            // btnLOutput
            // 
            this.btnLOutput.Location = new System.Drawing.Point(1059, 299);
            this.btnLOutput.Name = "btnLOutput";
            this.btnLOutput.Size = new System.Drawing.Size(94, 29);
            this.btnLOutput.TabIndex = 8;
            this.btnLOutput.Text = "Load Output";
            this.btnLOutput.UseVisualStyleBackColor = true;
            this.btnLOutput.Click += new System.EventHandler(this.btnLOutput_Click);
            // 
            // btnTB
            // 
            this.btnTB.Location = new System.Drawing.Point(660, 290);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(122, 29);
            this.btnTB.TabIndex = 9;
            this.btnTB.Text = "Tính TB và Lưu";
            this.btnTB.UseVisualStyleBackColor = true;
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 526);
            this.Controls.Add(this.btnTB);
            this.Controls.Add(this.btnLOutput);
            this.Controls.Add(this.btnLInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private Button btnSave;
        private TextBox txtInput;
        private Label label2;
        private TextBox txtOutput;
        private Label label3;
        private Button btnLInput;
        private Button btnLOutput;
        private Button btnTB;
    }
}