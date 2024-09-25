using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Pdf;

namespace PdfCombineApp
{
    public partial class frmCombine : Form
    {
        public frmCombine()
        {
            InitializeComponent();
        }
        // ����������͡���� List
        private List<string> Files;
        // �ѧ��ѹ����Ѻ�������͡���
        private void ButtonSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF or Word Files (*.pdf)|*.pdf",
                Title = "Select PDF files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Files.AddRange(openFileDialog.FileNames);
                clsExt.UpdateFileList(listBoxFiles, Files);
            }
        }

     

        // �ѧ��ѹ����Ѻ����������
        private async void ButtonCombineFiles_Click(object sender, EventArgs e)
        {
            if (Files.Count == 0)
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
                myProgressBar1.SetMinMax(0, Files.Count);


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
        private  async Task CombinePDFs(string outputFilePath)
        {
            await Task.Run(() =>
            {
                using (PdfDocument outputDocument = new PdfDocument())
                {
                    foreach (string file in Files)
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
                string file = Files[selectedIndex];
                Files.RemoveAt(selectedIndex);
                Files.Insert(selectedIndex - 1, file);
                clsExt.UpdateFileList(listBoxFiles, Files);
                listBoxFiles.SelectedIndex = selectedIndex - 1;
            }
        }

        // �ѧ��ѹ����͹���ŧ
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

        private void frmCombine_Load(object sender, EventArgs e)
        {
            Files = new List<string>();
        }
    }
}
