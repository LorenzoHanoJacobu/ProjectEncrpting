namespace Military_communication
{
    partial class frmMessageBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBoard));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShowEncryptmessage = new System.Windows.Forms.Button();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lsDecrypted = new System.Windows.Forms.ListBox();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.lblMsgbrd = new System.Windows.Forms.Label();
            this.btnEncryprt = new System.Windows.Forms.Button();
            this.lstbxMsgs = new System.Windows.Forms.ListBox();
            this.picMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(344, 449);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 49);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShowEncryptmessage
            // 
            this.btnShowEncryptmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEncryptmessage.Location = new System.Drawing.Point(32, 449);
            this.btnShowEncryptmessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEncryptmessage.Name = "btnShowEncryptmessage";
            this.btnShowEncryptmessage.Size = new System.Drawing.Size(304, 49);
            this.btnShowEncryptmessage.TabIndex = 16;
            this.btnShowEncryptmessage.Text = "Decrypt message.";
            this.btnShowEncryptmessage.UseVisualStyleBackColor = true;
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypted.Location = new System.Drawing.Point(541, 78);
            this.lblDecrypted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(192, 24);
            this.lblDecrypted.TabIndex = 15;
            this.lblDecrypted.Text = "Decrypted messages.";
            // 
            // lsDecrypted
            // 
            this.lsDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsDecrypted.FormattingEnabled = true;
            this.lsDecrypted.ItemHeight = 16;
            this.lsDecrypted.Location = new System.Drawing.Point(545, 117);
            this.lsDecrypted.Margin = new System.Windows.Forms.Padding(4);
            this.lsDecrypted.Name = "lsDecrypted";
            this.lsDecrypted.Size = new System.Drawing.Size(304, 324);
            this.lsDecrypted.TabIndex = 14;
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypted.Location = new System.Drawing.Point(28, 78);
            this.lblEncrypted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(192, 24);
            this.lblEncrypted.TabIndex = 13;
            this.lblEncrypted.Text = "Encrypted messages.";
            // 
            // lblMsgbrd
            // 
            this.lblMsgbrd.AutoSize = true;
            this.lblMsgbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgbrd.Location = new System.Drawing.Point(127, 8);
            this.lblMsgbrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgbrd.Name = "lblMsgbrd";
            this.lblMsgbrd.Size = new System.Drawing.Size(362, 55);
            this.lblMsgbrd.TabIndex = 12;
            this.lblMsgbrd.Text = "Message Board";
            // 
            // btnEncryprt
            // 
            this.btnEncryprt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryprt.Location = new System.Drawing.Point(545, 449);
            this.btnEncryprt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryprt.Name = "btnEncryprt";
            this.btnEncryprt.Size = new System.Drawing.Size(304, 49);
            this.btnEncryprt.TabIndex = 11;
            this.btnEncryprt.Text = "Encrypt message.";
            this.btnEncryprt.UseVisualStyleBackColor = true;
            // 
            // lstbxMsgs
            // 
            this.lstbxMsgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxMsgs.FormattingEnabled = true;
            this.lstbxMsgs.ItemHeight = 16;
            this.lstbxMsgs.Location = new System.Drawing.Point(32, 117);
            this.lstbxMsgs.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxMsgs.Name = "lstbxMsgs";
            this.lstbxMsgs.Size = new System.Drawing.Size(304, 324);
            this.lstbxMsgs.TabIndex = 10;
            // 
            // picMessage
            // 
            this.picMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMessage.BackgroundImage")));
            this.picMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMessage.Location = new System.Drawing.Point(2, -21);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(874, 547);
            this.picMessage.TabIndex = 17;
            this.picMessage.TabStop = false;
            // 
            // frmMessageBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowEncryptmessage);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lsDecrypted);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.lblMsgbrd);
            this.Controls.Add(this.btnEncryprt);
            this.Controls.Add(this.lstbxMsgs);
            this.Controls.Add(this.picMessage);
            this.Name = "frmMessageBoard";
            this.Text = "Message Board.";
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowEncryptmessage;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.ListBox lsDecrypted;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.Label lblMsgbrd;
        private System.Windows.Forms.Button btnEncryprt;
        private System.Windows.Forms.ListBox lstbxMsgs;
        private System.Windows.Forms.PictureBox picMessage;
    }
}