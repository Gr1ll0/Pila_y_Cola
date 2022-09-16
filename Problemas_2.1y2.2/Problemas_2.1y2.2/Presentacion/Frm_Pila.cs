using Problemas_2._1y2._2.Dominio;

namespace Problemas_2._1y2._2.Presentacion
{
    public partial class Frm_Pila : Form
    {
        private Pila oPila;
        public Frm_Pila()
        {
            InitializeComponent();
        }

        private void Frm_Pila_Load(object sender, EventArgs e)
        {
            dgv_out.Columns.Add("nombre", "Nombre de la colecci�n");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (oPila != null)
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

                    check = oPila.a�adir(oObjeto);

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
                MessageBox.Show("No se ha creado una colecci�n");
            }
}

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            if(oPila != null)
            {
                if(oPila.estaVacia() == true)
                {
                    object oObjeto = new object();
                    oObjeto = oPila.extraer();

                    MessageBox.Show("El elemento: " + oObjeto.ToString() + ". Se extrajo y se elimino");
                }
                else
                {
                    MessageBox.Show("La collecci�n esta vacia, entonces no se puede extraer ningun elemento");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colecci�n");
            }
}

        private void btn_primero_Click(object sender, EventArgs e)
        {
            if(oPila != null)
            {
                object oObjeto = new object();

                if (oPila.estaVacia() == true)
                {
                    oObjeto = oPila.primero();

                    MessageBox.Show("El elemento: " + oObjeto.ToString() + ", es el primero");
                }
                else
                {
                    MessageBox.Show("La collecci�n esta vacia, entonces no se puede saber el primero");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colecci�n");
            }
}

        private void btn_vacio_Click(object sender, EventArgs e)
        {
            if (oPila != null)
            {
                bool check;

                check = oPila.estaVacia();

                if (check == true)
                {
                    MessageBox.Show("La collecci�n tiene al menos un elemento");
                }
                else
                {
                    MessageBox.Show("La collecci�n esta vacia");
                }
            }
            else
            {
                MessageBox.Show("No se ha creado una colecci�n");
            }
        }

        private void btn_crearColeccion_Click(object sender, EventArgs e)
        {
            bool check_tama�o;
            int tama�o;

            check_tama�o = int.TryParse(txt_tamano.Text, out tama�o);

            if(check_tama�o == false)
            {
                MessageBox.Show("Igrese un valor entero para crear la lista");

            }
            else
            {
                oPila = Pila.ObtenerInstancia(tama�o);
                MessageBox.Show("La colecci�n se creo con exito");
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