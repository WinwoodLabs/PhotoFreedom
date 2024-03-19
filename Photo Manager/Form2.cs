using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace Photo_Manager
{
    public partial class bulkEditForm : Form
    {
        public List<string> filePaths;
        PF parent;
        public bulkEditForm(List<string> files, PF par)
        {
            InitializeComponent();
            parent = par;
            filePaths = new List<string>();
            filePaths.AddRange(files);
            headerText.Text = "Editing " + filePaths.Count + " Files...";

        }

        ~bulkEditForm()
        {
            filePaths.Clear();
            this.Dispose();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (titleCheck.Checked == false && subjectCheck.Checked == false && commentsCheck.Checked == false && authorCheck.Checked == false && dateCheck.Checked == false)
            {
                MessageBox.Show("No Changes Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                DialogResult res = MessageBox.Show("Confirm Bulk Change to " + filePaths.Count + " Items?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    foreach (string s in filePaths)
                    {
                        ShellFile shellFile = ShellFile.FromFilePath(s);
                        if (titleCheck.Checked == true)
                        {
                            shellFile.Properties.System.Title.Value = titleBox.Text;
                        }
                        if (subjectCheck.Checked == true)
                        {
                            shellFile.Properties.System.Subject.Value = subjectBox.Text;
                        }
                        if (commentsCheck.Checked == true)
                        {
                            shellFile.Properties.System.Comment.Value = commentsBox.Text;
                        }
                        if (authorCheck.Checked == true)
                        {
                            shellFile.Properties.System.Comment.Value = authorBox.Text;
                        }
                        if (dateCheck.Checked == true)
                        {
                            File.SetCreationTime(s, dateTimePicker1.Value);
                        }
                    }
                    parent.ForceRefresh();
                    this.Dispose();
                    this.Close();

                }
            }
        }
    }
}
