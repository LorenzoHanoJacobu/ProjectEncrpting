namespace Military_communication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtbxPsswrd = new System.Windows.Forms.TextBox();
            this.txtbxUsrnm = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLgin = new System.Windows.Forms.Button();
            this.lblpsswrd = new System.Windows.Forms.Label();
            this.lblUsrNm = new System.Windows.Forms.Label();
            this.lblwlcm = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxPsswrd
            // 
            this.txtbxPsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPsswrd.Location = new System.Drawing.Point(140, 145);
            this.txtbxPsswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPsswrd.Name = "txtbxPsswrd";
            this.txtbxPsswrd.Size = new System.Drawing.Size(274, 29);
            this.txtbxPsswrd.TabIndex = 14;
            // 
            // txtbxUsrnm
            // 
            this.txtbxUsrnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsrnm.Location = new System.Drawing.Point(140, 82);
            this.txtbxUsrnm.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxUsrnm.Name = "txtbxUsrnm";
            this.txtbxUsrnm.Size = new System.Drawing.Size(274, 29);
            this.txtbxUsrnm.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(285, 196);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 36);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLgin
            // 
            this.btnLgin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgin.Location = new System.Drawing.Point(140, 196);
            this.btnLgin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLgin.Name = "btnLgin";
            this.btnLgin.Size = new System.Drawing.Size(129, 36);
            this.btnLgin.TabIndex = 11;
            this.btnLgin.Text = "Login";
            this.btnLgin.UseVisualStyleBackColor = true;
            // 
            // lblpsswrd
            // 
            this.lblpsswrd.AutoSize = true;
            this.lblpsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpsswrd.Location = new System.Drawing.Point(10, 150);
            this.lblpsswrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpsswrd.Name = "lblpsswrd";
            this.lblpsswrd.Size = new System.Drawing.Size(97, 24);
            this.lblpsswrd.TabIndex = 10;
            this.lblpsswrd.Text = "Password:";
            // 
            // lblUsrNm
            // 
            this.lblUsrNm.AutoSize = true;
            this.lblUsrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrNm.Location = new System.Drawing.Point(10, 85);
            this.lblUsrNm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrNm.Name = "lblUsrNm";
            this.lblUsrNm.Size = new System.Drawing.Size(102, 24);
            this.lblUsrNm.TabIndex = 9;
            this.lblUsrNm.Text = "Username:";
            // 
            // lblwlcm
            // 
            this.lblwlcm.AutoSize = true;
            this.lblwlcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwlcm.Location = new System.Drawing.Point(184, 33);
            this.lblwlcm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwlcm.Name = "lblwlcm";
            this.lblwlcm.Size = new System.Drawing.Size(113, 24);
            this.lblwlcm.TabIndex = 8;
            this.lblwlcm.Text = "WELCOME ";
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogin.BackgroundImage")));
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(-1, -2);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(463, 279);
            this.picLogin.TabIndex = 15;
            this.picLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 277);
            this.Controls.Add(this.txtbxPsswrd);
            this.Controls.Add(this.txtbxUsrnm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLgin);
            this.Controls.Add(this.lblpsswrd);
            this.Controls.Add(this.lblUsrNm);
            this.Controls.Add(this.lblwlcm);
            this.Controls.Add(this.picLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxPsswrd;
        private System.Windows.Forms.TextBox txtbxUsrnm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLgin;
        private System.Windows.Forms.Label lblpsswrd;
        private System.Windows.Forms.Label lblUsrNm;
        private System.Windows.Forms.Label lblwlcm;
        private System.Windows.Forms.PictureBox picLogin;
    }
}