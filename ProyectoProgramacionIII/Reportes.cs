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

namespace ProyectoProgra
{
    public partial class Reportes : Form
    {
        List<clsAbastecimientos> abastes = new List<clsAbastecimientos>();
        public Reportes()
        {
            InitializeComponent();
        }

        public void LeerAbastecimientos()
        {

            string fileName = "Abastecimientos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //Se crea una lista temporal para agreagar propietarios
                clsAbastecimientos abastecimiento = new clsAbastecimientos();
                abastecimiento.NoBomba = int.Parse(reader.ReadLine());
                abastecimiento.FechaAbas = DateTime.Parse(reader.ReadLine());
                abastecimiento.NombreCliente = reader.ReadLine();
                abastecimiento.TipoAbas = reader.ReadLine();
                abastecimiento.Importe = decimal.Parse(reader.ReadLine());
                abastecimiento.Formallenado = reader.ReadLine();
                //agregar al propietario a la lista de propietarios
                abastes.Add(abastecimiento);
            }
            reader.Close();
        }

        public void MostrarDatos()
        {

            dgvInformacion.DataSource = null;
            dgvInformacion.DataSource = informacion;
            dgvInformacion.Refresh();
        }

        public void CargarAlquileres()
        {


            foreach (clsAlquileres alquiler in alquileres)
            {
                clsClientes cliente = clientes.FirstOrDefault(c => c.Nit == alquiler.Nit);
                if (cliente != null)
                {

                    clsVehiculos vehiculo = vehiculos.FirstOrDefault(v => v.Placa == alquiler.Placa);
                    if (vehiculo != null)
                    {

                        // Calcular el total a pagar

                        decimal totalPagar = alquiler.KilometrosRecorridos * vehiculo.PrecioKlm;


                        clsInformacion reporte = new clsInformacion
                        {
                            Nombre = cliente.Nombre,
                            Placa = vehiculo.Placa,
                            Modelo = vehiculo.Modelo,
                            Marca = vehiculo.Marca,
                            Color = vehiculo.Color,
                            PrecioKm = vehiculo.PrecioKlm,
                            Fechadevolucion = alquiler.FechaDevolucion,
                            Totalpagar = totalPagar,
                        };
                        informacion.Add(reporte);


                    }




                }

            }

            MostrarDatos();
        }



        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
