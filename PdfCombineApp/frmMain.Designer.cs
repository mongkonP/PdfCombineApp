namespace PdfCombineApp
{
    partial class frmMain
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmdCombine = new Button();
            cmdConvert = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 64, 64);
            flowLayoutPanel1.Controls.Add(cmdCombine);
            flowLayoutPanel1.Controls.Add(cmdConvert);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1094, 103);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // cmdCombine
            // 
            cmdCombine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdCombine.Image = Properties.Resources.pdf_icon;
            cmdCombine.ImageAlign = ContentAlignment.TopCenter;
            cmdCombine.Location = new Point(3, 3);
            cmdCombine.Name = "cmdCombine";
            cmdCombine.Size = new Size(166, 93);
            cmdCombine.TabIndex = 0;
            cmdCombine.Text = "Combine PDF";
            cmdCombine.TextAlign = ContentAlignment.BottomCenter;
            cmdCombine.UseVisualStyleBackColor = true;
            cmdCombine.Click += cmdCombine_Click;
            // 
            // cmdConvert
            // 
            cmdConvert.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdConvert.Image = Properties.Resources.analytics_docs_documents_graph_pdf_icon;
            cmdConvert.ImageAlign = ContentAlignment.TopCenter;
            cmdConvert.Location = new Point(175, 3);
            cmdConvert.Name = "cmdConvert";
            cmdConvert.Size = new Size(166, 93);
            cmdConvert.TabIndex = 1;
            cmdConvert.Text = "Combine PDF";
            cmdConvert.TextAlign = ContentAlignment.BottomCenter;
            cmdConvert.UseVisualStyleBackColor = true;
            cmdConvert.Click += cmdConvert_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 649);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button cmdCombine;
        private Button cmdConvert;
    }
}