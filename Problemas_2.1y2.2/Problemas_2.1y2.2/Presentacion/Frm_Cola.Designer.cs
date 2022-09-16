namespace Problemas_2._1y2._2.Presentacion
{
    partial class Frm_Cola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_crearColeccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombreElemento = new System.Windows.Forms.TextBox();
            this.dgv_out = new System.Windows.Forms.DataGridView();
            this.btn_vacio = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_extraer = new System.Windows.Forms.Button();
            this.txt_tamano = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearColeccion
            // 
            this.btn_crearColeccion.Location = new System.Drawing.Point(11, 59);
            this.btn_crearColeccion.Name = "btn_crearColeccion";
            this.btn_crearColeccion.Size = new System.Drawing.Size(395, 23);
            this.btn_crearColeccion.TabIndex = 29;
            this.btn_crearColeccion.Text = "Crear Coleccion";
            this.btn_crearColeccion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nombre de la Colección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tamaño de la colección";
            // 
            // txt_nombreElemento
            // 
            this.txt_nombreElemento.Location = new System.Drawing.Point(11, 286);
            this.txt_nombreElemento.Name = "txt_nombreElemento";
            this.txt_nombreElemento.Size = new System.Drawing.Size(395, 23);
            this.txt_nombreElemento.TabIndex = 26;
            // 
            // dgv_out
            // 
            this.dgv_out.AllowUserToAddRows = false;
            this.dgv_out.AllowUserToDeleteRows = false;
            this.dgv_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_out.Location = new System.Drawing.Point(11, 103);
            this.dgv_out.Name = "dgv_out";
            this.dgv_out.ReadOnly = true;
            this.dgv_out.RowTemplate.Height = 25;
            this.dgv_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_out.Size = new System.Drawing.Size(395, 150);
            this.dgv_out.TabIndex = 25;
            // 
            // btn_vacio
            // 
            this.btn_vacio.Location = new System.Drawing.Point(254, 315);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(75, 23);
            this.btn_vacio.TabIndex = 24;
            this.btn_vacio.Text = "Vacio";
            this.btn_vacio.UseVisualStyleBackColor = true;
            // 
            // btn_primero
            // 
            this.btn_primero.Location = new System.Drawing.Point(173, 315);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(75, 23);
            this.btn_primero.TabIndex = 23;
            this.btn_primero.Text = "Primero";
            this.btn_primero.UseVisualStyleBackColor = true;
            // 
            // btn_extraer
            // 
            this.btn_extraer.Location = new System.Drawing.Point(92, 315);
            this.btn_extraer.Name = "btn_extraer";
            this.btn_extraer.Size = new System.Drawing.Size(75, 23);
            this.btn_extraer.TabIndex = 22;
            this.btn_extraer.Text = "Extraer";
            this.btn_extraer.UseVisualStyleBackColor = true;
            // 
            // txt_tamano
            // 
            this.txt_tamano.Location = new System.Drawing.Point(11, 30);
            this.txt_tamano.Name = "txt_tamano";
            this.txt_tamano.Size = new System.Drawing.Size(395, 23);
            this.txt_tamano.TabIndex = 21;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(11, 315);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 20;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(335, 315);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Frm_Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 348);
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
            this.Name = "Frm_Cola";
            this.Text = "Frm_Cola";
            this.Load += new System.EventHandler(this.Frm_Cola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_crearColeccion;
        private Label label4;
        private Label label3;
        private TextBox txt_nombreElemento;
        private DataGridView dgv_out;
        private Button btn_vacio;
        private Button btn_primero;
        private Button btn_extraer;
        private TextBox txt_tamano;
        private Button btn_agregar;
        private Button btn_salir;
    }
}