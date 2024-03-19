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

namespace Photo_Manager
{
    public partial class ColumnConfigForm : Form
    {
        string path;
        PF parent;
        public ColumnConfigForm(PF par)
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory() + "/Dat/columns.txt";

            parent = par;

            List<string> alreadySelected = new List<string>();
            alreadySelected = File.ReadAllLines(path).ToList<String>();

            foreach(string s in alreadySelected)
            {
                if(BasicListBox1.Items.Contains(s))
                {
                    BasicListBox1.SetItemChecked(BasicListBox1.Items.IndexOf(s), true);
                }
                if (CameraListBox.Items.Contains(s))
                {
                    CameraListBox.SetItemChecked(CameraListBox.Items.IndexOf(s), true);
                }
                if (LensListBox.Items.Contains(s))
                {
                    LensListBox.SetItemChecked(LensListBox.Items.IndexOf(s), true);
                }
            }
        }

        public void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ColumnConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>();
            foreach (string s in BasicListBox1.CheckedItems)
            {
                cols.Add(s);
            }
            foreach (string s2 in CameraListBox.CheckedItems)
            {
                cols.Add(s2);
            }
            foreach (string s3 in LensListBox.CheckedItems)
            {
                cols.Add(s3);
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllLines(path, cols.ToArray());
            parent.ReadColumnsFile();
            this.Close();

        }
    }
}
