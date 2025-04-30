namespace TA2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxDireccion = new System.Windows.Forms.TextBox();
            this.tboxArea = new System.Windows.Forms.TextBox();
            this.tboxGerente = new System.Windows.Forms.TextBox();
            this.tboxCapacidad = new System.Windows.Forms.TextBox();
            this.tboxNomCine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarCine = new System.Windows.Forms.Button();
            this.btnEliminarCine = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dtgviewCine = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.comboBoxSeleccionaCine = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTituloPelicula = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPelicula = new System.Windows.Forms.TextBox();
            this.textBoxDuracionPelicula = new System.Windows.Forms.TextBox();
            this.textBoxGeneroPelicula = new System.Windows.Forms.TextBox();
            this.textBoxValoracionPelicula = new System.Windows.Forms.TextBox();
            this.textBoxClasificacionPelicula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonRegistrarPelicula = new System.Windows.Forms.Button();
            this.buttonEliminarPelicula = new System.Windows.Forms.Button();
            this.buttonBuscarPelicula = new System.Windows.Forms.Button();
            this.buttonOrdenarPelicula = new System.Windows.Forms.Button();
            this.dataGridViewPelicula = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Mantenimiento de Cines";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(83, 68);
            this.tboxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(76, 20);
            this.tboxCodigo.TabIndex = 1;
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.Location = new System.Drawing.Point(83, 105);
            this.tboxDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(76, 20);
            this.tboxDireccion.TabIndex = 2;
            // 
            // tboxArea
            // 
            this.tboxArea.Location = new System.Drawing.Point(83, 140);
            this.tboxArea.Margin = new System.Windows.Forms.Padding(2);
            this.tboxArea.Name = "tboxArea";
            this.tboxArea.Size = new System.Drawing.Size(76, 20);
            this.tboxArea.TabIndex = 3;
            // 
            // tboxGerente
            // 
            this.tboxGerente.Location = new System.Drawing.Point(296, 68);
            this.tboxGerente.Margin = new System.Windows.Forms.Padding(2);
            this.tboxGerente.Name = "tboxGerente";
            this.tboxGerente.Size = new System.Drawing.Size(76, 20);
            this.tboxGerente.TabIndex = 4;
            // 
            // tboxCapacidad
            // 
            this.tboxCapacidad.Location = new System.Drawing.Point(296, 105);
            this.tboxCapacidad.Margin = new System.Windows.Forms.Padding(2);
            this.tboxCapacidad.Name = "tboxCapacidad";
            this.tboxCapacidad.Size = new System.Drawing.Size(76, 20);
            this.tboxCapacidad.TabIndex = 5;
            // 
            // tboxNomCine
            // 
            this.tboxNomCine.Location = new System.Drawing.Point(296, 140);
            this.tboxNomCine.Margin = new System.Windows.Forms.Padding(2);
            this.tboxNomCine.Name = "tboxNomCine";
            this.tboxNomCine.Size = new System.Drawing.Size(76, 20);
            this.tboxNomCine.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "area(m2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gerente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NomCine";
            // 
            // btnRegistrarCine
            // 
            this.btnRegistrarCine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrarCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCine.Location = new System.Drawing.Point(416, 68);
            this.btnRegistrarCine.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCine.Name = "btnRegistrarCine";
            this.btnRegistrarCine.Size = new System.Drawing.Size(134, 48);
            this.btnRegistrarCine.TabIndex = 13;
            this.btnRegistrarCine.Text = "Registrar Cine";
            this.btnRegistrarCine.UseVisualStyleBackColor = false;
            this.btnRegistrarCine.Click += new System.EventHandler(this.btnRegistrarCine_Click);
            // 
            // btnEliminarCine
            // 
            this.btnEliminarCine.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCine.Location = new System.Drawing.Point(588, 68);
            this.btnEliminarCine.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCine.Name = "btnEliminarCine";
            this.btnEliminarCine.Size = new System.Drawing.Size(105, 48);
            this.btnEliminarCine.TabIndex = 14;
            this.btnEliminarCine.Text = "Eliminar Cine";
            this.btnEliminarCine.UseVisualStyleBackColor = false;
            this.btnEliminarCine.Click += new System.EventHandler(this.btnEliminarCine_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(410, 130);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 33);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Orchid;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(579, 130);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(133, 33);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dtgviewCine
            // 
            this.dtgviewCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewCine.Location = new System.Drawing.Point(21, 193);
            this.dtgviewCine.Margin = new System.Windows.Forms.Padding(2);
            this.dtgviewCine.Name = "dtgviewCine";
            this.dtgviewCine.RowHeadersWidth = 51;
            this.dtgviewCine.RowTemplate.Height = 24;
            this.dtgviewCine.Size = new System.Drawing.Size(580, 240);
            this.dtgviewCine.TabIndex = 17;
            this.dtgviewCine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgviewCine_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightPink;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(686, 232);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 176);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxSeleccionaCine
            // 
            this.comboBoxSeleccionaCine.FormattingEnabled = true;
            this.comboBoxSeleccionaCine.Location = new System.Drawing.Point(21, 459);
            this.comboBoxSeleccionaCine.Name = "comboBoxSeleccionaCine";
            this.comboBoxSeleccionaCine.Size = new System.Drawing.Size(196, 21);
            this.comboBoxSeleccionaCine.TabIndex = 19;
            this.comboBoxSeleccionaCine.Click += new System.EventHandler(this.btnSeleccionaCineClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Selecciona el cine";
            // 
            // textBoxTituloPelicula
            // 
            this.textBoxTituloPelicula.Location = new System.Drawing.Point(18, 546);
            this.textBoxTituloPelicula.Name = "textBoxTituloPelicula";
            this.textBoxTituloPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxTituloPelicula.TabIndex = 21;
            // 
            // textBoxCodigoPelicula
            // 
            this.textBoxCodigoPelicula.Location = new System.Drawing.Point(22, 506);
            this.textBoxCodigoPelicula.Name = "textBoxCodigoPelicula";
            this.textBoxCodigoPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoPelicula.TabIndex = 22;
            this.textBoxCodigoPelicula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDuracionPelicula
            // 
            this.textBoxDuracionPelicula.Location = new System.Drawing.Point(425, 506);
            this.textBoxDuracionPelicula.Name = "textBoxDuracionPelicula";
            this.textBoxDuracionPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuracionPelicula.TabIndex = 23;
            // 
            // textBoxGeneroPelicula
            // 
            this.textBoxGeneroPelicula.Location = new System.Drawing.Point(231, 546);
            this.textBoxGeneroPelicula.Name = "textBoxGeneroPelicula";
            this.textBoxGeneroPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneroPelicula.TabIndex = 24;
            // 
            // textBoxValoracionPelicula
            // 
            this.textBoxValoracionPelicula.Location = new System.Drawing.Point(231, 506);
            this.textBoxValoracionPelicula.Name = "textBoxValoracionPelicula";
            this.textBoxValoracionPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxValoracionPelicula.TabIndex = 25;
            // 
            // textBoxClasificacionPelicula
            // 
            this.textBoxClasificacionPelicula.Location = new System.Drawing.Point(421, 546);
            this.textBoxClasificacionPelicula.Name = "textBoxClasificacionPelicula";
            this.textBoxClasificacionPelicula.Size = new System.Drawing.Size(100, 20);
            this.textBoxClasificacionPelicula.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Codigo de pelicula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Titulo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Valoracion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Genero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Duracion Minutos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Clasificacion";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // buttonRegistrarPelicula
            // 
            this.buttonRegistrarPelicula.Location = new System.Drawing.Point(561, 490);
            this.buttonRegistrarPelicula.Name = "buttonRegistrarPelicula";
            this.buttonRegistrarPelicula.Size = new System.Drawing.Size(102, 34);
            this.buttonRegistrarPelicula.TabIndex = 35;
            this.buttonRegistrarPelicula.Text = "Registrar pelicula";
            this.buttonRegistrarPelicula.UseVisualStyleBackColor = true;
            this.buttonRegistrarPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminarPelicula
            // 
            this.buttonEliminarPelicula.Location = new System.Drawing.Point(561, 530);
            this.buttonEliminarPelicula.Name = "buttonEliminarPelicula";
            this.buttonEliminarPelicula.Size = new System.Drawing.Size(102, 36);
            this.buttonEliminarPelicula.TabIndex = 36;
            this.buttonEliminarPelicula.Text = "Eliminar pelicula";
            this.buttonEliminarPelicula.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarPelicula
            // 
            this.buttonBuscarPelicula.Location = new System.Drawing.Point(686, 530);
            this.buttonBuscarPelicula.Name = "buttonBuscarPelicula";
            this.buttonBuscarPelicula.Size = new System.Drawing.Size(102, 36);
            this.buttonBuscarPelicula.TabIndex = 37;
            this.buttonBuscarPelicula.Text = "Buscar pelicula";
            this.buttonBuscarPelicula.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenarPelicula
            // 
            this.buttonOrdenarPelicula.Location = new System.Drawing.Point(686, 488);
            this.buttonOrdenarPelicula.Name = "buttonOrdenarPelicula";
            this.buttonOrdenarPelicula.Size = new System.Drawing.Size(102, 36);
            this.buttonOrdenarPelicula.TabIndex = 38;
            this.buttonOrdenarPelicula.Text = "Ordenar pelicula";
            this.buttonOrdenarPelicula.UseVisualStyleBackColor = true;
            this.buttonOrdenarPelicula.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewPelicula
            // 
            this.dataGridViewPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelicula.Location = new System.Drawing.Point(22, 588);
            this.dataGridViewPelicula.Name = "dataGridViewPelicula";
            this.dataGridViewPelicula.Size = new System.Drawing.Size(671, 213);
            this.dataGridViewPelicula.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(811, 813);
            this.Controls.Add(this.dataGridViewPelicula);
            this.Controls.Add(this.buttonOrdenarPelicula);
            this.Controls.Add(this.buttonBuscarPelicula);
            this.Controls.Add(this.buttonEliminarPelicula);
            this.Controls.Add(this.buttonRegistrarPelicula);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxClasificacionPelicula);
            this.Controls.Add(this.textBoxValoracionPelicula);
            this.Controls.Add(this.textBoxGeneroPelicula);
            this.Controls.Add(this.textBoxDuracionPelicula);
            this.Controls.Add(this.textBoxCodigoPelicula);
            this.Controls.Add(this.textBoxTituloPelicula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSeleccionaCine);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgviewCine);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminarCine);
            this.Controls.Add(this.btnRegistrarCine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxNomCine);
            this.Controls.Add(this.tboxCapacidad);
            this.Controls.Add(this.tboxGerente);
            this.Controls.Add(this.tboxArea);
            this.Controls.Add(this.tboxDireccion);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CINE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.TextBox tboxDireccion;
        private System.Windows.Forms.TextBox tboxArea;
        private System.Windows.Forms.TextBox tboxGerente;
        private System.Windows.Forms.TextBox tboxCapacidad;
        private System.Windows.Forms.TextBox tboxNomCine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarCine;
        private System.Windows.Forms.Button btnEliminarCine;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dtgviewCine;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox comboBoxSeleccionaCine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTituloPelicula;
        private System.Windows.Forms.TextBox textBoxCodigoPelicula;
        private System.Windows.Forms.TextBox textBoxDuracionPelicula;
        private System.Windows.Forms.TextBox textBoxGeneroPelicula;
        private System.Windows.Forms.TextBox textBoxValoracionPelicula;
        private System.Windows.Forms.TextBox textBoxClasificacionPelicula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonRegistrarPelicula;
        private System.Windows.Forms.Button buttonEliminarPelicula;
        private System.Windows.Forms.Button buttonBuscarPelicula;
        private System.Windows.Forms.Button buttonOrdenarPelicula;
        private System.Windows.Forms.DataGridView dataGridViewPelicula;
    }
}

