using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Frontend
{
    public partial class RelatorioHabitacoes : Form
    {
        public RelatorioHabitacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    object cellValue = cell.Value;
                    pdfTable.AddCell(cellValue?.ToString() ?? string.Empty);
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";

            string dia , mes , ano;
            dia = DateTime.Now.Day.ToString();
            mes = DateTime.Now.Month.ToString();
            ano = DateTime.Now.Year.ToString();
            

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath +"RelatorioHabitacoes"+dia+mes+ano+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            // Abrir documento gerado
            System.Diagnostics.Process.Start(@"C:\\PDFs\\RelatorioHabitacoes" + dia + mes + ano + ".pdf");
        }

        private void RelatorioHabitacoes_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
            new DataColumn("Morada", typeof(string)),
            new DataColumn("Descricao",typeof(string)),
            new DataColumn("Custo Mensal", typeof(string))});
            dt.Rows.Add(1, "Rua da Estrada 31 Barcelos", "Casa bastante atrativa  , com internet", "210 por quarto");
            dt.Rows.Add(2, "Lugar da Ribeira Barcelos", "4 quartos todos mobilados ", "300 por quarto");
            dt.Rows.Add(3, "Rua da Marcelina Costa Esposende", "3 quartos para alugar Fem", "210 por quarto");
            dt.Rows.Add(4, "Rua da Esperança 31 Lisboa", "1 quarto disponivel com tudo incluido", "410 por quarto");
            this.dataGridView1.DataSource = dt;
        }
    }
}
