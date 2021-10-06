using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;

namespace RumbleInstallator2
{
    public partial class RumbleInstaller : Form
    {
        public RumbleInstaller()
        {
            BackgroundImage = RumbleInstallator.Properties.Resources.background;
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            installLabel.Visible = false;
            uninstallLabel.Visible = false;
            runAsAdministratorLabel.Visible = false;
            installLabel.BackColor = Color.Transparent;
            uninstallLabel.BackColor = Color.Transparent;
            runAsAdministratorLabel.BackColor = Color.Transparent;
            install.BackColor = Color.Transparent;
            facebook.BackColor = Color.Transparent;
            uninstall.BackColor = Color.Transparent;
            Size = new Size(1000, 500);
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void install_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                runAsAdministratorLabel.Visible = true;
                return;
            }
            installLabel.Visible = true;
            if (uninstallLabel.Visible)
            {
                uninstallLabel.Visible = false;
            }
            string lmhosts = @"C:\Windows\System32\drivers\etc\lmhosts.sam";
            if (File.Exists(lmhosts))
            {
                File.Delete(lmhosts);
            }
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            FileAttributes attributes = File.GetAttributes(path);
            attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
            File.SetAttributes(path, attributes);
            File.WriteAllText(path, "51.77.11.177 s.optifine.net");
            File.SetAttributes(path, FileAttributes.Hidden);
        }

        private void uninstall_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                runAsAdministratorLabel.Visible = true;
                return;
            }
            uninstallLabel.Visible = true;
            if (installLabel.Visible)
            {
                installLabel.Visible = false;
            }
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            FileAttributes attributes = File.GetAttributes(path);
            attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
            File.SetAttributes(path, attributes);
            string text = File.ReadAllText(path);
            text = text.Replace("51.77.11.177 s.optifine.net", String.Empty);
            File.WriteAllText(path, text);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/rumblecape");
        }

        private FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private bool IsAdministrator()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
