namespace Military_communication
{
    partial class frmLoadingScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingScreen));
            this.pgLoad = new System.Windows.Forms.ProgressBar();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblJacobus = new System.Windows.Forms.Label();
            this.lblLorenzo = new System.Windows.Forms.Label();
            this.lblCreatededJochemus = new System.Windows.Forms.Label();
            this.lblMilcommunication = new System.Windows.Forms.Label();
            this.picLoadingScreen = new System.Windows.Forms.PictureBox();
            this.tmLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pgLoad
            // 
            this.pgLoad.Location = new System.Drawing.Point(174, 123);
            this.pgLoad.Name = "pgLoad";
            this.pgLoad.Size = new System.Drawing.Size(451, 23);
            this.pgLoad.Step = 20;
            this.pgLoad.TabIndex = 19;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(313, 186);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(312, 42);
            this.lblCopyright.TabIndex = 17;
            this.lblCopyright.Text = "Copyright Milnex 2019.";
            // 
            // lblJacobus
            // 
            this.lblJacobus.AutoSize = true;
            this.lblJacobus.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJacobus.Location = new System.Drawing.Point(450, 312);
            this.lblJacobus.Name = "lblJacobus";
            this.lblJacobus.Size = new System.Drawing.Size(289, 42);
            this.lblJacobus.TabIndex = 16;
            this.lblJacobus.Text = "Jacobus vander merwe.";
            // 
            // lblLorenzo
            // 
            this.lblLorenzo.AutoSize = true;
            this.lblLorenzo.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLorenzo.Location = new System.Drawing.Point(450, 270);
            this.lblLorenzo.Name = "lblLorenzo";
            this.lblLorenzo.Size = new System.Drawing.Size(219, 42);
            this.lblLorenzo.TabIndex = 15;
            this.lblLorenzo.Text = "Lorenzo Lazarus,";
            // 
            // lblCreatededJochemus
            // 
            this.lblCreatededJochemus.AutoSize = true;
            this.lblCreatededJochemus.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatededJochemus.Location = new System.Drawing.Point(313, 228);
            this.lblCreatededJochemus.Name = "lblCreatededJochemus";
            this.lblCreatededJochemus.Size = new System.Drawing.Size(386, 42);
            this.lblCreatededJochemus.TabIndex = 14;
            this.lblCreatededJochemus.Text = "Created by Jochemus Taljaard,";
            // 
            // lblMilcommunication
            // 
            this.lblMilcommunication.AutoSize = true;
            this.lblMilcommunication.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilcommunication.Location = new System.Drawing.Point(21, 19);
            this.lblMilcommunication.Name = "lblMilcommunication";
            this.lblMilcommunication.Size = new System.Drawing.Size(377, 42);
            this.lblMilcommunication.TabIndex = 13;
            this.lblMilcommunication.Text = "Military communication 2.0";
            // 
            // picLoadingScreen
            // 
            this.picLoadingScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoadingScreen.BackgroundImage")));
            this.picLoadingScreen.Location = new System.Drawing.Point(-1, 2);
            this.picLoadingScreen.Name = "picLoadingScreen";
            this.picLoadingScreen.Size = new System.Drawing.Size(803, 447);
            this.picLoadingScreen.TabIndex = 18;
            this.picLoadingScreen.TabStop = false;
            // 
            // tmLoading
            // 
            this.tmLoading.Tick += new System.EventHandler(this.tmLoading_Tick);
            // 
            // frmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.pgLoad);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblJacobus);
            this.Controls.Add(this.lblLorenzo);
            this.Controls.Add(this.lblCreatededJochemus);
            this.Controls.Add(this.lblMilcommunication);
            this.Controls.Add(this.picLoadingScreen);
            this.Name = "frmLoadingScreen";
            this.Text = "Loading Screen.";
            this.Load += new System.EventHandler(this.frmLoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgLoad;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblJacobus;
        private System.Windows.Forms.Label lblLorenzo;
        private System.Windows.Forms.Label lblCreatededJochemus;
        private System.Windows.Forms.Label lblMilcommunication;
        private System.Windows.Forms.PictureBox picLoadingScreen;
        private System.Windows.Forms.Timer tmLoading;
    }
}

