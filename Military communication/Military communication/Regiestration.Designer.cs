namespace Military_communication
{
    partial class frmRegiestration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegiestration));
            this.grpbxReg = new System.Windows.Forms.GroupBox();
            this.btnCncel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbRanks = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserame = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picRegister = new System.Windows.Forms.PictureBox();
            this.grpbxReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxReg
            // 
            this.grpbxReg.Controls.Add(this.btnCncel);
            this.grpbxReg.Controls.Add(this.btnInsert);
            this.grpbxReg.Controls.Add(this.cbRanks);
            this.grpbxReg.Controls.Add(this.txtPassword);
            this.grpbxReg.Controls.Add(this.txtUsername);
            this.grpbxReg.Controls.Add(this.txtIDNumber);
            this.grpbxReg.Controls.Add(this.txtAge);
            this.grpbxReg.Controls.Add(this.txtSurname);
            this.grpbxReg.Controls.Add(this.txtName);
            this.grpbxReg.Controls.Add(this.lblPassword);
            this.grpbxReg.Controls.Add(this.lblUserame);
            this.grpbxReg.Controls.Add(this.lblIDNumber);
            this.grpbxReg.Controls.Add(this.lblRank);
            this.grpbxReg.Controls.Add(this.lblAge);
            this.grpbxReg.Controls.Add(this.lblSurname);
            this.grpbxReg.Controls.Add(this.lblName);
            this.grpbxReg.Controls.Add(this.picRegister);
            this.grpbxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxReg.Location = new System.Drawing.Point(1, 1);
            this.grpbxReg.Name = "grpbxReg";
            this.grpbxReg.Size = new System.Drawing.Size(572, 447);
            this.grpbxReg.TabIndex = 14;
            this.grpbxReg.TabStop = false;
            this.grpbxReg.Text = "Registration";
            // 
            // btnCncel
            // 
            this.btnCncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncel.Location = new System.Drawing.Point(303, 357);
            this.btnCncel.Name = "btnCncel";
            this.btnCncel.Size = new System.Drawing.Size(120, 36);
            this.btnCncel.TabIndex = 16;
            this.btnCncel.Text = "Cancel.";
            this.btnCncel.UseVisualStyleBackColor = true;
            this.btnCncel.Click += new System.EventHandler(this.btnCncel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(158, 357);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 36);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Register.";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // cbRanks
            // 
            this.cbRanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRanks.FormattingEnabled = true;
            this.cbRanks.Items.AddRange(new object[] {
            "Admin",
            "User\t"});
            this.cbRanks.Location = new System.Drawing.Point(158, 163);
            this.cbRanks.Name = "cbRanks";
            this.cbRanks.Size = new System.Drawing.Size(265, 32);
            this.cbRanks.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(158, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 29);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(158, 251);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 29);
            this.txtUsername.TabIndex = 12;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.Location = new System.Drawing.Point(158, 209);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(265, 29);
            this.txtIDNumber.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(158, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(265, 29);
            this.txtAge.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(158, 81);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(265, 29);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(158, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 29);
            this.txtName.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 299);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserame
            // 
            this.lblUserame.AutoSize = true;
            this.lblUserame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserame.Location = new System.Drawing.Point(3, 256);
            this.lblUserame.Name = "lblUserame";
            this.lblUserame.Size = new System.Drawing.Size(102, 24);
            this.lblUserame.TabIndex = 5;
            this.lblUserame.Text = "Username:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(3, 214);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(106, 24);
            this.lblIDNumber.TabIndex = 4;
            this.lblIDNumber.Text = "ID Number:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(6, 171);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(58, 24);
            this.lblRank.TabIndex = 3;
            this.lblRank.Text = "Rank:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 126);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 24);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(6, 86);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 24);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // picRegister
            // 
            this.picRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRegister.BackgroundImage")));
            this.picRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRegister.Location = new System.Drawing.Point(-22, -15);
            this.picRegister.Name = "picRegister";
            this.picRegister.Size = new System.Drawing.Size(493, 462);
            this.picRegister.TabIndex = 17;
            this.picRegister.TabStop = false;
            // 
            // frmRegiestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.grpbxReg);
            this.Name = "frmRegiestration";
            this.Text = "Regiestration.";
            this.grpbxReg.ResumeLayout(false);
            this.grpbxReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxReg;
        private System.Windows.Forms.Button btnCncel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbRanks;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserame;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picRegister;
    }
}