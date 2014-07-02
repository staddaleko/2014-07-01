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

namespace BazyKontaktow
{
    public partial class Form1 : Form
    {
        const string NAZWAPLIKU = "osoby.xml";
        
        public Form1()
        {
            
            InitializeComponent();

            if (File.Exists("osoby.xml"))
            {
                dataSet = new DataSet();
                //dataSet.ReadXmlSchema("osobySchema.xml");
                dataSet.ReadXml("osoby.xml", XmlReadMode.ReadSchema);
                dataSet.AcceptChanges();
            }
            else
            {
                dataSet = Utworz();
            }

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        DataSet dataSet;

        public static DataSet Utworz() 
        {
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Osoby");
            DataColumn col = dt.Columns.Add("IDOsoby", typeof(int));
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.AutoIncrementStep = 1;
            dt.PrimaryKey = new DataColumn[] { col };

            dt.Columns.Add("Nazwisko", typeof(string));
            dt.Columns.Add("Imię", typeof(string));
            dt.Columns.Add("Mail", typeof(string));
            col = dt.Columns.Add("Telefon", typeof(string));//ponownie wykorzystana zmienna 'col'
            col.MaxLength = 9;
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.WriteXml(NAZWAPLIKU, XmlWriteMode.WriteSchema);
            dataSet.WriteXml("difdiagram.xml", XmlWriteMode.DiffGram);

        }

        private void buttonZapiszDane_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();//dialog zapisywania pliku
            dlg.Filter = "Pliki xml | *.xml";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataSet.WriteXml(dlg.FileName);
            }
        }

        private void buttonAkceptuj_Click(object sender, EventArgs e)
        {
            dataSet.AcceptChanges();//dzięki temu mamy śledzenie zmian w pliku diff-coś tam.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
