using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ESP_IDF_ProjectCreator
{
    public partial class Form1 : Form
    {
        string systemDirectory = @"C:\";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string dirName = tbxProjectName.Text;
            projectName = tbxProjectName.Text;
            string subDirName = @"\main";

            System.IO.Directory.CreateDirectory(systemDirectory + dirName);
            System.IO.Directory.CreateDirectory(systemDirectory + dirName + subDirName);

            System.IO.File.WriteAllText(systemDirectory + dirName + gdbinitFile, gdbinitci);

            var cmakeliststxt = cmakelistsTemplate.Replace("NewProject", projectName);
            System.IO.File.WriteAllText(systemDirectory + dirName + cmakeLists, cmakeliststxt);

            var makefiletxt = makefileTemplate.Replace("NewProject", projectName);
            System.IO.File.WriteAllText(systemDirectory + dirName + makefile, makefiletxt);

            var maincmakelisttxt = maincmakeliststemp.Replace("NewProject", projectName);
            System.IO.File.WriteAllText(systemDirectory + dirName + subDirName + cmakeLists, maincmakelisttxt);
            System.IO.File.WriteAllText(systemDirectory + dirName + subDirName + componentfile, componentfiletxt);

            System.IO.File.WriteAllText(systemDirectory + dirName + @"\sdkconfig", "");
            System.IO.File.WriteAllText(systemDirectory + dirName + @"\README.md", "");

            File.Copy(@"sdkconfig", systemDirectory + dirName + @"\sdkconfig", true);
            System.IO.File.WriteAllText(systemDirectory + dirName + subDirName + @"\" + @projectName + ".c", "");
            File.Copy(@"main.c", systemDirectory + dirName + subDirName + @"\" + projectName + ".c", true);

        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                tbxDestination.Text = Text + "\\";
                systemDirectory = Text + "\\";
            }
        }
    }
}
