using Newtonsoft.Json;
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
        List<clsAbastecimientos> reportes = new List<clsAbastecimientos>();
        List<clsAbastecimientos> rep1 = new List<clsAbastecimientos>();

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


        //private void LeerJson()
        //{
        //    ////Se crea una lista con la misma estructura que tienen los datos en el archivo
        //    //List<clsAbastecimientos> lista = new List<clsAbastecimientos>();

        //    ////El nombre del archivo a utilizar
        //    string archivo = "Datos.json";

        //    //Se abre el archivo
        //    StreamReader jsonStream = File.OpenText(archivo);

        //    //Se Lee todo el contenido del archivo y el contenido leído se guarda en una variable cualquiera de tipo string.
        //    //aquí no se necesitan ciclos pues el método ReadToEnd() lee todo el contenido de una sola vez.
        //    string json = jsonStream.ReadToEnd();

        //    //Se cierra el archivo
        //    jsonStream.Close();

        //    //Se deserializa (convierte) la cadena json guardada en la variable, a la estructura que tiene la lista a donde se van a cargar los datos
        //    abastes = JsonConvert.DeserializeObject<List<clsAbastecimientos>>(json);
        //}

        public void MostrarDatos()
        {

            
        }

        public void CargarCierreCaja()
        {
            


            // Limpiar la lista de reportes antes de agregar nuevos datos
            rep1.Clear();

            // Agregar todos los registros filtrados a la lista de reportes
            foreach (var abastecimiento in abastes)
            {
                clsAbastecimientos reporte = new clsAbastecimientos
                {
                    NombreCliente = abastecimiento.NombreCliente,
                    FechaAbas = abastecimiento.FechaAbas,
                    TipoAbas = abastecimiento.TipoAbas,
                    Importe = abastecimiento.Importe,
                    Formallenado = abastecimiento.Formallenado,
                };
                rep1.Add(reporte);
            }

            dgvCierracaja.DataSource = null;
            dgvCierracaja.DataSource = rep1;
            dgvCierracaja.Refresh();

            // Ocultar la columna "NoBomba"
            if (dgvCierracaja.Columns["NoBomba"] != null)
            {
                dgvCierracaja.Columns["NoBomba"].Visible = false;
            }
        }

        public void CargarPrepago()
        {
            string busqueda = "Pre-pago";

            // Filtrar los registros que cumplen la condición de "Pre-pago"
            var prepagos = abastes.Where(v => v.Formallenado == busqueda);

            // Limpiar la lista de reportes antes de agregar nuevos datos
            reportes.Clear();

            // Agregar todos los registros filtrados a la lista de reportes
            foreach (var abastecimiento in prepagos)
            {
                clsAbastecimientos reporte = new clsAbastecimientos
                {
                    NombreCliente = abastecimiento.NombreCliente,
                    FechaAbas = abastecimiento.FechaAbas,
                    TipoAbas = abastecimiento.TipoAbas,
                    Importe = abastecimiento.Importe,
                    Formallenado = abastecimiento.Formallenado,
                };
                reportes.Add(reporte);
            }

            dgvAbasPrepago.DataSource = null;
            dgvAbasPrepago.DataSource = reportes;
            dgvAbasPrepago.Refresh();

            // Ocultar la columna "NoBomba"
            if (dgvAbasPrepago.Columns["NoBomba"] != null)
            {
                dgvAbasPrepago.Columns["NoBomba"].Visible = false;
            }
        }



        private void Reportes_Load(object sender, EventArgs e)
        {
            LeerAbastecimientos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarPrepago();
            CargarCierreCaja();
        }
    }
}
