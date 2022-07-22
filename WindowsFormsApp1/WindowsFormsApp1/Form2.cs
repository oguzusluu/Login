using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        void List()
        {


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-FL2FF7V;Initial Catalog=Game;Integrated Security=True");
            da = new SqlDataAdapter("Select * From Gameİnfo", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Gameİnfo");
            dataGridView1.DataSource = ds.Tables["Gameİnfo"];
            con.Close();

        }
    }
}
