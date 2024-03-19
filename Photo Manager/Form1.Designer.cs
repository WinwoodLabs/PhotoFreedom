namespace Photo_Manager
{
    partial class PF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PF));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderGridView = new System.Windows.Forms.DataGridView();
            this.CurrPicBox = new System.Windows.Forms.PictureBox();
            this.previewLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.refineButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refineTermBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.openFilesButton = new System.Windows.Forms.Button();
            this.ColConfigButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExposureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISOSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExposureBias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FocalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAperture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeteringMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LensMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LensModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brightness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sharpness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhiteBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorizontalResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoWrapperBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.photoWrapperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoWrapperBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // folderComboBox
            // 
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(12, 68);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(249, 21);
            this.folderComboBox.TabIndex = 1;
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.folderComboBox_SelectedIndexChanged);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.Location = new System.Drawing.Point(12, 12);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(249, 50);
            this.AddFolderButton.TabIndex = 2;
            this.AddFolderButton.Text = "Add Folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // folderGridView
            // 
            this.folderGridView.AllowUserToAddRows = false;
            this.folderGridView.AllowUserToDeleteRows = false;
            this.folderGridView.AllowUserToOrderColumns = true;
            this.folderGridView.AutoGenerateColumns = false;
            this.folderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.DateModified,
            this.Dimensions,
            this.Tags,
            this.Copyright,
            this.BitDepth,
            this.CameraMaker,
            this.CameraModel,
            this.FStop,
            this.ExposureTime,
            this.ISOSpeed,
            this.ExposureBias,
            this.FocalLength,
            this.MaxAperture,
            this.MeteringMode,
            this.SubjectDistance,
            this.LensMaker,
            this.LensModel,
            this.Contrast,
            this.Brightness,
            this.LightSource,
            this.Saturation,
            this.Sharpness,
            this.WhiteBalance,
            this.title,
            this.subject,
            this.Img,
            this.Comments,
            this.Author,
            this.Size,
            this.HorizontalResolution,
            this.VerticalResolution,
            this.CameraSerial,
            this.Rating});
            this.folderGridView.DataSource = this.photoWrapperBindingSource2;
            this.folderGridView.Location = new System.Drawing.Point(287, 12);
            this.folderGridView.Name = "folderGridView";
            this.folderGridView.ReadOnly = true;
            this.folderGridView.RowTemplate.Height = 20;
            this.folderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.folderGridView.Size = new System.Drawing.Size(1204, 426);
            this.folderGridView.TabIndex = 4;
            this.folderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folderGridView_CellContentClick);
            this.folderGridView.SelectionChanged += new System.EventHandler(this.folderGridView_SelectionChanged);
            this.folderGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.folderGridView_MouseDoubleClick);
            // 
            // CurrPicBox
            // 
            this.CurrPicBox.Location = new System.Drawing.Point(12, 111);
            this.CurrPicBox.Name = "CurrPicBox";
            this.CurrPicBox.Size = new System.Drawing.Size(249, 327);
            this.CurrPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrPicBox.TabIndex = 5;
            this.CurrPicBox.TabStop = false;
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(12, 95);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(45, 13);
            this.previewLabel.TabIndex = 6;
            this.previewLabel.Text = "Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Refine By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(None)",
            "Date",
            "Title",
            "Subject",
            "Comments",
            "Author",
            "Camera Maker",
            "Camera Model"});
            this.comboBox1.Location = new System.Drawing.Point(350, 482);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // refineButton
            // 
            this.refineButton.Location = new System.Drawing.Point(750, 480);
            this.refineButton.Name = "refineButton";
            this.refineButton.Size = new System.Drawing.Size(106, 23);
            this.refineButton.TabIndex = 9;
            this.refineButton.Text = "Go";
            this.refineButton.UseVisualStyleBackColor = true;
            this.refineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contains:";
            // 
            // refineTermBox
            // 
            this.refineTermBox.Location = new System.Drawing.Point(534, 482);
            this.refineTermBox.Name = "refineTermBox";
            this.refineTermBox.Size = new System.Drawing.Size(197, 20);
            this.refineTermBox.TabIndex = 11;
            this.refineTermBox.TextChanged += new System.EventHandler(this.refineTermBox_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(287, 447);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(1204, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // openFilesButton
            // 
            this.openFilesButton.Location = new System.Drawing.Point(15, 447);
            this.openFilesButton.Name = "openFilesButton";
            this.openFilesButton.Size = new System.Drawing.Size(246, 56);
            this.openFilesButton.TabIndex = 13;
            this.openFilesButton.Text = "Open Selected";
            this.openFilesButton.UseVisualStyleBackColor = true;
            this.openFilesButton.Click += new System.EventHandler(this.openFilesButton_Click);
            // 
            // ColConfigButton
            // 
            this.ColConfigButton.Location = new System.Drawing.Point(1298, 480);
            this.ColConfigButton.Name = "ColConfigButton";
            this.ColConfigButton.Size = new System.Drawing.Size(193, 23);
            this.ColConfigButton.TabIndex = 14;
            this.ColConfigButton.Text = "Column Config...";
            this.ColConfigButton.UseVisualStyleBackColor = true;
            this.ColConfigButton.Click += new System.EventHandler(this.ColConfigButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // DateModified
            // 
            this.DateModified.DataPropertyName = "DateModified";
            this.DateModified.HeaderText = "DateModified";
            this.DateModified.Name = "DateModified";
            this.DateModified.ReadOnly = true;
            // 
            // Dimensions
            // 
            this.Dimensions.DataPropertyName = "Dimensions";
            this.Dimensions.HeaderText = "Dimensions";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.HeaderText = "Tags";
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            // 
            // Copyright
            // 
            this.Copyright.DataPropertyName = "Copyright";
            this.Copyright.HeaderText = "Copyright";
            this.Copyright.Name = "Copyright";
            this.Copyright.ReadOnly = true;
            // 
            // BitDepth
            // 
            this.BitDepth.DataPropertyName = "BitDepth";
            this.BitDepth.HeaderText = "BitDepth";
            this.BitDepth.Name = "BitDepth";
            this.BitDepth.ReadOnly = true;
            // 
            // CameraMaker
            // 
            this.CameraMaker.DataPropertyName = "CameraMaker";
            this.CameraMaker.HeaderText = "CameraMaker";
            this.CameraMaker.Name = "CameraMaker";
            this.CameraMaker.ReadOnly = true;
            // 
            // CameraModel
            // 
            this.CameraModel.DataPropertyName = "CameraModel";
            this.CameraModel.HeaderText = "CameraModel";
            this.CameraModel.Name = "CameraModel";
            this.CameraModel.ReadOnly = true;
            // 
            // FStop
            // 
            this.FStop.DataPropertyName = "FStop";
            this.FStop.HeaderText = "FStop";
            this.FStop.Name = "FStop";
            this.FStop.ReadOnly = true;
            // 
            // ExposureTime
            // 
            this.ExposureTime.DataPropertyName = "ExposureTime";
            this.ExposureTime.HeaderText = "ExposureTime";
            this.ExposureTime.Name = "ExposureTime";
            this.ExposureTime.ReadOnly = true;
            // 
            // ISOSpeed
            // 
            this.ISOSpeed.DataPropertyName = "ISOSpeed";
            this.ISOSpeed.HeaderText = "ISOSpeed";
            this.ISOSpeed.Name = "ISOSpeed";
            this.ISOSpeed.ReadOnly = true;
            // 
            // ExposureBias
            // 
            this.ExposureBias.DataPropertyName = "ExposureBias";
            this.ExposureBias.HeaderText = "ExposureBias";
            this.ExposureBias.Name = "ExposureBias";
            this.ExposureBias.ReadOnly = true;
            // 
            // FocalLength
            // 
            this.FocalLength.DataPropertyName = "FocalLength";
            this.FocalLength.HeaderText = "FocalLength";
            this.FocalLength.Name = "FocalLength";
            this.FocalLength.ReadOnly = true;
            // 
            // MaxAperture
            // 
            this.MaxAperture.DataPropertyName = "MaxAperture";
            this.MaxAperture.HeaderText = "MaxAperture";
            this.MaxAperture.Name = "MaxAperture";
            this.MaxAperture.ReadOnly = true;
            // 
            // MeteringMode
            // 
            this.MeteringMode.DataPropertyName = "MeteringMode";
            this.MeteringMode.HeaderText = "MeteringMode";
            this.MeteringMode.Name = "MeteringMode";
            this.MeteringMode.ReadOnly = true;
            // 
            // SubjectDistance
            // 
            this.SubjectDistance.DataPropertyName = "SubjectDistance";
            this.SubjectDistance.HeaderText = "SubjectDistance";
            this.SubjectDistance.Name = "SubjectDistance";
            this.SubjectDistance.ReadOnly = true;
            // 
            // LensMaker
            // 
            this.LensMaker.DataPropertyName = "LensMaker";
            this.LensMaker.HeaderText = "LensMaker";
            this.LensMaker.Name = "LensMaker";
            this.LensMaker.ReadOnly = true;
            // 
            // LensModel
            // 
            this.LensModel.DataPropertyName = "LensModel";
            this.LensModel.HeaderText = "LensModel";
            this.LensModel.Name = "LensModel";
            this.LensModel.ReadOnly = true;
            // 
            // Contrast
            // 
            this.Contrast.DataPropertyName = "Contrast";
            this.Contrast.HeaderText = "Contrast";
            this.Contrast.Name = "Contrast";
            this.Contrast.ReadOnly = true;
            // 
            // Brightness
            // 
            this.Brightness.DataPropertyName = "Brightness";
            this.Brightness.HeaderText = "Brightness";
            this.Brightness.Name = "Brightness";
            this.Brightness.ReadOnly = true;
            // 
            // LightSource
            // 
            this.LightSource.DataPropertyName = "LightSource";
            this.LightSource.HeaderText = "LightSource";
            this.LightSource.Name = "LightSource";
            this.LightSource.ReadOnly = true;
            // 
            // Saturation
            // 
            this.Saturation.DataPropertyName = "Saturation";
            this.Saturation.HeaderText = "Saturation";
            this.Saturation.Name = "Saturation";
            this.Saturation.ReadOnly = true;
            // 
            // Sharpness
            // 
            this.Sharpness.DataPropertyName = "Sharpness";
            this.Sharpness.HeaderText = "Sharpness";
            this.Sharpness.Name = "Sharpness";
            this.Sharpness.ReadOnly = true;
            // 
            // WhiteBalance
            // 
            this.WhiteBalance.DataPropertyName = "WhiteBalance";
            this.WhiteBalance.HeaderText = "WhiteBalance";
            this.WhiteBalance.Name = "WhiteBalance";
            this.WhiteBalance.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // HorizontalResolution
            // 
            this.HorizontalResolution.DataPropertyName = "HorizontalRes";
            this.HorizontalResolution.HeaderText = "HorizontalRes";
            this.HorizontalResolution.Name = "HorizontalResolution";
            this.HorizontalResolution.ReadOnly = true;
            // 
            // VerticalResolution
            // 
            this.VerticalResolution.DataPropertyName = "VerticalRes";
            this.VerticalResolution.HeaderText = "VerticalRes";
            this.VerticalResolution.Name = "VerticalResolution";
            this.VerticalResolution.ReadOnly = true;
            // 
            // CameraSerial
            // 
            this.CameraSerial.DataPropertyName = "CameraSerialNumber";
            this.CameraSerial.HeaderText = "CameraSerialNumber";
            this.CameraSerial.Name = "CameraSerial";
            this.CameraSerial.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Img";
            this.Img.HeaderText = "Img";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // photoWrapperBindingSource2
            // 
            this.photoWrapperBindingSource2.DataSource = typeof(Photo_Manager.PhotoWrapper);
            // 
            // photoWrapperBindingSource
            // 
            this.photoWrapperBindingSource.DataSource = typeof(Photo_Manager.PhotoWrapper);
            // 
            // photoWrapperBindingSource1
            // 
            this.photoWrapperBindingSource1.DataSource = typeof(Photo_Manager.PhotoWrapper);
            // 
            // PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1503, 509);
            this.Controls.Add(this.ColConfigButton);
            this.Controls.Add(this.openFilesButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.refineTermBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refineButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.CurrPicBox);
            this.Controls.Add(this.folderGridView);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.folderComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PF";
            this.Text = "Photo Freedom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoWrapperBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.Button AddFolderButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.DataGridView folderGridView;
        private System.Windows.Forms.BindingSource photoWrapperBindingSource;
        private System.Windows.Forms.BindingSource photoWrapperBindingSource1;
        private System.Windows.Forms.PictureBox CurrPicBox;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refineButton;
        private System.Windows.Forms.TextBox refineTermBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button openFilesButton;
        private System.Windows.Forms.BindingSource photoWrapperBindingSource2;
        private System.Windows.Forms.Button ColConfigButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copyright;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraMaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExposureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISOSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExposureBias;
        private System.Windows.Forms.DataGridViewTextBoxColumn FocalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAperture;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeteringMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn LensMaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn LensModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brightness;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sharpness;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhiteBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorizontalResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

