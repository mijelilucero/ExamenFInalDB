namespace ExamenFInalDB
{
    partial class FormCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUD));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFavorito = new System.Windows.Forms.CheckBox();
            this.numericUpDownPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoDestino = new System.Windows.Forms.ComboBox();
            this.textBoxPresupuestoProm = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonCrearRegistro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBuscarPorId = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminarRegistro = new System.Windows.Forms.Button();
            this.buttonCargarTodosRegistros = new System.Windows.Forms.Button();
            this.buttonFiltrarFavoritos = new System.Windows.Forms.Button();
            this.buttonBuscarPorID = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuntuacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.dateTimePickerSalida);
            this.panel2.Controls.Add(this.dateTimePickerLlegada);
            this.panel2.Controls.Add(this.checkBoxFavorito);
            this.panel2.Controls.Add(this.numericUpDownPuntuacion);
            this.panel2.Controls.Add(this.comboBoxTipoDestino);
            this.panel2.Controls.Add(this.textBoxPresupuestoProm);
            this.panel2.Controls.Add(this.textBoxPais);
            this.panel2.Controls.Add(this.textBoxNombre);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 633);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(308, 416);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(210, 28);
            this.dateTimePickerSalida.TabIndex = 21;
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(46, 416);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(212, 28);
            this.dateTimePickerLlegada.TabIndex = 20;
            // 
            // checkBoxFavorito
            // 
            this.checkBoxFavorito.AutoSize = true;
            this.checkBoxFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.checkBoxFavorito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxFavorito.Location = new System.Drawing.Point(344, 566);
            this.checkBoxFavorito.Name = "checkBoxFavorito";
            this.checkBoxFavorito.Size = new System.Drawing.Size(100, 24);
            this.checkBoxFavorito.TabIndex = 19;
            this.checkBoxFavorito.Text = "Favorito";
            this.checkBoxFavorito.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPuntuacion
            // 
            this.numericUpDownPuntuacion.Location = new System.Drawing.Point(48, 566);
            this.numericUpDownPuntuacion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPuntuacion.Name = "numericUpDownPuntuacion";
            this.numericUpDownPuntuacion.Size = new System.Drawing.Size(157, 28);
            this.numericUpDownPuntuacion.TabIndex = 18;
            // 
            // comboBoxTipoDestino
            // 
            this.comboBoxTipoDestino.FormattingEnabled = true;
            this.comboBoxTipoDestino.Location = new System.Drawing.Point(275, 316);
            this.comboBoxTipoDestino.Name = "comboBoxTipoDestino";
            this.comboBoxTipoDestino.Size = new System.Drawing.Size(243, 30);
            this.comboBoxTipoDestino.TabIndex = 17;
            // 
            // textBoxPresupuestoProm
            // 
            this.textBoxPresupuestoProm.Location = new System.Drawing.Point(360, 483);
            this.textBoxPresupuestoProm.Name = "textBoxPresupuestoProm";
            this.textBoxPresupuestoProm.Size = new System.Drawing.Size(158, 28);
            this.textBoxPresupuestoProm.TabIndex = 16;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(225, 270);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(293, 28);
            this.textBoxPais.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(225, 225);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(293, 28);
            this.textBoxNombre.TabIndex = 14;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(225, 178);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(293, 28);
            this.textBoxID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(43, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Puntuación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(46, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Presupuesto promedio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(303, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha de salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(45, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de llegada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo de destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(45, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(144, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inolvidables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Viajes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewRegistros
            // 
            this.dataGridViewRegistros.AllowUserToAddRows = false;
            this.dataGridViewRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistros.Location = new System.Drawing.Point(626, 233);
            this.dataGridViewRegistros.Name = "dataGridViewRegistros";
            this.dataGridViewRegistros.RowHeadersWidth = 62;
            this.dataGridViewRegistros.RowTemplate.Height = 28;
            this.dataGridViewRegistros.Size = new System.Drawing.Size(677, 280);
            this.dataGridViewRegistros.TabIndex = 2;
            this.dataGridViewRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistros_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonCrearRegistro);
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 137);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSiguiente);
            this.groupBox1.Controls.Add(this.buttonAnterior);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(286, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 79);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegación de registros";
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSiguiente.BackgroundImage")));
            this.buttonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSiguiente.Location = new System.Drawing.Point(117, 31);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(48, 38);
            this.buttonSiguiente.TabIndex = 29;
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnterior.BackgroundImage")));
            this.buttonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAnterior.Location = new System.Drawing.Point(49, 31);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(48, 38);
            this.buttonAnterior.TabIndex = 28;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonCrearRegistro
            // 
            this.buttonCrearRegistro.Location = new System.Drawing.Point(76, 38);
            this.buttonCrearRegistro.Name = "buttonCrearRegistro";
            this.buttonCrearRegistro.Size = new System.Drawing.Size(139, 62);
            this.buttonCrearRegistro.TabIndex = 24;
            this.buttonCrearRegistro.Text = "Crear Registro";
            this.buttonCrearRegistro.UseVisualStyleBackColor = true;
            this.buttonCrearRegistro.Click += new System.EventHandler(this.buttonCrearRegistro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(898, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Buscar por id:";
            // 
            // textBoxBuscarPorId
            // 
            this.textBoxBuscarPorId.Location = new System.Drawing.Point(1071, 134);
            this.textBoxBuscarPorId.Name = "textBoxBuscarPorId";
            this.textBoxBuscarPorId.Size = new System.Drawing.Size(160, 26);
            this.textBoxBuscarPorId.TabIndex = 23;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(626, 551);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(136, 57);
            this.buttonActualizar.TabIndex = 25;
            this.buttonActualizar.Text = "Actualizar Registro";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminarRegistro
            // 
            this.buttonEliminarRegistro.Location = new System.Drawing.Point(794, 551);
            this.buttonEliminarRegistro.Name = "buttonEliminarRegistro";
            this.buttonEliminarRegistro.Size = new System.Drawing.Size(136, 57);
            this.buttonEliminarRegistro.TabIndex = 26;
            this.buttonEliminarRegistro.Text = "Eliminar Registro";
            this.buttonEliminarRegistro.UseVisualStyleBackColor = true;
            this.buttonEliminarRegistro.Click += new System.EventHandler(this.buttonEliminarRegistro_Click);
            // 
            // buttonCargarTodosRegistros
            // 
            this.buttonCargarTodosRegistros.Location = new System.Drawing.Point(1088, 562);
            this.buttonCargarTodosRegistros.Name = "buttonCargarTodosRegistros";
            this.buttonCargarTodosRegistros.Size = new System.Drawing.Size(214, 34);
            this.buttonCargarTodosRegistros.TabIndex = 27;
            this.buttonCargarTodosRegistros.Text = "Cargar todos los registros";
            this.buttonCargarTodosRegistros.UseVisualStyleBackColor = true;
            this.buttonCargarTodosRegistros.Click += new System.EventHandler(this.buttonCargarTodosRegistros_Click);
            // 
            // buttonFiltrarFavoritos
            // 
            this.buttonFiltrarFavoritos.Location = new System.Drawing.Point(626, 129);
            this.buttonFiltrarFavoritos.Name = "buttonFiltrarFavoritos";
            this.buttonFiltrarFavoritos.Size = new System.Drawing.Size(182, 36);
            this.buttonFiltrarFavoritos.TabIndex = 28;
            this.buttonFiltrarFavoritos.Text = "Mostrar solo favoritos";
            this.buttonFiltrarFavoritos.UseVisualStyleBackColor = true;
            this.buttonFiltrarFavoritos.Click += new System.EventHandler(this.buttonFiltrarFavoritos_Click);
            // 
            // buttonBuscarPorID
            // 
            this.buttonBuscarPorID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscarPorID.BackgroundImage")));
            this.buttonBuscarPorID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscarPorID.Location = new System.Drawing.Point(1256, 122);
            this.buttonBuscarPorID.Name = "buttonBuscarPorID";
            this.buttonBuscarPorID.Size = new System.Drawing.Size(47, 50);
            this.buttonBuscarPorID.TabIndex = 29;
            this.buttonBuscarPorID.UseVisualStyleBackColor = true;
            this.buttonBuscarPorID.Click += new System.EventHandler(this.buttonBuscarPorID_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1290, 708);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 48);
            this.panel3.TabIndex = 30;
            // 
            // FormCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1356, 755);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonBuscarPorID);
            this.Controls.Add(this.buttonFiltrarFavoritos);
            this.Controls.Add(this.buttonCargarTodosRegistros);
            this.Controls.Add(this.buttonEliminarRegistro);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxBuscarPorId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRegistros);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de destinos turísticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuntuacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoDestino;
        private System.Windows.Forms.TextBox textBoxPresupuestoProm;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
        private System.Windows.Forms.CheckBox checkBoxFavorito;
        private System.Windows.Forms.NumericUpDown numericUpDownPuntuacion;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBuscarPorId;
        private System.Windows.Forms.Button buttonCrearRegistro;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminarRegistro;
        private System.Windows.Forms.Button buttonCargarTodosRegistros;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonFiltrarFavoritos;
        private System.Windows.Forms.Button buttonBuscarPorID;
        private System.Windows.Forms.Panel panel3;
    }
}

