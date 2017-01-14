using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Frontend
{
    public partial class RelatorioAlunos : Form
    {
        public RelatorioAlunos()
        {
            InitializeComponent();
        }

        private void RelatorioAlunos_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
            new DataColumn("Name", typeof(string)),
            new DataColumn("Idade",typeof(string)),
            new DataColumn("Contactos", typeof(string))});
            dt.Rows.Add(1, "John Hammond", "21", "933 735 467");
            dt.Rows.Add(2, "Ricardo Costa", "22","252 637 347");
            dt.Rows.Add(3, "Andre Perro", "23","937 765 465");
            dt.Rows.Add(4, "Joao Costa", "34","252 367 265");
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            var pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                var cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var cellValue = cell.Value;
                    pdfTable.AddCell(cellValue?.ToString() ?? string.Empty);
                    //MessageBox.Show("Relatorio de Alunos Gerado com Sucesso !");

                }
            }

            //Exporting to PDF
            var folderPath = "C:\\PDFs\\";

            string dia, mes, ano;
            dia = DateTime.Now.Day.ToString();
            mes = DateTime.Now.Month.ToString();
            ano = DateTime.Now.Year.ToString();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (var stream = new FileStream(folderPath + "RelatorioAlunos" + dia + mes + ano + ".pdf", FileMode.Create))
            {
                var pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            
            }

            // Abrir documento gerado
            System.Diagnostics.Process.Start(@"C:\\PDFs\\RelatorioAlunos" + dia + mes + ano + ".pdf");

        }
    }
}
