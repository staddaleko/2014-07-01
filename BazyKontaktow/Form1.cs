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
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("osoby.xml"))
            {
                dataSet = new DataSet();
                //dataSet.ReadXmlSchema("osobySchema.xml");
                dataSet.ReadXml("osoby.xml", XmlReadMode.ReadSchema);
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
    }
}
