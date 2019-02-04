using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilCheck
{
    public partial class BestOilCheck : Form
    {
        public BestOilCheck()
        {
            InitializeComponent();
        }

        private void BestOilCheck_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            foreach (var file in files)
            {
                MessageBox.Show("You Dropped" + file);
                listBox1.Items.Add(file);
            }

            PdfDocument pdfDocument = new PdfDocument();
            pdfDocument.Info.Title = "Created by PDFsharp";

            PdfPage pdfPage = new PdfPage();
            XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
            XFont xFont = new XFont("Times New Roman", 10, XFontStyle.Bold);

            xGraphics.DrawString($"{File.ReadAllText(listBox1.Items[0] as string)}", xFont , 
                XBrushes.Black, new XRect(0,0, pdfPage.Width, pdfPage.Height), XStringFormats.Center);
            pdfDocument.AddPage(pdfPage);

            pdfDocument.AddPage(pdfPage);
            pdfDocument.Save(@"C:/Users/Anar/Desktop");


        }
    }
}
