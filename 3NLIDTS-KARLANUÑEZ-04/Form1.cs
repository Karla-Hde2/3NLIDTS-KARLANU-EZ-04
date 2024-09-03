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

namespace _3NLIDTS_KARLANUÑEZ_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar tbt rbt
            tbtNombre.Clear();
            tbtApellido.Clear();
            tbtTelefono.Clear();
            tbtEdad.Clear();
            tbtEstatura.Clear();
            rbtMasculino.Checked = false;
            rbtFemenino.Checked = false;
        }

        private void bttguarda_Click(object sender, EventArgs e)
        {
            // Obtener los datos
            string nombres = tbtNombre.Text;
            string apellidos = tbtApellido.Text;
            string NumTel = tbtTelefono.Text;
            string estatura = tbtEstatura.Text;
            string edad = tbtEdad.Text;

            // Genero seleccionado
            string Genero = "";
            if (rbtMasculino.Checked)
            {
                Genero = "Hombre";
            }
            else if (rbtFemenino.Checked)
            {
                Genero = "Mujer";
            }
            // Cadena de datos
            string datos = $"Nombres: {nombres}\r\n Apellidos: {apellidos}\r\n Telefono: {NumTel} \r\n Estatura: {estatura} \r\n Edad: {edad} \r\n Genero: {Genero}";
            // Datos en un archivo
            string rutaArchivo = "C:\\Users\\Karli\\Documents\\datosform.txt";
            // Verificar si el archivo ya existe
            bool archivoexiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoexiste)
                {
                    // si el archivo existe, añadir el separador
                    writer.WriteLine("++++++++++++++++++++++++++");
                }
                writer.WriteLine(datos);
                // mostrar un mensaje con los datos guardados
                MessageBox.Show("Datos Guardados by: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //private void btnCancelar_Click(object sender, EventArgs e)
            {
                //Limpiar tbt rbt
                //tbtNombre.Clear();
                //tbtApellido.Clear();
                //tbtTelefono.Clear();
                //tbtEdad.Clear();
                //tbtEstatura.Clear();
                //rbtMasculino.Checked = false;
                //   rbtFemenino.Checked = false;
            }
        }
    }
}