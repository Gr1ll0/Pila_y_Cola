using Problemas_2._1y2._2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problemas_2._1y2._2.Presentacion
{
    public partial class Frm_Cola : Form
    {
        private Cola oCola;
        public Frm_Cola()
        {
            InitializeComponent();
        }

        private void Frm_Cola_Load(object sender, EventArgs e)
        {
            dgv_out.Columns.Add("nombre", "Nombre de la colección");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (oCola != null)
            {
                if (txt_nombreElemento.Text == "")
                {
                    MessageBox.Show("Cargue el nombre del elemento para agregarlo");
                }
                else
                {
                    string nombre_Obj = txt_nombreElemento.Text;

                    object oObjeto = new object();

                    oObjeto = nombre_Obj;

                    bool check;

                    check = oCola.añadir(oObjeto);

                    if (check == true)
                    {
                        MessageBox.Show("Se agrego exitosoamente");
                        dgv_out.Rows.Add(oObjeto);
                    }
                    else
                    {
                        MessageBox.Show("No se agrego");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colección");
            }
        }

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            if (oCola != null)
            {
                if (oCola.estaVacia() == true)
                {
                    object oObjeto = new object();
                    oObjeto = oCola.extraer();

                    MessageBox.Show("El elemento: " + oObjeto.ToString() + ". Se extrajo y se elimino");
                }
                else
                {
                    MessageBox.Show("La collección esta vacia, entonces no se puede extraer ningun elemento");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colección");
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            if (oCola != null)
            {
                object oObjeto = new object();

                if (oCola.estaVacia() == true)
                {
                    oObjeto = oCola.primero();

                    MessageBox.Show("El elemento: " + oObjeto.ToString() + ", es el primero");
                }
                else
                {
                    MessageBox.Show("La collección esta vacia, entonces no se puede saber el primero");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colección");
            }
        }

        private void btn_vacio_Click(object sender, EventArgs e)
        {
            if (oCola != null)
            {
                bool check;

                check = oCola.estaVacia();

                if (check == true)
                {
                    MessageBox.Show("La collección tiene al menos un elemento");
                }
                else
                {
                    MessageBox.Show("La collección esta vacia");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colección");
            }
        }

        private void btn_crearColeccion_Click(object sender, EventArgs e)
        {
            bool check_tamaño;
            int tamaño;

            check_tamaño = int.TryParse(txt_tamano.Text, out tamaño);

            if (check_tamaño == false)
            {
                MessageBox.Show("Igrese un valor entero para crear la lista");

            }
            else
            {
                oCola = Cola.ObtenerInstancia(tamaño);
                MessageBox.Show("La colección se creo con exito");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Frm_Main main = new Frm_Main();

            main.Show();
            this.Close();
        }
    }
}
