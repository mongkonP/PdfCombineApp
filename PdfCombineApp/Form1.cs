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
        // ����������͡���� List
        private List<string> selectedFiles = new List<string>();
        // �ѧ��ѹ����Ѻ�������͡���
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

        // �ѻവ��¡������ ListBox
        private void UpdateFileList()
        {
            listBoxFiles.Items.Clear();
            foreach (string file in selectedFiles)
            {
                listBoxFiles.Items.Add(file);
            }
        }

        // �ѧ��ѹ����Ѻ����������
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
                // �Դ�����ҹ�������������
                ButtonCombineFiles.Enabled = false;
                ButtonSelectFiles.Enabled = false;
                ButtonMoveUp.Enabled = false;
                ButtonMoveDown.Enabled = false;

                // ��駤�� ProgressBar
                myProgressBar1.SetMinMax(0,selectedFiles.Count);
              

                // ���¡ CombinePDFs ���� async
                await CombinePDFs(saveFileDialog.FileName);

                // �Դ��ҹ����������������
                ButtonCombineFiles.Enabled = true;
                ButtonSelectFiles.Enabled = true;
                ButtonMoveUp.Enabled = true;
                ButtonMoveDown.Enabled = true;

                MessageBox.Show("PDFs combined successfully.");
            }
        }
        // �ѧ��ѹ CombinePDFs �ӧҹẺ async
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


        // �ѧ��ѹ����͹�����
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

        // �ѧ��ѹ����͹���ŧ
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
