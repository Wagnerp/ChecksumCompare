namespace Checksum_Generator
{
    partial class CheckSum_Checker
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.filePicker = new System.Windows.Forms.Button();
            this.originalCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.algorithmBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileTextbox
            // 
            this.fileTextbox.Location = new System.Drawing.Point(119, 14);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.Size = new System.Drawing.Size(323, 20);
            this.fileTextbox.TabIndex = 0;
            // 
            // filePicker
            // 
            this.filePicker.Location = new System.Drawing.Point(448, 12);
            this.filePicker.Name = "filePicker";
            this.filePicker.Size = new System.Drawing.Size(75, 23);
            this.filePicker.TabIndex = 1;
            this.filePicker.Text = "Pick File";
            this.filePicker.UseVisualStyleBackColor = true;
            this.filePicker.Click += new System.EventHandler(this.fileEnter);
            // 
            // originalCheck
            // 
            this.originalCheck.Location = new System.Drawing.Point(119, 40);
            this.originalCheck.Name = "originalCheck";
            this.originalCheck.Size = new System.Drawing.Size(404, 20);
            this.originalCheck.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash to Check";
            // 
            // algorithmBox
            // 
            this.algorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmBox.FormattingEnabled = true;
            this.algorithmBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.algorithmBox.Location = new System.Drawing.Point(347, 66);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(176, 21);
            this.algorithmBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(448, 93);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 7;
            this.go.Text = "Check!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.checkHashes);
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Enabled = false;
            this.resultBox.Location = new System.Drawing.Point(347, 97);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(95, 17);
            this.resultBox.TabIndex = 8;
            this.resultBox.Text = "Hash Matches";
            this.resultBox.UseVisualStyleBackColor = true;
            // 
            // CheckSum_Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 127);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.algorithmBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originalCheck);
            this.Controls.Add(this.filePicker);
            this.Controls.Add(this.fileTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckSum_Checker";
            this.Text = "Checksum Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Button filePicker;
        private System.Windows.Forms.TextBox originalCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox algorithmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.CheckBox resultBox;
    }
}

