namespace Photo_Manager
{
    partial class ColumnConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnConfigForm));
            this.BasicListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CameraListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LensListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BasicListBox1
            // 
            this.BasicListBox1.FormattingEnabled = true;
            this.BasicListBox1.Items.AddRange(new object[] {
            "Date",
            "Title",
            "Subject",
            "Img",
            "Comments",
            "Author",
            "Size",
            "Date Modified",
            "Dimensions",
            "Horizontal Resolution",
            "Vertical Resolution",
            "Bit Depth"});
            this.BasicListBox1.Location = new System.Drawing.Point(12, 41);
            this.BasicListBox1.Name = "BasicListBox1";
            this.BasicListBox1.Size = new System.Drawing.Size(125, 199);
            this.BasicListBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic";
            // 
            // CameraListBox
            // 
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.Items.AddRange(new object[] {
            "Camera Maker",
            "Camera Model",
            "Camera Serial",
            "FStop",
            "Exposure Time",
            "Focal Length",
            "Max Aperture",
            "Metering Mode",
            "Subject Distance"});
            this.CameraListBox.Location = new System.Drawing.Point(144, 41);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(118, 199);
            this.CameraListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Camera";
            // 
            // LensListBox
            // 
            this.LensListBox.FormattingEnabled = true;
            this.LensListBox.Items.AddRange(new object[] {
            "Lens Maker",
            "Lens Model",
            "Contrast",
            "Brightness",
            "Light Source",
            "Saturation",
            "Sharpness",
            "White Balance"});
            this.LensListBox.Location = new System.Drawing.Point(268, 41);
            this.LensListBox.Name = "LensListBox";
            this.LensListBox.Size = new System.Drawing.Size(120, 199);
            this.LensListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lens";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LensListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CameraListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BasicListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColumnConfigForm";
            this.Text = "Column Configuration";
            this.Load += new System.EventHandler(this.ColumnConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox BasicListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CameraListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox LensListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}