namespace ESP_IDF_ProjectCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbxProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.fbdDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.btnDestination);
            this.gbxMain.Controls.Add(this.tbxDestination);
            this.gbxMain.Controls.Add(this.lblDestination);
            this.gbxMain.Controls.Add(this.tbxProjectName);
            this.gbxMain.Controls.Add(this.lblProjectName);
            this.gbxMain.Controls.Add(this.btnCreate);
            this.gbxMain.Location = new System.Drawing.Point(13, 6);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(475, 159);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.TabStop = false;
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(433, 17);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(26, 20);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(86, 17);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(341, 20);
            this.tbxDestination.TabIndex = 4;
            this.tbxDestination.Text = "C:/";
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(6, 16);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(74, 22);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxProjectName
            // 
            this.tbxProjectName.Location = new System.Drawing.Point(86, 46);
            this.tbxProjectName.Name = "tbxProjectName";
            this.tbxProjectName.Size = new System.Drawing.Size(341, 20);
            this.tbxProjectName.TabIndex = 2;
            this.tbxProjectName.Text = "NewProject";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Location = new System.Drawing.Point(6, 45);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 22);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(187, 106);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 47);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 174);
            this.Controls.Add(this.gbxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP-IDF Project Creator";
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.TextBox tbxProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.FolderBrowserDialog fbdDestination;
    }
}

