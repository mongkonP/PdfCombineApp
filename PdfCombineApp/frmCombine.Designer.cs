namespace PdfCombineApp
{
    partial class frmCombine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombine));
            panel1 = new Panel();
            myProgressBar1 = new TORServices.Forms.MyProgressBar();
            ButtonCombineFiles = new Button();
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
            panel1.Controls.Add(ButtonCombineFiles);
            panel1.Controls.Add(ButtonMoveDown);
            panel1.Controls.Add(ButtonMoveUp);
            panel1.Controls.Add(ButtonSelectFiles);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 115);
            panel1.TabIndex = 0;
            // 
            // myProgressBar1
            // 
            myProgressBar1.Dock = DockStyle.Bottom;
            myProgressBar1.Location = new Point(0, 78);
            myProgressBar1.Name = "myProgressBar1";
            myProgressBar1.Size = new Size(970, 37);
            myProgressBar1.TabIndex = 4;
            // 
            // ButtonCombineFiles
            // 
            ButtonCombineFiles.Location = new Point(445, 12);
            ButtonCombineFiles.Name = "ButtonCombineFiles";
            ButtonCombineFiles.Size = new Size(206, 50);
            ButtonCombineFiles.TabIndex = 3;
            ButtonCombineFiles.Text = "Combine Files";
            ButtonCombineFiles.UseVisualStyleBackColor = true;
            ButtonCombineFiles.Click += ButtonCombineFiles_Click;
            // 
            // ButtonMoveDown
            // 
            ButtonMoveDown.BackgroundImage = Properties.Resources.Down_move01;
            ButtonMoveDown.BackgroundImageLayout = ImageLayout.Center;
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
            ButtonMoveUp.Location = new Point(254, 12);
            ButtonMoveUp.Name = "ButtonMoveUp";
            ButtonMoveUp.Size = new Size(75, 50);
            ButtonMoveUp.TabIndex = 1;
            ButtonMoveUp.UseVisualStyleBackColor = true;
            ButtonMoveUp.Click += ButtonMoveUp_Click;
            // 
            // ButtonSelectFiles
            // 
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
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 30;
            listBoxFiles.Location = new Point(0, 115);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(970, 471);
            listBoxFiles.TabIndex = 1;
            // 
            // frmCombine
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 586);
            Controls.Add(listBoxFiles);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmCombine";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmCombine_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonCombineFiles;
        private Button ButtonMoveDown;
        private Button ButtonMoveUp;
        private Button ButtonSelectFiles;
        private ListBox listBoxFiles;
        private TORServices.Forms.MyProgressBar myProgressBar1;
    }
}
