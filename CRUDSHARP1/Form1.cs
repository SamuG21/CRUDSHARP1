using CRUDSHARP1.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSHARP1
{
    public partial class inicio : Form
    {
        private object textBoxName;

        public inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conetar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Insert

        private void botonagregar_Click(object sender, EventArgs e)
        {
            Conexion.Conetar();
            string SQL_Insert = "INSERT INTO listadodeclientes (NombreCompleto , TipoDocumento , Documento , FechaNacimiento , NumeroCelular , Correo , Ciudad , Direccion , Barrio , SalonVentasCercano , ProductosFavoritosPrimero , ProductosFavoritosSegundo , ProductosFavoritosTercero) VALUES (@NombreCompleto , @TipoDocumento , @Documento , @FechaNacimiento , @NumeroCelular , @Correo , @Ciudad , @Direccion , @Barrio , @SalonVentasCercano , @ProductosFavoritosPrimero , @ProductosFavoritosSegundo , @ProductosFavoritosTercero)";
            SqlCommand command1 = new SqlCommand(SQL_Insert, Conexion.Conetar());
            command1.Parameters.AddWithValue("@NombreCompleto", textBoxName);
            command1.Parameters.AddWithValue("@TipoDocumento", textBoxName);
            command1.Parameters.AddWithValue("@Documento", textBoxName);
            command1.Parameters.AddWithValue("@FechaNacimiento", textBoxName);
            command1.Parameters.AddWithValue("@NumeroCelular", textBoxName);
            command1.Parameters.AddWithValue("@Correo", textBoxName);
            command1.Parameters.AddWithValue("@Ciudad", textBoxName);
            command1.Parameters.AddWithValue("@Direccion", textBoxName);
            command1.Parameters.AddWithValue("@SalonVentasCercano", textBoxName);
            command1.Parameters.AddWithValue("@ProductosFavoritosPrimero", textBoxName);
            command1.Parameters.AddWithValue("@ProductosFavoritosSegundo", textBoxName);
            command1.Parameters.AddWithValue("@ProductosFavoritosTercero", textBoxName);

            command1.ExecuteNonQuery();

            MessageBox.Show("Datos correctamente insertados");
            DataGrid.DataSource = Index();
         }

        private void botonmirarlista_Click(object sender, EventArgs e)
        {
            Form inicio = new listado();
            inicio.Show();
        }
    }

]