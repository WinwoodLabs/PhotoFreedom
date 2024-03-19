namespace Photo_Manager
{
    partial class bulkEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bulkEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.commentsBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.headerText = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.titleCheck = new System.Windows.Forms.CheckBox();
            this.subjectCheck = new System.Windows.Forms.CheckBox();
            this.commentsCheck = new System.Windows.Forms.CheckBox();
            this.authorCheck = new System.Windows.Forms.CheckBox();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(182, 60);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(200, 20);
            this.titleBox.TabIndex = 6;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(182, 91);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(200, 20);
            this.subjectBox.TabIndex = 7;
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(182, 123);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(200, 20);
            this.commentsBox.TabIndex = 8;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(182, 156);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(200, 20);
            this.authorBox.TabIndex = 9;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 18);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(65, 20);
            this.headerText.TabIndex = 10;
            this.headerText.Text = "Editing";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(471, 211);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 58);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // titleCheck
            // 
            this.titleCheck.AutoSize = true;
            this.titleCheck.Location = new System.Drawing.Point(84, 62);
            this.titleCheck.Name = "titleCheck";
            this.titleCheck.Size = new System.Drawing.Size(69, 17);
            this.titleCheck.TabIndex = 12;
            this.titleCheck.Text = "Change?";
            this.titleCheck.UseVisualStyleBackColor = true;
            // 
            // subjectCheck
            // 
            this.subjectCheck.AutoSize = true;
            this.subjectCheck.Location = new System.Drawing.Point(84, 93);
            this.subjectCheck.Name = "subjectCheck";
            this.subjectCheck.Size = new System.Drawing.Size(69, 17);
            this.subjectCheck.TabIndex = 13;
            this.subjectCheck.Text = "Change?";
            this.subjectCheck.UseVisualStyleBackColor = true;
            // 
            // commentsCheck
            // 
            this.commentsCheck.AutoSize = true;
            this.commentsCheck.Location = new System.Drawing.Point(84, 125);
            this.commentsCheck.Name = "commentsCheck";
            this.commentsCheck.Size = new System.Drawing.Size(69, 17);
            this.commentsCheck.TabIndex = 14;
            this.commentsCheck.Text = "Change?";
            this.commentsCheck.UseVisualStyleBackColor = true;
            // 
            // authorCheck
            // 
            this.authorCheck.AutoSize = true;
            this.authorCheck.Location = new System.Drawing.Point(84, 158);
            this.authorCheck.Name = "authorCheck";
            this.authorCheck.Size = new System.Drawing.Size(69, 17);
            this.authorCheck.TabIndex = 15;
            this.authorCheck.Text = "Change?";
            this.authorCheck.UseVisualStyleBackColor = true;
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(84, 190);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(69, 17);
            this.dateCheck.TabIndex = 16;
            this.dateCheck.Text = "Change?";
            this.dateCheck.UseVisualStyleBackColor = true;
            // 
            // bulkEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 281);
            this.Controls.Add(this.dateCheck);
            this.Controls.Add(this.authorCheck);
            this.Controls.Add(this.commentsCheck);
            this.Controls.Add(this.subjectCheck);
            this.Controls.Add(this.titleCheck);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bulkEditForm";
            this.Text = "Bulk Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox commentsBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox titleCheck;
        private System.Windows.Forms.CheckBox subjectCheck;
        private System.Windows.Forms.CheckBox commentsCheck;
        private System.Windows.Forms.CheckBox authorCheck;
        private System.Windows.Forms.CheckBox dateCheck;
    }
}