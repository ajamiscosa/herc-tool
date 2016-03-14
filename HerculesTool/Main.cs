using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Telerik.WinControls;
using SwingWERX.Utils;

namespace HerculesTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            vistaMenu.SetImage(mNewProject, Utils.ResizeImage(Properties.Resources.newproject, 16, 16));
            vistaMenu.SetImage(mOpenProject, Utils.ResizeImage(Properties.Resources.openproject, 16, 16));
            vistaMenu.SetImage(mSaveProject, Utils.ResizeImage(Properties.Resources.saveproject, 16, 16));
            vistaMenu.SetImage(mConnectHost, Utils.ResizeImage(Properties.Resources.connect, 16, 16));
            vistaMenu.SetImage(mPreferences, Utils.ResizeImage(Properties.Resources.preferences, 16, 16));

            vistaMenu.SetImage(mAbout, Utils.ResizeImage(Properties.Resources.about, 16, 16));
        }

        private void SelectedPageChanging_Event(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            pageView.SelectedPage.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
        }

        private void SelectedPageChanged_Event(object sender, EventArgs e)
        {
            if (pageView.SelectedPage.Name != "homePage")
            {
                pageView.SelectedPage.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Visible;
            }
        }
        
    }
}
