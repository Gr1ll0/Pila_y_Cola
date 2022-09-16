namespace Problemas_2._1y2._2.Presentacion
{
    partial class Frm_Pila
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_tamano = new System.Windows.Forms.TextBox();
            this.btn_extraer = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_vacio = new System.Windows.Forms.Button();
            this.dgv_out = new System.Windows.Forms.DataGridView();
            this.txt_nombreElemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_crearColeccion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 313);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_tamano
            // 
            this.txt_tamano.Location = new System.Drawing.Point(12, 28);
            this.txt_tamano.Name = "txt_tamano";
            this.txt_tamano.Size = new System.Drawing.Size(393, 23);
            this.txt_tamano.TabIndex = 1;
            // 
            // btn_extraer
            // 
            this.btn_extraer.Location = new System.Drawing.Point(93, 313);
            this.btn_extraer.Name = "btn_extraer";
            this.btn_extraer.Size = new System.Drawing.Size(75, 23);
            this.btn_extraer.TabIndex = 2;
            this.btn_extraer.Text = "Extraer";
            this.btn_extraer.UseVisualStyleBackColor = true;
            this.btn_extraer.Click += new System.EventHandler(this.btn_extraer_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Location = new System.Drawing.Point(174, 313);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(75, 23);
            this.btn_primero.TabIndex = 3;
            this.btn_primero.Text = "Primero";
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_vacio
            // 
            this.btn_vacio.Location = new System.Drawing.Point(255, 313);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(75, 23);
            this.btn_vacio.TabIndex = 4;
            this.btn_vacio.Text = "Vacio";
            this.btn_vacio.UseVisualStyleBackColor = true;
            this.btn_vacio.Click += new System.EventHandler(this.btn_vacio_Click);
            // 
            // dgv_out
            // 
            this.dgv_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_out.Location = new System.Drawing.Point(12, 101);
            this.dgv_out.Name = "dgv_out";
            this.dgv_out.RowTemplate.Height = 25;
            this.dgv_out.Size = new System.Drawing.Size(399, 150);
            this.dgv_out.TabIndex = 5;
            // 
            // txt_nombreElemento
            // 
            this.txt_nombreElemento.Location = new System.Drawing.Point(12, 284);
            this.txt_nombreElemento.Name = "txt_nombreElemento";
            this.txt_nombreElemento.Size = new System.Drawing.Size(393, 23);
            this.txt_nombreElemento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamaño de la colección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de la Colección";
            // 
            // btn_crearColeccion
            // 
            this.btn_crearColeccion.Location = new System.Drawing.Point(12, 57);
            this.btn_crearColeccion.Name = "btn_crearColeccion";
            this.btn_crearColeccion.Size = new System.Drawing.Size(399, 23);
            this.btn_crearColeccion.TabIndex = 9;
            this.btn_crearColeccion.Text = "Crear Coleccion";
            this.btn_crearColeccion.UseVisualStyleBackColor = true;
            this.btn_crearColeccion.Click += new System.EventHandler(this.btn_crearColeccion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(336, 313);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Frm_Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 349);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_crearColeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombreElemento);
            this.Controls.Add(this.dgv_out);
            this.Controls.Add(this.btn_vacio);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_extraer);
            this.Controls.Add(this.txt_tamano);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Frm_Pila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.Load += new System.EventHandler(this.Frm_Pila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregar;
        private TextBox txt_tamano;
        private Button btn_extraer;
        private Button btn_primero;
        private Button btn_vacio;
        private Button btn_crearColeccion;
        private DataGridView dgv_out;
        private TextBox txt_nombreElemento;
        private Label label3;
        private Label label4;
        private Button btn_salir;
    }
}