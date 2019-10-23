namespace MIlitaryCom
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
            this.lstbxMsgs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMsgbrd = new System.Windows.Forms.Label();
            this.lblMsgLst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxMsgs
            // 
            this.lstbxMsgs.FormattingEnabled = true;
            this.lstbxMsgs.ItemHeight = 16;
            this.lstbxMsgs.Location = new System.Drawing.Point(801, 105);
            this.lstbxMsgs.Name = "lstbxMsgs";
            this.lstbxMsgs.Size = new System.Drawing.Size(205, 308);
            this.lstbxMsgs.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMsgbrd
            // 
            this.lblMsgbrd.AutoSize = true;
            this.lblMsgbrd.Location = new System.Drawing.Point(411, 25);
            this.lblMsgbrd.Name = "lblMsgbrd";
            this.lblMsgbrd.Size = new System.Drawing.Size(107, 17);
            this.lblMsgbrd.TabIndex = 2;
            this.lblMsgbrd.Text = "Message Board";
            // 
            // lblMsgLst
            // 
            this.lblMsgLst.AutoSize = true;
            this.lblMsgLst.Location = new System.Drawing.Point(848, 47);
            this.lblMsgLst.Name = "lblMsgLst";
            this.lblMsgLst.Size = new System.Drawing.Size(91, 17);
            this.lblMsgLst.TabIndex = 3;
            this.lblMsgLst.Text = "Message List";
            // 
            // frmMessageBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 555);
            this.Controls.Add(this.lblMsgLst);
            this.Controls.Add(this.lblMsgbrd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstbxMsgs);
            this.Name = "frmMessageBoard";
            this.Text = "MessageBoard";
            this.Load += new System.EventHandler(this.MessageBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxMsgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMsgbrd;
        private System.Windows.Forms.Label lblMsgLst;
    }
}