using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DefaultDesktopMessageBoxIssue
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        public IEnumerable<string> Files { get; set; }

        public string SelectedFolder { get; set; }

        private void enumerateFilesBtn_Click(object sender, EventArgs e) =>
            Files = Directory.EnumerateFiles(SelectedFolder);

        private void desktopMsgBoxBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "With default desktop only",
                "Messagebox test",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            msgBoxResultTbx.Text = Enum.GetName(typeof(DialogResult), result);
        }

        private void standardMsgBoxBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Without default desktop only",
                "Messagebox test",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

            msgBoxResultTbx.Text = Enum.GetName(typeof(DialogResult), result);
        }

        private void toListBtn_Click(object sender, EventArgs e) => Files = Files.ToList();

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            var result = demoFolderBrowserDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedFolderTbx.Text = demoFolderBrowserDlg.SelectedPath;
                SelectedFolder = demoFolderBrowserDlg.SelectedPath;
            }
        }
    }
}