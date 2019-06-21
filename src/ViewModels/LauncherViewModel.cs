using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class LauncherViewModel : LauncherModel
    {
        public LauncherViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Key = Properties.Settings.Default.LastKey;
        }

        private void InitializeCommands()
        {
            Launch = new RelayCommand(DoLaunch);
        }

        private void DoLaunch(object obj)
        {
            Properties.Settings.Default.LastKey = Key;
            Properties.Settings.Default.Save();
            XboxConnection.SetApiKey(Key);
            MainWindow v = new MainWindow();
            v.Show();
            Application.Current.MainWindow = v;
            Application.Current.Windows.OfType<LauncherView>().First().Close();
        }
    }
}
