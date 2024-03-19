using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using System.Runtime.InteropServices;

namespace Photo_Manager
{
    public partial class PF : Form
    {

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;
        public static bool ShowFileProperties(string Filename)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = Filename;
            info.lpParameters = "Details";
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }

        string folderPath;
        string refineTerm;
        List<PhotoWrapper> currPhotos;

        enum refineType {date, title, subject, comments, author, camera, cameramodel, none}; 

        public PF()
        {
            InitializeComponent();
            currPhotos = new List<PhotoWrapper>();

            ReadColumnsFile();
        }

        public void ReadColumnsFile()
        {
            foreach (DataGridViewColumn c in folderGridView.Columns)
            {
                c.Visible = false;
            }
            string path = Directory.GetCurrentDirectory() + "/Dat/columns.txt";
            if (File.Exists(path))
            {
                List<String> cols = File.ReadAllLines(path).ToList<String>();
                foreach (string s in cols)
                {
                    string SanitizedString = s
                        .Replace("/", string.Empty)
                        .Replace("\\", string.Empty)
                        .Replace(" ", string.Empty)
                        .Trim();
                    folderGridView.Columns[SanitizedString].Visible = true;
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("No Folder Config Found. Creating Basic","No Folder Config", MessageBoxButtons.OK);
                string[] strings = new string[3];
                strings[0] = "Date";
                strings[1] = "Title";
                strings[2] = "Img";
                File.WriteAllLines(path, strings);
                ReadColumnsFile();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //Null function
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            //Null function
        }

        private void RefreshFolderList()
        {
            folderComboBox.Items.Clear();
            string path = Directory.GetCurrentDirectory() + "/Dat/folders.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var file = new System.IO.StreamReader(fs, System.Text.Encoding.UTF8, true, 128);
            fs.Close();
            List<string> folders = new List<string>();

            folderComboBox.Items.AddRange(File.ReadAllLines(path));
            folderGridView.DataSource = File.ReadAllLines(path);
        }

        private void RefreshFileList()
        {
            folderPath = folderComboBox.SelectedItem.ToString();

            currPhotos.Clear();

            foreach (string s in Directory.GetFiles(folderPath).Where(x => x.EndsWith(".jpg")))
            {
                ShellFile shellFile = ShellFile.FromFilePath(s);
                Bitmap shellThumb = shellFile.Thumbnail.MediumBitmap;

                PhotoWrapper p = new PhotoWrapper();
                p.Name = s;
                p.Img = shellThumb;
                p.Title = shellFile.Properties.System.Title.Value;
                p.Subject = shellFile.Properties.System.Subject.Value;
                p.Comments = shellFile.Properties.System.Comment.Value;
                p.Date = shellFile.Properties.System.ItemDate.Value.ToString();
                p.DateModified = shellFile.Properties.System.DateModified.Value.ToString();
                p.Dimensions = shellFile.Properties.System.Image.Dimensions.Value;
                p.HorizontalRes = shellFile.Properties.System.Image.HorizontalResolution.Value.ToString();
                p.VerticalRes = shellFile.Properties.System.Image.VerticalResolution.Value.ToString();
                p.BitDepth = shellFile.Properties.System.Image.BitDepth.Value.ToString();
                p.CameraMaker = shellFile.Properties.System.Photo.CameraManufacturer.Value;
                p.CameraModel = shellFile.Properties.System.Photo.CameraModel.Value;
                p.CameraSerialNumber = shellFile.Properties.System.Photo.CameraSerialNumber.Value;
                p.FStop = shellFile.Properties.System.Photo.FNumber.Value.ToString();
                p.ExposureTime = shellFile.Properties.System.Photo.ExposureTime.Value.ToString();
                p.FocalLength = shellFile.Properties.System.Photo.FocalLength.Value.ToString();
                p.MaxAperture = shellFile.Properties.System.Photo.MaxAperture.Value.ToString();
                p.MeteringMode = MeteringModeResolve(shellFile.Properties.System.Photo.MeteringMode.Value.ToString());
                p.SubjectDistance = shellFile.Properties.System.Photo.SubjectDistance.Value.ToString();
                p.LensMaker = shellFile.Properties.System.Photo.LensManufacturer.Value;
                p.LensModel = shellFile.Properties.System.Photo.LensModel.Value;
                p.Contrast = SharpnessResolve(shellFile.Properties.System.Photo.Contrast.Value.ToString());
                p.Brightness = shellFile.Properties.System.Photo.Brightness.Value.ToString();
                p.LightSource = LightSourceResolve(shellFile.Properties.System.Photo.LightSource.Value.ToString());
                p.Saturation = SaturationResolve(shellFile.Properties.System.Photo.Saturation.Value.ToString());
                p.Sharpness = SharpnessResolve(shellFile.Properties.System.Photo.Sharpness.Value.ToString());
                p.WhiteBalance = WhiteBalanceResolve(shellFile.Properties.System.Photo.WhiteBalance.Value.ToString());
                p.ISOSpeed = ISOResolve(shellFile.Properties.System.Photo.ISOSpeed.Value.ToString());

                if (shellFile.Properties.System.Author.Value != null)
                {
                    p.Author = shellFile.Properties.System.Author.Value[0];
                }
                else p.Author = "NA";
                //p.author = shellFile.Properties.System.Author.Value[0];
                p.Size = (shellFile.Properties.System.Size.Value / 1028).ToString() + "KB";

                currPhotos.Add(p);
            }
            folderGridView.DataSource = null;
            folderGridView.DataSource = currPhotos;
            folderGridView.Refresh();
        }

        private void RefreshRefinedFileList(refineType r, string term)
        {
            folderPath = folderComboBox.SelectedItem.ToString();

            currPhotos.Clear();

            foreach (string s in Directory.GetFiles(folderPath).Where(x => x.EndsWith(".jpg")))
            {
                ShellFile shellFile = ShellFile.FromFilePath(s);
                Bitmap shellThumb = shellFile.Thumbnail.MediumBitmap;

                PhotoWrapper p = new PhotoWrapper();
                p.Name = s;
                p.Img = shellThumb;
                p.Title = shellFile.Properties.System.Title.Value;
                p.Subject = shellFile.Properties.System.Subject.Value;
                p.Comments = shellFile.Properties.System.Comment.Value;
                p.Date = shellFile.Properties.System.ItemDate.Value.ToString();
                p.DateModified = shellFile.Properties.System.DateModified.Value.ToString();
                p.Dimensions = shellFile.Properties.System.Image.Dimensions.Value;
                p.HorizontalRes = shellFile.Properties.System.Image.HorizontalResolution.Value.ToString();
                p.VerticalRes = shellFile.Properties.System.Image.VerticalResolution.Value.ToString();
                p.BitDepth = shellFile.Properties.System.Image.BitDepth.Value.ToString();
                p.CameraMaker = shellFile.Properties.System.Photo.CameraManufacturer.Value;
                p.CameraModel = shellFile.Properties.System.Photo.CameraModel.Value;
                p.CameraSerialNumber = shellFile.Properties.System.Photo.CameraSerialNumber.Value;
                p.FStop = shellFile.Properties.System.Photo.FNumber.Value.ToString();
                p.ExposureTime = shellFile.Properties.System.Photo.ExposureTime.Value.ToString();
                p.FocalLength = shellFile.Properties.System.Photo.FocalLength.Value.ToString();
                p.MaxAperture = shellFile.Properties.System.Photo.MaxAperture.Value.ToString();
                p.MeteringMode = MeteringModeResolve(shellFile.Properties.System.Photo.MeteringMode.Value.ToString());
                p.SubjectDistance = shellFile.Properties.System.Photo.SubjectDistance.Value.ToString();
                p.LensMaker = shellFile.Properties.System.Photo.LensManufacturer.Value;
                p.LensModel = shellFile.Properties.System.Photo.LensModel.Value;
                p.Contrast = SharpnessResolve(shellFile.Properties.System.Photo.Contrast.Value.ToString());
                p.Brightness = shellFile.Properties.System.Photo.Brightness.Value.ToString();
                p.LightSource = LightSourceResolve(shellFile.Properties.System.Photo.LightSource.Value.ToString());
                p.Saturation = SaturationResolve(shellFile.Properties.System.Photo.Saturation.Value.ToString());
                p.Sharpness = SharpnessResolve(shellFile.Properties.System.Photo.Sharpness.Value.ToString());
                p.WhiteBalance = WhiteBalanceResolve(shellFile.Properties.System.Photo.WhiteBalance.Value.ToString());
                p.ISOSpeed = ISOResolve(shellFile.Properties.System.Photo.ISOSpeed.Value.ToString());


                if (shellFile.Properties.System.Author.Value != null)
                {
                    p.Author = shellFile.Properties.System.Author.Value[0];
                }
                else p.Author = "NA";
                p.Size = (shellFile.Properties.System.Size.Value / 1028).ToString() + "KB";

                currPhotos.Add(p);
            }
            folderGridView.DataSource = null;
            switch (r)
            {
                case refineType.author:
                    folderGridView.DataSource = currPhotos.Where(x=>x.Author!= null && x.Author.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.comments:
                    folderGridView.DataSource = currPhotos.Where(x => x.Comments != null && x.Comments.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.date:
                    folderGridView.DataSource = currPhotos.Where(x => x.Date != null && x.Date.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.subject:
                    folderGridView.DataSource = currPhotos.Where(x => x.Subject != null && x.Subject.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.title:
                    folderGridView.DataSource = currPhotos.Where(x => x.Title != null && x.Title.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.camera:
                    folderGridView.DataSource = currPhotos.Where(x => x.CameraMaker != null && x.CameraMaker.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.cameramodel:
                    folderGridView.DataSource = currPhotos.Where(x => x.CameraModel != null && x.CameraModel.Contains(term)).ToList<PhotoWrapper>();
                    break;
                case refineType.none:
                    folderGridView.DataSource = currPhotos;
                    break;
                default:
                    MessageBox.Show("Error - Invalid Refine", "Error - Invalid Refine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    folderGridView.DataSource = currPhotos;
                    break;
            }

            if(currPhotos.Count == 0)
            {
                MessageBox.Show("No Results", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            folderGridView.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshFolderList();
        }

        private void folderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFileList();

        }

        private void folderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Null function
        }

        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/Dat/folders.txt";

            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(folderBrowserDialog1.SelectedPath);
                    sw.Close();
                }
                RefreshFolderList();
            }
        }

        private void folderGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(folderGridView.SelectedRows.Count == 1)
            {
                if (folderGridView.SelectedRows[0].DataBoundItem as PhotoWrapper != null)
                {
                    CurrPicBox.Image = (folderGridView.SelectedRows[0].DataBoundItem as PhotoWrapper).Img;
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Null function
        }

        private void folderGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
             * REMOVED AS BULK FORM IS SUFFICIENT FOR SINGLE EDIT
             * 
             * if (folderGridView.SelectedRows.Count == 1)
            {
                if (folderGridView.SelectedRows[0].DataBoundItem as PhotoWrapper != null)
                {
                    ShowFileProperties((folderGridView.SelectedRows[0].DataBoundItem as PhotoWrapper).name);
                    RefreshFileList();
                    folderGridView.Refresh();
                }
            }*/
            if(folderGridView.SelectedRows.Count > 0)
            {
                List<string> f = new List<string>();
                foreach(DataGridViewRow r in folderGridView.SelectedRows)
                {
                    f.Add((r.DataBoundItem as PhotoWrapper).Name);
                }
                bulkEditForm bulk = new bulkEditForm(f, this);
                bulk.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Null function
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (refineTerm != null && refineTermBox.Text != null)
            {
                switch(comboBox1.SelectedItem)
                {
                    case "(None)":
                        RefreshFileList();
                        break;
                    case "Date":
                        RefreshRefinedFileList(refineType.date, refineTerm);
                        break;
                    case "Title":
                        RefreshRefinedFileList(refineType.title, refineTerm);
                        break;
                    case "Subject":
                        RefreshRefinedFileList(refineType.subject, refineTerm);
                        break;
                    case "Comments":
                        RefreshRefinedFileList(refineType.comments, refineTerm);
                        break;
                    case "Author":
                        RefreshRefinedFileList(refineType.author, refineTerm);
                        break;
                    case "Camera Maker":
                        RefreshRefinedFileList(refineType.camera, refineTerm);
                        break;
                    case "Camera Model":
                        RefreshRefinedFileList(refineType.cameramodel, refineTerm);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error", "Invalid Refine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refineTermBox_TextChanged(object sender, EventArgs e)
        {
            refineTerm = refineTermBox.Text;
        }

        public void ForceRefresh()
        {
            RefreshFileList();
            folderGridView.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshFileList();
            folderGridView.Refresh();
        }

        private void debugForceButton_Click(object sender, EventArgs e)
        {
            ShellFile shellFile = ShellFile.FromFilePath((folderGridView.SelectedRows[0].DataBoundItem as PhotoWrapper).Name);
            //shellFile.Properties.System.Comment.Value = debugText.Text;

        }

        private void openFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            if(folderGridView.SelectedRows.Count > 3)
            {
                res = MessageBox.Show("You are trying to open more than 3 files. Do you really want to do this?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                res = DialogResult.Yes;
            }

            if (res == DialogResult.Yes)
            {

                foreach (DataGridViewRow p in folderGridView.SelectedRows)
                {
                    System.Diagnostics.Process.Start((p.DataBoundItem as PhotoWrapper).Name);
                }
            }
        }

        private void ColConfigButton_Click(object sender, EventArgs e)
        {
            ColumnConfigForm ccf = new ColumnConfigForm(this);
            ccf.Show();
        }

        public string MeteringModeResolve(string s)
        {
            switch(s)
            {
                case ("0"):
                    return "Unknown";
                case ("1"):
                    return "Average";
                case ("2"):
                    return "Centre Weighted Average";
                case ("3"):
                    return "Spot";
                case ("4"):
                    return "Multi Spot";
                case ("5"):
                    return "Pattern";
                case ("6"):
                    return "Partial";
                default:
                    return "Unknown";
            }
        }

        public string LightSourceResolve(string s)
        {
            switch (s)
            {
                case ("0"):
                    return "Unknown";
                case ("1"):
                    return "Daylight";
                case ("2"):
                    return "Flourescent";
                case ("3"):
                    return "Tungsten";
                case ("4"):
                    return "Standard A";
                case ("5"):
                    return "Standard B";
                case ("6"):
                    return "Standard C";
                case ("7"):
                    return "D55";
                case ("8"):
                    return "D65";
                case ("9"):
                    return "D75";
                default:
                    return "Unknown";
            }
        }

        public string SharpnessResolve(string s)
        {
            switch(s)
            {
                case ("0"):
                    return "Normal";
                case ("1"):
                    return "Soft";
                case ("2"):
                    return "Hard";
                default:
                    return "Unknown";
            }
        }

        public string SaturationResolve(string s)
        {
            switch(s)
            {
                case ("0"):
                    return "Normal";
                case ("1"):
                    return "Low";
                case ("2"):
                    return "High";
                default:
                    return "Unknown";
            }
        }

        public string ISOResolve(string s)
        {
            return "ISO-" + s;
        }

        public string WhiteBalanceResolve(string s)
        {
            switch(s)
            {
                case ("0"):
                    return "Auto";
                case ("1"):
                    return "Manual";
                default:
                    return "Unknown";
            }
        }
    }


    public class PhotoWrapper
    {
        public string Name {get; set;}
        public Image Img { get; set; }

        public string Date { get; set; }

        public string Title { get; set; }

        public string Subject { get; set; }

        public string Comments { get; set; }

        public string Author { get; set; }

        public string Size { get; set; }

        public string DateModified { get; set; }

        public string Dimensions { get; set; }

        public object Rating { get; set; }

        public string Tags { get; set; }

        public string Copyright { get; set; }

        public string HorizontalRes { get; set; }

        public string VerticalRes { get; set; }

        public string BitDepth { get; set; }

        public string CameraMaker { get; set; }

        public string CameraModel { get; set; }

        public string FStop { get; set; }

        public string ExposureTime { get; set; }

        public string ISOSpeed { get; set; }

        public int ExposureBias { get; set; }

        public string FocalLength { get; set; }

        public string MaxAperture { get; set; }

        public string MeteringMode { get; set; }

        public string SubjectDistance { get; set; }

        public string LensMaker { get; set; }

        public string LensModel { get; set; }

        public string CameraSerialNumber { get; set; }

        public string Contrast { get; set; }

        public string Brightness { get; set; }

        public string LightSource { get; set; }

        public string Saturation { get; set; }

        public string Sharpness { get; set; }

        public string WhiteBalance { get; set; }
    }

}
