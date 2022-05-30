namespace Bai03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtToReceive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToSend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSubjectSend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(121, 23);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(238, 27);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(510, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(125, 27);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "110";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(121, 65);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(238, 27);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "minhhoang@nhomNHH.nt106";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(121, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(125, 27);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "Hoang123456";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(510, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlWeb);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtToReceive);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1016, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 788);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // pnlWeb
            // 
            this.pnlWeb.Location = new System.Drawing.Point(50, 179);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(718, 603);
            this.pnlWeb.TabIndex = 17;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Location = new System.Drawing.Point(90, 26);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(631, 20);
            this.txtSubject.TabIndex = 16;
            // 
            // txtToReceive
            // 
            this.txtToReceive.Location = new System.Drawing.Point(132, 125);
            this.txtToReceive.Name = "txtToReceive";
            this.txtToReceive.Size = new System.Drawing.Size(589, 27);
            this.txtToReceive.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(132, 82);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(589, 27);
            this.txtFrom.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "From";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Subject,
            this.From});
            this.dataGridView.Location = new System.Drawing.Point(9, 486);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(931, 325);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 300;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 300;
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.Width = 300;
            // 
            // txtToSend
            // 
            this.txtToSend.Location = new System.Drawing.Point(510, 68);
            this.txtToSend.Name = "txtToSend";
            this.txtToSend.Size = new System.Drawing.Size(238, 27);
            this.txtToSend.TabIndex = 14;
            this.txtToSend.Text = "khoanam@nhomNHH.nt106";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(755, 445);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSubjectSend
            // 
            this.txtSubjectSend.Location = new System.Drawing.Point(121, 160);
            this.txtSubjectSend.Name = "txtSubjectSend";
            this.txtSubjectSend.Size = new System.Drawing.Size(819, 27);
            this.txtSubjectSend.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Subject:";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(122, 208);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(818, 231);
            this.rtbMessage.TabIndex = 20;
            this.rtbMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 837);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.txtSubjectSend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtPort;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private GroupBox groupBox1;
        private TextBox txtSubject;
        private TextBox txtToReceive;
        private Label label7;
        private TextBox txtFrom;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlWeb;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn From;
        private TextBox txtToSend;
        private Label label5;
        private Label label8;
        private Button btnSend;
        private TextBox txtSubjectSend;
        private Label label9;
        private RichTextBox rtbMessage;
    }
}