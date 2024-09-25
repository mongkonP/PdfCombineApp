namespace PdfCombineApp
{
    partial class frmConvert2PDF
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
            panel1 = new Panel();
            myProgressBar1 = new TORServices.Forms.MyProgressBar();
            ButtonConvertFiles = new Button();
            ButtonMoveDown = new Button();
            ButtonMoveUp = new Button();
            ButtonSelectFiles = new Button();
            listBoxFiles = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(myProgressBar1);
            panel1.Controls.Add(ButtonConvertFiles);
            panel1.Controls.Add(ButtonMoveDown);
            panel1.Controls.Add(ButtonMoveUp);
            panel1.Controls.Add(ButtonSelectFiles);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 115);
            panel1.TabIndex = 2;
            // 
            // myProgressBar1
            // 
            myProgressBar1.Dock = DockStyle.Bottom;
            myProgressBar1.Location = new Point(0, 78);
            myProgressBar1.Name = "myProgressBar1";
            myProgressBar1.Size = new Size(923, 37);
            myProgressBar1.TabIndex = 4;
            // 
            // ButtonConvertFiles
            // 
            ButtonConvertFiles.Font = new Font("Segoe UI", 15.75F);
            ButtonConvertFiles.Location = new Point(445, 12);
            ButtonConvertFiles.Name = "ButtonConvertFiles";
            ButtonConvertFiles.Size = new Size(206, 50);
            ButtonConvertFiles.TabIndex = 3;
            ButtonConvertFiles.Text = "Covert Files 2 PDF";
            ButtonConvertFiles.UseVisualStyleBackColor = true;
            ButtonConvertFiles.Click += ButtonConvertFiles_Click;
            // 
            // ButtonMoveDown
            // 
            ButtonMoveDown.BackgroundImage = Properties.Resources.Down_move01;
            ButtonMoveDown.BackgroundImageLayout = ImageLayout.Center;
            ButtonMoveDown.Font = new Font("Segoe UI", 15.75F);
            ButtonMoveDown.Location = new Point(349, 12);
            ButtonMoveDown.Name = "ButtonMoveDown";
            ButtonMoveDown.Size = new Size(75, 50);
            ButtonMoveDown.TabIndex = 2;
            ButtonMoveDown.UseVisualStyleBackColor = true;
            ButtonMoveDown.Click += ButtonMoveDown_Click;
            // 
            // ButtonMoveUp
            // 
            ButtonMoveUp.BackgroundImage = Properties.Resources.Up_move01;
            ButtonMoveUp.BackgroundImageLayout = ImageLayout.Center;
            ButtonMoveUp.Font = new Font("Segoe UI", 15.75F);
            ButtonMoveUp.Location = new Point(254, 12);
            ButtonMoveUp.Name = "ButtonMoveUp";
            ButtonMoveUp.Size = new Size(75, 50);
            ButtonMoveUp.TabIndex = 1;
            ButtonMoveUp.UseVisualStyleBackColor = true;
            ButtonMoveUp.Click += ButtonMoveUp_Click;
            // 
            // ButtonSelectFiles
            // 
            ButtonSelectFiles.Font = new Font("Segoe UI", 15.75F);
            ButtonSelectFiles.Location = new Point(12, 12);
            ButtonSelectFiles.Name = "ButtonSelectFiles";
            ButtonSelectFiles.Size = new Size(223, 50);
            ButtonSelectFiles.TabIndex = 0;
            ButtonSelectFiles.Text = "Select  Files";
            ButtonSelectFiles.UseVisualStyleBackColor = true;
            ButtonSelectFiles.Click += ButtonSelectFiles_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Dock = DockStyle.Fill;
            listBoxFiles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 30;
            listBoxFiles.Location = new Point(0, 115);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(923, 490);
            listBoxFiles.TabIndex = 3;
            // 
            // frmConvert2PDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 605);
            Controls.Add(listBoxFiles);
            Controls.Add(panel1);
            Name = "frmConvert2PDF";
            Text = "frmConvert2PDF";
            Load += frmConvert2PDF_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TORServices.Forms.MyProgressBar myProgressBar1;
        private Button ButtonConvertFiles;
        private Button ButtonMoveDown;
        private Button ButtonMoveUp;
        private Button ButtonSelectFiles;
        private ListBox listBoxFiles;
    }
}