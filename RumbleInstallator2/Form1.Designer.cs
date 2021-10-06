
namespace RumbleInstallator2
{
    partial class RumbleInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RumbleInstaller));
            this.installLabel = new System.Windows.Forms.Label();
            this.uninstallLabel = new System.Windows.Forms.Label();
            this.uninstall = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.install = new System.Windows.Forms.PictureBox();
            this.runAsAdministratorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uninstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.install)).BeginInit();
            this.SuspendLayout();
            // 
            // installLabel
            // 
            this.installLabel.AutoSize = true;
            this.installLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.installLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.installLabel.ForeColor = System.Drawing.Color.Lime;
            this.installLabel.Location = new System.Drawing.Point(261, 327);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(55, 13);
            this.installLabel.TabIndex = 1;
            this.installLabel.Text = "Installed";
            // 
            // uninstallLabel
            // 
            this.uninstallLabel.AutoSize = true;
            this.uninstallLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uninstallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uninstallLabel.ForeColor = System.Drawing.Color.Red;
            this.uninstallLabel.Location = new System.Drawing.Point(663, 327);
            this.uninstallLabel.Name = "uninstallLabel";
            this.uninstallLabel.Size = new System.Drawing.Size(70, 13);
            this.uninstallLabel.TabIndex = 4;
            this.uninstallLabel.Text = "Uninstalled";
            // 
            // uninstall
            // 
            this.uninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstall.Image = ((System.Drawing.Image)(resources.GetObject("uninstall.Image")));
            this.uninstall.Location = new System.Drawing.Point(597, 343);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(206, 83);
            this.uninstall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.uninstall.TabIndex = 3;
            this.uninstall.TabStop = false;
            this.uninstall.Click += new System.EventHandler(this.uninstall_Click);
            // 
            // facebook
            // 
            this.facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(398, 331);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(193, 83);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.facebook.TabIndex = 2;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // install
            // 
            this.install.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.install.Cursor = System.Windows.Forms.Cursors.Hand;
            this.install.Image = ((System.Drawing.Image)(resources.GetObject("install.Image")));
            this.install.Location = new System.Drawing.Point(186, 343);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(206, 83);
            this.install.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.install.TabIndex = 0;
            this.install.TabStop = false;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // runAsAdministratorLabel
            // 
            this.runAsAdministratorLabel.AutoSize = true;
            this.runAsAdministratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runAsAdministratorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.runAsAdministratorLabel.Location = new System.Drawing.Point(406, 315);
            this.runAsAdministratorLabel.Name = "runAsAdministratorLabel";
            this.runAsAdministratorLabel.Size = new System.Drawing.Size(176, 13);
            this.runAsAdministratorLabel.TabIndex = 5;
            this.runAsAdministratorLabel.Text = "Run program as administrator!";
            // 
            // RumbleInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.runAsAdministratorLabel);
            this.Controls.Add(this.uninstallLabel);
            this.Controls.Add(this.uninstall);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.installLabel);
            this.Controls.Add(this.install);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RumbleInstaller";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RumbleInstaller v1.1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uninstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.install)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox install;
        private System.Windows.Forms.Label installLabel;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox uninstall;
        private System.Windows.Forms.Label uninstallLabel;
        private System.Windows.Forms.Label runAsAdministratorLabel;
    }
}

