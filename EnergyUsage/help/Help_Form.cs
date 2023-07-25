using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using assembly_info;
using EnergyUsage.Properties;


namespace help_about
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            CenterToParent();

            byte[] MHT = Resources.Help;
            string path = "Help.mht";
            MemoryStream ms; 
            FileStream fs; 

            for (int i = 0; i < 2; i++)  //Create Files From resources
            {
                ms = new MemoryStream(MHT);
                fs = new FileStream(path, FileMode.OpenOrCreate);
               
                ms.WriteTo(fs);

                fs.Close();
                ms.Close();

                MHT = Resources.licence;
                path = "licence.mht";
            }

            wbrHelp.Navigate(Path.GetFullPath(Path.Combine(Application.StartupPath, ".\\Help.mht")));
            wbrLicence.Navigate(Path.GetFullPath(Path.Combine(Application.StartupPath, ".\\licence.mht")));

            // Get the AssemblyInfo class.
            AssemblyInfo info = new AssemblyInfo();


            // Display the values.
            Text = "Help About"; //info.Title; //put in title.
            descriptionTextBox.Text = info.Description;
            companyTextBox.Text = info.Company;
            productTextBox.Text = info.Product;
            copyrightTextBox.Text = info.Copyright;
            assemblyVersionTextBox.Text = info.AssemblyVersion;
            fileVersionTextBox.Text = info.FileVersion;
            guidTextBox.Text = info.Guid;
            comVisibleTextBox.Text = info.IsComVisible.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            wbrHelp.Dispose();
            wbrLicence.Dispose();
            Dispose();
            Close();
        }

        private void Help_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("Help.mht");
            File.Delete("licence.mht");
        }

        private void lnk_lbl_jetbrains_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.jetbrains.com/products/#tech=dotnet");
        }

        private void lnklbl_licence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab_help_about.SelectedIndex = 1;
        }
    }
}
