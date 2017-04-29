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

namespace GoodReads2BibTex
{
    public partial class Form1 : Form
    {

        public String CSVFileName;
        public Livro[] livros = new Livro[512]; // biblioteca de livros
        public int N; // numero de itens na bibliteca
        public char  _delimiter = ';';

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // File > Eventos..
            // Le os dados de eventos de um arquivo CSV.
            //
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "CSV Files (.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //  Get FileName
                CSVFileName = openFileDialog1.FileName;
                //  Read Eventos 
                livros = ReadCSVFile(CSVFileName, ref N);
                //
                // display point metadata
                rtf.AppendText("\nLeitura dos Eventos do Arquivo " + CSVFileName);
                rtf.AppendText("\nNúmero de Eventos =" + N.ToString("0000"));
                rtf.ScrollToCaret();
            }

        }

        public Livro[] ReadCSVFile( String _fileName, ref int _N)
        {


            Livro[] livros = new Livro[512];
            try
            {
                var reader = new StreamReader(File.OpenRead(_fileName));

                _N = 0;
                var line = reader.ReadLine();
                String[] header = line.Split(_delimiter);

                // 

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(_delimiter);
                    _N = _N + 1;
                    livros[_N] = new Livro(values);
                    rtf.AppendText("\nLivro "+_N+" "+ livros[_N].Title);
                }

            }
            catch (IOException e)
            {
                MessageBox.Show("Error while reading file\n" + _fileName + "\n" + e.ToString(),
                                "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rtf.AppendText("Leitura dos Eventos do Arquivo " + CSVFileName);
            return livros;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=1; i<=N; i++)
            {
                rtf.AppendText("\n" + livros[i].bibtex());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String clp = "";
            for (int i = 1; i <= N; i++)
            {
               clp = clp + livros[i].bibtex();
            }
            Clipboard.SetText(clp);
            rtf.AppendText("\n Lista de Livros copiados para o Clipboard");


        }
    }
}
