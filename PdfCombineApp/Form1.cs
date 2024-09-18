using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Pdf;

namespace PdfCombineApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // เก็บไฟล์ที่เลือกไว้ใน List
        private List<string> selectedFiles = new List<string>();
        // ฟังก์ชันสำหรับปุ่มเลือกไฟล์
        private void ButtonSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Select PDF files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFiles.AddRange(openFileDialog.FileNames);
                UpdateFileList();
            }
        }

        // อัปเดตรายการไฟล์ใน ListBox
        private void UpdateFileList()
        {
            listBoxFiles.Items.Clear();
            foreach (string file in selectedFiles)
            {
                listBoxFiles.Items.Add(file);
            }
        }

        // ฟังก์ชันสำหรับปุ่มรวมไฟล์
        private async void ButtonCombineFiles_Click(object sender, EventArgs e)
        {
            if (selectedFiles.Count == 0)
            {
                MessageBox.Show("Please select files to combine.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Save combined PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ปิดการใช้งานปุ่มขณะรวมไฟล์
                ButtonCombineFiles.Enabled = false;
                ButtonSelectFiles.Enabled = false;
                ButtonMoveUp.Enabled = false;
                ButtonMoveDown.Enabled = false;

                // ตั้งค่า ProgressBar
                myProgressBar1.SetMinMax(0,selectedFiles.Count);
              

                // เรียก CombinePDFs ด้วย async
                await CombinePDFs(saveFileDialog.FileName);

                // เปิดใช้งานปุ่มเมื่อรวมเสร็จ
                ButtonCombineFiles.Enabled = true;
                ButtonSelectFiles.Enabled = true;
                ButtonMoveUp.Enabled = true;
                ButtonMoveDown.Enabled = true;

                MessageBox.Show("PDFs combined successfully.");
            }
        }
        // ฟังก์ชัน CombinePDFs ทำงานแบบ async
        private async Task CombinePDFs(string outputFilePath)
        {
            await Task.Run(() =>
            {
                using (PdfDocument outputDocument = new PdfDocument())
                {
                    foreach (string file in selectedFiles)
                    {
                        using (PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                        {
                            foreach (PdfPage page in inputDocument.Pages)
                            {
                                outputDocument.AddPage(page);
                            }
                        }
                        myProgressBar1.AddValue();
                    }
                    outputDocument.Save(outputFilePath);
                }
            });
        }


        // ฟังก์ชันเลื่อนไฟล์ขึ้น
        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxFiles.SelectedIndex;
            if (selectedIndex > 0)
            {
                string file = selectedFiles[selectedIndex];
                selectedFiles.RemoveAt(selectedIndex);
                selectedFiles.Insert(selectedIndex - 1, file);
                UpdateFileList();
                listBoxFiles.SelectedIndex = selectedIndex - 1;
            }
        }

        // ฟังก์ชันเลื่อนไฟล์ลง
        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxFiles.SelectedIndex;
            if (selectedIndex < selectedFiles.Count - 1 && selectedIndex >= 0)
            {
                string file = selectedFiles[selectedIndex];
                selectedFiles.RemoveAt(selectedIndex);
                selectedFiles.Insert(selectedIndex + 1, file);
                UpdateFileList();
                listBoxFiles.SelectedIndex = selectedIndex + 1;
            }
        }
    }
}
