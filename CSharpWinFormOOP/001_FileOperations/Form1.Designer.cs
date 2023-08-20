namespace _001_FileOperations
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolderBroswerDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnFolderBroswerDialog
            // 
            this.btnFolderBroswerDialog.Location = new System.Drawing.Point(560, 34);
            this.btnFolderBroswerDialog.Name = "btnFolderBroswerDialog";
            this.btnFolderBroswerDialog.Size = new System.Drawing.Size(214, 40);
            this.btnFolderBroswerDialog.TabIndex = 1;
            this.btnFolderBroswerDialog.Text = "Folder Browser Dialog";
            this.btnFolderBroswerDialog.UseVisualStyleBackColor = true;
            this.btnFolderBroswerDialog.Click += new System.EventHandler(this.BtnSelectLocation_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(560, 80);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(214, 40);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(560, 126);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(214, 40);
            this.btnSaveFileDialog.TabIndex = 3;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.BtnSaveFileDialog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Belge Yolu";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(156, 36);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(352, 28);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.Location = new System.Drawing.Point(560, 172);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(214, 40);
            this.btnSelectLocation.TabIndex = 6;
            this.btnSelectLocation.Text = "Select Location";
            this.btnSelectLocation.UseVisualStyleBackColor = true;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(560, 216);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(214, 40);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(156, 79);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(352, 28);
            this.txtFileName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Belge Adı";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(560, 262);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(214, 40);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(90, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 180);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 408);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelectLocation);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnFolderBroswerDialog);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolderBroswerDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox listBox1;
    }
}

