namespace MIlitaryCom
{
    partial class frmLogin
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
            this.lblwlcm = new System.Windows.Forms.Label();
            this.lblUsrNm = new System.Windows.Forms.Label();
            this.lblpsswrd = new System.Windows.Forms.Label();
            this.btnLgin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbxUsrnm = new System.Windows.Forms.TextBox();
            this.txtbxPsswrd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwlcm
            // 
            this.lblwlcm.AutoSize = true;
            this.lblwlcm.Location = new System.Drawing.Point(272, 52);
            this.lblwlcm.Name = "lblwlcm";
            this.lblwlcm.Size = new System.Drawing.Size(82, 17);
            this.lblwlcm.TabIndex = 0;
            this.lblwlcm.Text = "WELCOME ";
            // 
            // lblUsrNm
            // 
            this.lblUsrNm.AutoSize = true;
            this.lblUsrNm.Location = new System.Drawing.Point(100, 154);
            this.lblUsrNm.Name = "lblUsrNm";
            this.lblUsrNm.Size = new System.Drawing.Size(73, 17);
            this.lblUsrNm.TabIndex = 1;
            this.lblUsrNm.Text = "Username";
            // 
            // lblpsswrd
            // 
            this.lblpsswrd.AutoSize = true;
            this.lblpsswrd.Location = new System.Drawing.Point(100, 223);
            this.lblpsswrd.Name = "lblpsswrd";
            this.lblpsswrd.Size = new System.Drawing.Size(69, 17);
            this.lblpsswrd.TabIndex = 2;
            this.lblpsswrd.Text = "Password";
            // 
            // btnLgin
            // 
            this.btnLgin.Location = new System.Drawing.Point(188, 330);
            this.btnLgin.Name = "btnLgin";
            this.btnLgin.Size = new System.Drawing.Size(79, 35);
            this.btnLgin.TabIndex = 3;
            this.btnLgin.Text = "Login";
            this.btnLgin.UseVisualStyleBackColor = true;
            this.btnLgin.Click += new System.EventHandler(this.btnLgin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(335, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtbxUsrnm
            // 
            this.txtbxUsrnm.Location = new System.Drawing.Point(252, 149);
            this.txtbxUsrnm.Name = "txtbxUsrnm";
            this.txtbxUsrnm.Size = new System.Drawing.Size(159, 22);
            this.txtbxUsrnm.TabIndex = 5;
            // 
            // txtbxPsswrd
            // 
            this.txtbxPsswrd.Location = new System.Drawing.Point(252, 218);
            this.txtbxPsswrd.Name = "txtbxPsswrd";
            this.txtbxPsswrd.Size = new System.Drawing.Size(159, 22);
            this.txtbxPsswrd.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "adm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "reg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 474);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxPsswrd);
            this.Controls.Add(this.txtbxUsrnm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLgin);
            this.Controls.Add(this.lblpsswrd);
            this.Controls.Add(this.lblUsrNm);
            this.Controls.Add(this.lblwlcm);
            this.Name = "frmLogin";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwlcm;
        private System.Windows.Forms.Label lblUsrNm;
        private System.Windows.Forms.Label lblpsswrd;
        private System.Windows.Forms.Button btnLgin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtbxUsrnm;
        private System.Windows.Forms.TextBox txtbxPsswrd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

