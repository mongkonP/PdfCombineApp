using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TORServices.Forms;

namespace PdfCombineApp
{
    internal static class clsExt
    {
        // ฟังก์ชัน CombinePDFs ทำงานแบบ async
       
        public static void ConvertWordToPdf(string wordFilePath, string pdfOutputPath)
        {
            Aspose.Words.Document doc = new Aspose.Words.Document(wordFilePath);
            doc.Save(pdfOutputPath, Aspose.Words.SaveFormat.Pdf);
        }
       public static void ConvertImageToPdf(string imageFilePath, string pdfOutputPath)
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XImage img = XImage.FromFile(imageFilePath);

                // ปรับขนาดรูปภาพให้พอดีกับหน้า PDF
                gfx.DrawImage(img, 0, 0, page.Width, page.Height);

                document.Save(pdfOutputPath);
            }
        }

        // อัปเดตรายการไฟล์ใน ListBox
        public static void UpdateFileList(ListBox listBoxFiles,List<string> selectedFiles)
        {
            listBoxFiles.Items.Clear();
            foreach (string file in selectedFiles)
            {
                listBoxFiles.Items.Add(file);
            }
        }
    }
}
