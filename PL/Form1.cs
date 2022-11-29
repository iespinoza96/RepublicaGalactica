using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            ML.Maestro maestro = new ML.Maestro();
            ML.Result result = BL.Informe.GetAll();
            maestro.Maestros = result.Objects;

            dataGridView1.Columns.Add("NombreCaballero", "NombreCaballero");
            dataGridView1.Columns.Add("Rango Maestro(SI/NO)", "Rango Maestro(SI/NO)");
            dataGridView1.Columns.Add("Sistema estelar de combate", "Sistema estelar de combate");
            int i = 0;

            //dataGridView1.DataSource = empleado.Empleados;  //AGREGAR SIN FOREACH
           // dataGridView1.Columns[4].Visible = false;
            foreach (ML.Maestro maestro1 in maestro.Maestros)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = maestro1.OrdenJedi.Nombre;
                dataGridView1.Rows[i].Cells[1].Value = maestro1.Rango;
                dataGridView1.Rows[i].Cells[2].Value = maestro1.SistemasAmenazados.Sistema.Nombre;
                

                i++;
            }
            
        }
    }
}
