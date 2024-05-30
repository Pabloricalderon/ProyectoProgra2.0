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
using Newtonsoft.Json;


namespace ProyectoProgra
{
    public partial class IngresoDatos : Form
    {
        
        clsContadores contadores = new clsContadores();
        private List<clsAbastecimientos> abastecimientos = new List<clsAbastecimientos>();

        public IngresoDatos()
        {
            InitializeComponent();
        }

       

        private void rbTanquelleno_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTanquelleno.Checked)
            {
                txtImporte.Enabled = false;
                txtImporte.Text = string.Empty;
            }
            else
            {
                txtImporte.Enabled = true;
            }
        }

        private void IngresarDatos(clsAbastecimientos nuevoAbastecimiento)
        {
            // Guarda el nuevo abastecimiento en el archivo
            using (FileStream stream = new FileStream("Abastecimientos.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(nuevoAbastecimiento.NoBomba);
                    writer.WriteLine(nuevoAbastecimiento.FechaAbas);
                    writer.WriteLine(nuevoAbastecimiento.NombreCliente);
                    writer.WriteLine(nuevoAbastecimiento.TipoAbas);
                    writer.WriteLine(nuevoAbastecimiento.Importe);
                    writer.WriteLine(nuevoAbastecimiento.Formallenado);
                }
            }

            // Guarda los contadores actualizados en el archivo
            using (FileStream stream = new FileStream("contadores.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                { 
                  writer.WriteLine(contadores.Cont1);
                    writer.WriteLine(contadores.Cont2);
                }
            }
        }

        private void Resetear()
        {
            txtNombre.Text = string.Empty;
            txtImporte.Text = string.Empty ;
            rbprepago.Checked = true;
            rbsuper.Checked = true;
            txtNombre.Focus();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            clsAbastecimientos temporal = new clsAbastecimientos();
            clsContadores tempo = new clsContadores();
            temporal.NombreCliente = txtNombre.Text;
            temporal.FechaAbas = dtpFecha.Value;
            if(rbsuper.Checked == true)
            {
                temporal.NoBomba = 1;
                temporal.TipoAbas = "Super";
                contadores.Cont1++;
            }
            else if (rbregular.Checked == true)
            {
                temporal.NoBomba = 2;
                temporal.TipoAbas = "Regular";
                contadores.Cont2++;
            }
            if(rbprepago.Checked ==  true)
            {
                temporal.Formallenado = "Pre-pago";
                temporal.Importe = decimal.Parse(txtImporte.Text);
                
            }
            else if (rbTanquelleno.Checked == true)
            {
                temporal.Formallenado = "Tanque lleno";
                
            }
            IngresarDatos(temporal);
           
            MessageBox.Show("Registro guardado, Inicie el llenado");
           guardarDatos();

        }
        void guardarDatos()
        {
            string json = JsonConvert.SerializeObject(abastecimientos);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Resetear();
        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
