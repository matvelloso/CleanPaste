using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CleanPaste
{
    public class CleanPasteApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public CleanPasteApplicationContext()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resource1.AppIcon,
                Visible = true,
                Text="CleanPaste"
            };
            trayIcon.ContextMenuStrip = new ContextMenuStrip();
            trayIcon.ContextMenuStrip.Items.Add("Settings", null, new EventHandler(this.TrayIcon_DoubleClick));
            trayIcon.ContextMenuStrip.Items.Add("Quit CleanPaste", null, new EventHandler(this.Exit));
            trayIcon.DoubleClick += TrayIcon_DoubleClick;

        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
