using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form load oldugunda combobox1 de ve datagridde ayarlanmış olan datasource member value vs
            //bilgileri otomatil ilgili yere yükleyen program


             // TODO: This line of code loads data into the 'ticari.Stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.ticari.Stok);
            // TODO: This line of code loads data into the 'ticari.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.ticari.category);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button clik oldugunda stok tablosundaki bilgileri datagrid e yükleyen program
            TicariTableAdapters.StokTableAdapter stokkadapter = new TicariTableAdapters.StokTableAdapter();
            stokkadapter.Fill(ticari.Stok);
            dataGridView1.DataSource = ticari.Stok;

        }
    }
}
