namespace KKShare
{
    partial class MainView
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
            this.txtBoxPortServer = new System.Windows.Forms.TextBox();
            this.btnRcv = new System.Windows.Forms.Button();
            this.grpBoxServer = new System.Windows.Forms.GroupBox();
            this.lblPortServer = new System.Windows.Forms.Label();
            this.grpBoxClient = new System.Windows.Forms.GroupBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtBoxIp = new System.Windows.Forms.TextBox();
            this.lblPortClient = new System.Windows.Forms.Label();
            this.txtBoxPortClient = new System.Windows.Forms.TextBox();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.txtBoxSelectFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpBoxLog = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.inputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxServer.SuspendLayout();
            this.grpBoxClient.SuspendLayout();
            this.grpBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPortServer
            // 
            this.txtBoxPortServer.Location = new System.Drawing.Point(46, 23);
            this.txtBoxPortServer.Name = "txtBoxPortServer";
            this.txtBoxPortServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPortServer.Size = new System.Drawing.Size(41, 20);
            this.txtBoxPortServer.TabIndex = 0;
            this.txtBoxPortServer.Text = "51000";
            this.txtBoxPortServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPortServer.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPortServer_Validating);
            // 
            // btnRcv
            // 
            this.btnRcv.Location = new System.Drawing.Point(37, 113);
            this.btnRcv.Name = "btnRcv";
            this.btnRcv.Size = new System.Drawing.Size(100, 23);
            this.btnRcv.TabIndex = 1;
            this.btnRcv.Text = "Start Receiving";
            this.btnRcv.UseVisualStyleBackColor = true;
            this.btnRcv.Click += new System.EventHandler(this.btnRcv_Click);
            // 
            // grpBoxServer
            // 
            this.grpBoxServer.Controls.Add(this.lblPortServer);
            this.grpBoxServer.Controls.Add(this.txtBoxPortServer);
            this.grpBoxServer.Controls.Add(this.btnRcv);
            this.grpBoxServer.Location = new System.Drawing.Point(12, 12);
            this.grpBoxServer.Name = "grpBoxServer";
            this.grpBoxServer.Size = new System.Drawing.Size(175, 151);
            this.grpBoxServer.TabIndex = 2;
            this.grpBoxServer.TabStop = false;
            this.grpBoxServer.Text = "Server";
            // 
            // lblPortServer
            // 
            this.lblPortServer.AutoSize = true;
            this.lblPortServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortServer.Location = new System.Drawing.Point(6, 26);
            this.lblPortServer.Name = "lblPortServer";
            this.lblPortServer.Size = new System.Drawing.Size(34, 13);
            this.lblPortServer.TabIndex = 2;
            this.lblPortServer.Text = "Port:";
            // 
            // grpBoxClient
            // 
            this.grpBoxClient.Controls.Add(this.lblIp);
            this.grpBoxClient.Controls.Add(this.txtBoxIp);
            this.grpBoxClient.Controls.Add(this.lblPortClient);
            this.grpBoxClient.Controls.Add(this.txtBoxPortClient);
            this.grpBoxClient.Controls.Add(this.lblSelectFile);
            this.grpBoxClient.Controls.Add(this.txtBoxSelectFile);
            this.grpBoxClient.Controls.Add(this.btnBrowseFile);
            this.grpBoxClient.Controls.Add(this.btnSend);
            this.grpBoxClient.Location = new System.Drawing.Point(193, 12);
            this.grpBoxClient.Name = "grpBoxClient";
            this.grpBoxClient.Size = new System.Drawing.Size(421, 151);
            this.grpBoxClient.TabIndex = 3;
            this.grpBoxClient.TabStop = false;
            this.grpBoxClient.Text = "Client";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.Location = new System.Drawing.Point(6, 26);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(72, 13);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "IP Address:";
            // 
            // txtBoxIp
            // 
            this.txtBoxIp.Location = new System.Drawing.Point(84, 23);
            this.txtBoxIp.Name = "txtBoxIp";
            this.txtBoxIp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIp.Size = new System.Drawing.Size(88, 20);
            this.txtBoxIp.TabIndex = 0;
            this.txtBoxIp.Text = "192.168.13.24";
            this.txtBoxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPortClient
            // 
            this.lblPortClient.AutoSize = true;
            this.lblPortClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortClient.Location = new System.Drawing.Point(189, 26);
            this.lblPortClient.Name = "lblPortClient";
            this.lblPortClient.Size = new System.Drawing.Size(34, 13);
            this.lblPortClient.TabIndex = 3;
            this.lblPortClient.Text = "Port:";
            // 
            // txtBoxPortClient
            // 
            this.txtBoxPortClient.Location = new System.Drawing.Point(229, 23);
            this.txtBoxPortClient.Name = "txtBoxPortClient";
            this.txtBoxPortClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPortClient.Size = new System.Drawing.Size(41, 20);
            this.txtBoxPortClient.TabIndex = 4;
            this.txtBoxPortClient.Text = "51000";
            this.txtBoxPortClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFile.Location = new System.Drawing.Point(6, 63);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(71, 13);
            this.lblSelectFile.TabIndex = 5;
            this.lblSelectFile.Text = "Select File:";
            // 
            // txtBoxSelectFile
            // 
            this.txtBoxSelectFile.Location = new System.Drawing.Point(83, 60);
            this.txtBoxSelectFile.Name = "txtBoxSelectFile";
            this.txtBoxSelectFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxSelectFile.Size = new System.Drawing.Size(297, 20);
            this.txtBoxSelectFile.TabIndex = 6;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(386, 59);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(29, 22);
            this.btnBrowseFile.TabIndex = 7;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(178, 113);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send File";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grpBoxLog
            // 
            this.grpBoxLog.Controls.Add(this.listBoxLog);
            this.grpBoxLog.Location = new System.Drawing.Point(12, 169);
            this.grpBoxLog.Name = "grpBoxLog";
            this.grpBoxLog.Size = new System.Drawing.Size(602, 170);
            this.grpBoxLog.TabIndex = 4;
            this.grpBoxLog.TabStop = false;
            this.grpBoxLog.Text = "Log";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(9, 19);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(587, 134);
            this.listBoxLog.TabIndex = 0;
            // 
            // inputErrorProvider
            // 
            this.inputErrorProvider.ContainerControl = this;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.grpBoxServer);
            this.Controls.Add(this.grpBoxClient);
            this.Controls.Add(this.grpBoxLog);
            this.Name = "MainView";
            this.Text = "KKShare v0.1";
            this.grpBoxServer.ResumeLayout(false);
            this.grpBoxServer.PerformLayout();
            this.grpBoxClient.ResumeLayout(false);
            this.grpBoxClient.PerformLayout();
            this.grpBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPortServer;
        private System.Windows.Forms.Button btnRcv;
        private System.Windows.Forms.GroupBox grpBoxServer;
        private System.Windows.Forms.GroupBox grpBoxClient;
        private System.Windows.Forms.TextBox txtBoxIp;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPortServer;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPortClient;
        private System.Windows.Forms.TextBox txtBoxPortClient;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.TextBox txtBoxSelectFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.GroupBox grpBoxLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ErrorProvider inputErrorProvider;
    }
}

