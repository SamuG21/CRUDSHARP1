using CRUDSHARP1.Config;
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

namespace CRUDSHARP1
{
    public partial class listado : Form
    {
        public listado()
        {
            InitializeComponent();
        }

        private void listado_Load(object sender, EventArgs e)
        {
            Conexion.Conetar();
            dataGridViewclientes.DataSource = Index();
        }

        public DataTable Index()
        {
            Conexion.Conetar();
            DataTable datatable = new DataTable();
            string sql = "SELECT * FROM listadodeclientes";
            SqlCommand cmd = new SqlCommand(sql, Conexion.Conetar());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatable);
            return datatable;
        }
    }
}
