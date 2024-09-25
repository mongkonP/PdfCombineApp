using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfCombineApp
{
    public partial class frmConvert2PDF : Form
    {
        public frmConvert2PDF()
        {
            InitializeComponent();
        }
        List<string> Files;
        private void ButtonSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Word or Image Files (*.docx;*.jpg;*.png)|*.docx;*.jpg;*.png",
                Title = "Select Word or Image files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Files.AddRange(openFileDialog.FileNames);
                clsExt.UpdateFileList(this.listBoxFiles, Files); 
            }
        }

        private void frmConvert2PDF_Load(object sender, EventArgs e)
        {
            Files = new List<string>();
        }

        // ฟังก์ชันเลื่อนไฟล์ขึ้น
        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxFiles.SelectedIndex;
            if (selectedIndex > 0)
            {
                string file = Files[selectedIndex];
                Files.RemoveAt(selectedIndex);
                Files.Insert(selectedIndex - 1, file);
                clsExt.UpdateFileList(listBoxFiles, Files);
                listBoxFiles.SelectedIndex = selectedIndex - 1;
            }
        }

        // ฟังก์ชันเลื่อนไฟล์ลง
        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxFiles.SelectedIndex;
            if (selectedIndex < Files.Count - 1 && selectedIndex >= 0)
            {
                string file = Files[selectedIndex];
                Files.RemoveAt(selectedIndex);
                Files.Insert(selectedIndex + 1, file);
                clsExt.UpdateFileList(listBoxFiles, Files);
                listBoxFiles.SelectedIndex = selectedIndex + 1;
            }
        }


        private void ButtonConvertFiles_Click(object sender, EventArgs e)
        {
            if (Files.Count == 0)
            {
                MessageBox.Show("Please select files to convert.");
                return;
            }

            // ปิดการใช้งานปุ่มขณะทำการแปลงไฟล์
            ButtonConvertFiles.Enabled = false;
            ButtonSelectFiles.Enabled = false;
            ButtonMoveUp.Enabled = false;
            ButtonMoveDown.Enabled = false;
            // ตั้งค่า ProgressBar
            myProgressBar1.SetMinMax(0, Files.Count);
            foreach (string file in Files)
            {
                string outputFilePath = System.IO.Path.ChangeExtension(file, ".pdf");

                if (file.ToLower().EndsWith(".docx") || file.ToLower().EndsWith(".doc"))
                {
                     clsExt.ConvertWordToPdf(file, outputFilePath);
                }
                else if (file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png"))
                {
                    clsExt.ConvertImageToPdf(file, outputFilePath);
                }

                myProgressBar1.AddValue(); // เพิ่มค่า ProgressBar
            }

            // เปิดใช้งานปุ่มเมื่อเสร็จสิ้น
            ButtonConvertFiles.Enabled = true;
            ButtonSelectFiles.Enabled = true;
            ButtonMoveUp.Enabled = true;
            ButtonMoveDown.Enabled = true;

            MessageBox.Show("Files converted successfully.");
        }
    }
}
