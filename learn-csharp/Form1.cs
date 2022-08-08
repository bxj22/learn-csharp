using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_csharp
{
    public partial class Form1 : Form
    {
        const string RegistryKey = @"SOFTWARE\learn-csharp";
        const string RegistryTabValueKey = "ActiveTab";
        const string RegistrySaveTabValueKey = "SaveActiveTab";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load any registry values that are important
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }

            // Select the active tab based on the registry
            var saveActiveTab = key.GetValue(RegistrySaveTabValueKey);
            if (saveActiveTab == null || saveActiveTab.ToString().ToLower() == "true")
            {
                if (key.GetValueNames().Contains(RegistryTabValueKey))
                {
                    var activeTab = key.GetValue(RegistryTabValueKey).ToString();
                    key.Close();
                    if (activeTab != null && tabMain.TabPages.ContainsKey(activeTab))
                    {
                        tabMain.SelectedTab = tabMain.TabPages[activeTab];
                    }
                }
            }
            else
            {
                cbxSaveActiveTab.Checked = false;
            }
        } 

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save important registry values
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKey, true);

            // Save active tab save checkbox
            key.SetValue(RegistrySaveTabValueKey, cbxSaveActiveTab.Checked);

            // Save the active tab so that it opens by default next time
            key.SetValue(RegistryTabValueKey, tabMain.SelectedTab.Name);

            key.Close();
        }
    }
}
