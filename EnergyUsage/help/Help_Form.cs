using System;
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

            MemoryStream ms = new MemoryStream(MHT);

            //Create PDF File From Binary of resources folders qr_help.pdf
            FileStream f = new FileStream("Help.mht", FileMode.OpenOrCreate);

            //Write Bytes into Our Created helpFile.mht
            ms.WriteTo(f);
            f.Close();
            ms.Close();

            wbrHelp.Navigate(Path.GetFullPath(Path.Combine(Application.StartupPath, ".\\Help.mht")));

            // Get the AssemblyInfo class.
            AssemblyInfo info = new AssemblyInfo();


            // Display the values.
            Text = "Help About"; //info.Title; //put in title.
            descriptionTextBox.Text = info.Description;
            companyTextBox.Text = info.Company;
            productTextBox.Text = info.Product;
            copyrightTextBox.Text = info.Copyright;
            trademarkTextBox.Text = info.Trademark;
            assemblyVersionTextBox.Text = info.AssemblyVersion;
            fileVersionTextBox.Text = info.FileVersion;
            guidTextBox.Text = info.Guid;
            neutralLanguageTextBox.Text = info.NeutralLanguage;
            comVisibleTextBox.Text = info.IsComVisible.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            wbrHelp.Dispose();
            Dispose();
            Close();
        }

        private void Help_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("Help.mht");
        }

        
    }
}
