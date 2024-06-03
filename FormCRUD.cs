﻿using ExamenFInalDB.Data;
using ExamenFInalDB.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFInalDB
{
    public partial class FormCRUD : Form
    {
        ConexionDestinos conexionDestinos = new ConexionDestinos();
        Destino dest = new Destino();
        List<Destino> todos_losRegistros;
        List<Destino> registros_favoritos;
        CursorLista cursor1 = new CursorLista();


        // Lista de tipos de destino
        private string[] tiposDestinos = {
            "Ciudad",
            "Ciudad Histórica",
            "Isla",
            "Montaña",
            "Playa",
        };


        public FormCRUD()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (conexionDestinos.ProbarConexion())
            {
                MessageBox.Show("La conexion con la base de datos fue exitosa.");
            }
            else
            {
                MessageBox.Show("Algo falló al intentar establecer la conexion con la base de datos.");
            }

            comboBoxTipoDestino.Items.AddRange(tiposDestinos);
            ActualizarTotalRegistros();
        }


        //CREAR UN REGISTRO NUEVO
        private void buttonCrearRegistro_Click(object sender, EventArgs e)
        {
            if (validarDatosIngresados())
            {
                dest.Nombre = textBoxNombre.Text;
                dest.Pais = textBoxPais.Text;
                dest.TipoDestino = comboBoxTipoDestino.Text;
                dest.FechaLlegada = dateTimePickerLlegada.Value.Date;
                dest.FechaSalida = dateTimePickerSalida.Value.Date;
                dest.PresupuestoPromedio = decimal.Parse(textBoxPresupuestoProm.Text);
                dest.Puntuacion = Int32.Parse(numericUpDownPuntuacion.Text);
                dest.Favorito = checkBoxFavorito.Checked;


                if (conexionDestinos.CrearDestino(dest))
                {
                    MessageBox.Show("El registro fue creado exitosamente.");
                    dataGridViewRegistros.DataSource = conexionDestinos.ObtenerTodosLosRegistros();
                    ActualizarTotalRegistros();
                    textBoxID.Text = "";
                    textBoxNombre.Text = "";
                    textBoxPais.Text = "";
                    comboBoxTipoDestino.Text = "";
                    dateTimePickerLlegada.Value = DateTime.Now;
                    dateTimePickerSalida.Value = DateTime.Now;
                    textBoxPresupuestoProm.Text = "";
                    numericUpDownPuntuacion.Text = "";
                    checkBoxFavorito.Checked = false;
                }
                else
                {
                    MessageBox.Show("El registro no fue creado dentro de la base de datos.");
                }
            }
        }


        //MOSTRAR TODOS LOS REGISTROS
        private void buttonCargarTodosRegistros_Click(object sender, EventArgs e)
        {
            todos_losRegistros = conexionDestinos.ObtenerTodosLosRegistros();
            dataGridViewRegistros.DataSource = todos_losRegistros;

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }


        //MOSTRAR SOLO REGISTROS FAVORITOS
        private void buttonFiltrarFavoritos_Click(object sender, EventArgs e)
        {
            registros_favoritos = conexionDestinos.ObtenerRegistosFavoritos();
            dataGridViewRegistros.DataSource = registros_favoritos;
        }


        //BUSCAR UN REGISTRO POR ID
        private void buttonBuscarPorID_Click(object sender, EventArgs e)
        {
            if (textBoxBuscarPorId.Text != "")
            {
                int id_buscar = Int32.Parse(textBoxBuscarPorId.Text);

                if (id_buscar <= todos_losRegistros.Count)
                {
                    DataRow registro_encontrado = conexionDestinos.BuscarRegistroporID(id_buscar);
                    bool esFavorito;

                    textBoxID.Text = registro_encontrado["id"].ToString();
                    textBoxNombre.Text = registro_encontrado["nombre"].ToString();
                    textBoxPais.Text = registro_encontrado["pais"].ToString();
                    comboBoxTipoDestino.Text = registro_encontrado["tipo_destino"].ToString();
                    dateTimePickerLlegada.Text = registro_encontrado["fecha_llegada"].ToString();
                    dateTimePickerSalida.Text = registro_encontrado["fecha_salida"].ToString();
                    textBoxPresupuestoProm.Text = registro_encontrado["presupuesto_promedio"].ToString();
                    numericUpDownPuntuacion.Text = registro_encontrado["puntuacion"].ToString();

                    if (registro_encontrado["favorito"] is DBNull)
                    {
                        esFavorito = false;
                    }
                    else
                    {
                        esFavorito = Convert.ToBoolean(registro_encontrado["favorito"]);
                    }
                    checkBoxFavorito.Checked = esFavorito;

                    mostrarRegistroenDatagridView(id_buscar);
                    cursor1.actual = id_buscar - 1;
                    textBoxBuscarPorId.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontro registro con este id.");
                }
            }
            else
            {
                MessageBox.Show("Primero debes ingresar un id para poder buscarlo.");
            }
        }


        public void mostrarRegistroenDatagridView(int id)
        {
            DataRow fila = conexionDestinos.BuscarRegistroporID(id);
            DataTable dataRegistro = fila.Table.Clone();
            dataRegistro.Rows.Add(fila.ItemArray);
            dataGridViewRegistros.DataSource = dataRegistro;
        }


        //SELECCIONAR UN REGISTRO EN EL DATAGRIDIEW
        private void dataGridViewRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idRegistroSeleccionado = Convert.ToInt32(dataGridViewRegistros.Rows[e.RowIndex].Cells["id"].Value);
                DataRow registro = conexionDestinos.BuscarRegistroporID(idRegistroSeleccionado);
                bool esFavorito;

                if (registro != null)
                {
                    textBoxID.Text = registro["id"].ToString();
                    textBoxNombre.Text = registro["nombre"].ToString();
                    textBoxPais.Text = registro["pais"].ToString();
                    comboBoxTipoDestino.Text = registro["tipo_destino"].ToString();
                    dateTimePickerLlegada.Text = registro["fecha_llegada"].ToString();
                    dateTimePickerSalida.Text = registro["fecha_salida"].ToString();
                    textBoxPresupuestoProm.Text = registro["presupuesto_promedio"].ToString();
                    numericUpDownPuntuacion.Text = registro["puntuacion"].ToString();

                    if (registro["favorito"] is DBNull)
                    {
                        esFavorito = false;
                    }
                    else
                    {
                        esFavorito = Convert.ToBoolean(registro["favorito"]);
                    }

                    checkBoxFavorito.Checked = esFavorito;
                }

                cursor1.actual = idRegistroSeleccionado - 1;
            }
        }


        //ACTUALIZAR UN REGISTRO
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                if (validarDatosIngresados())
                {
                    dest.ID = Convert.ToInt32(textBoxID.Text);
                    dest.Nombre = textBoxNombre.Text;
                    dest.Pais = textBoxPais.Text;
                    dest.TipoDestino = comboBoxTipoDestino.Text;
                    dest.FechaLlegada = dateTimePickerLlegada.Value.Date;
                    dest.FechaSalida = dateTimePickerSalida.Value.Date;
                    dest.PresupuestoPromedio = decimal.Parse(textBoxPresupuestoProm.Text);
                    dest.Puntuacion = Int32.Parse(numericUpDownPuntuacion.Text);
                    dest.Favorito = checkBoxFavorito.Checked;

                    DialogResult resultado = MessageBox.Show("Estas seguro de que deseas actualizar este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        if (conexionDestinos.Actualizar(dest))
                        {
                            MessageBox.Show("El registro fue actualizado exitosamente.");
                            dataGridViewRegistros.DataSource = conexionDestinos.ObtenerTodosLosRegistros();
                            cursor1.actual = -1;
                            ActualizarTotalRegistros();
                            textBoxID.Text = "";
                            textBoxNombre.Text = "";
                            textBoxPais.Text = "";
                            comboBoxTipoDestino.Text = "";
                            dateTimePickerLlegada.Value = DateTime.Now;
                            dateTimePickerSalida.Value = DateTime.Now;
                            textBoxPresupuestoProm.Text = "";
                            numericUpDownPuntuacion.Text = "";
                            checkBoxFavorito.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("El registro no fue actualizado dentro de la base de datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Modificaciones no realizadas.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes dar clic en un registro para poder actualizarlo.");
            }
        }


        //ELIMINAR UN REGISTRO
        private void buttonEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                int id = Int32.Parse(textBoxID.Text);

                DialogResult resultado = MessageBox.Show("Estas seguro de que deseas eliminar permanentemente este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (conexionDestinos.Eliminar(id))
                    {
                        MessageBox.Show("El registro fue eliminado exitosamente.");
                        dataGridViewRegistros.DataSource = conexionDestinos.ObtenerTodosLosRegistros();
                        cursor1.actual = -1;
                        ActualizarTotalRegistros();
                        textBoxID.Text = "";
                        textBoxNombre.Text = "";
                        textBoxPais.Text = "";
                        comboBoxTipoDestino.Text = "";
                        dateTimePickerLlegada.Value = DateTime.Now;
                        dateTimePickerSalida.Value = DateTime.Now;
                        textBoxPresupuestoProm.Text = "";
                        numericUpDownPuntuacion.Text = "";
                        checkBoxFavorito.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado dentro de la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("Modificaciones no realizadas.");
                }
            }
            else
            {
                MessageBox.Show("Debes dar clic en un registro para poder eliminarlo.");
            }
        }


        //NAVEGACION DE REGISTROS
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (cursor1.actual > 0)
            {
                cursor1.actual--;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (cursor1.actual < cursor1.totalRegistros - 1)
            {
                cursor1.actual++;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }


            private void MostrarRegistroActual()
            {
                if (cursor1.actual >= 0 && cursor1.actual < cursor1.totalRegistros)
                {
                    Destino dest = todos_losRegistros[cursor1.actual];

                    textBoxID.Text = dest.ID.ToString();
                    textBoxNombre.Text = dest.Nombre.ToString();
                    textBoxPais.Text = dest.Pais.ToString();
                    comboBoxTipoDestino.Text = dest.TipoDestino.ToString();
                    dateTimePickerLlegada.Text = dest.FechaLlegada.ToString();
                    dateTimePickerSalida.Text = dest.FechaSalida.ToString();
                    textBoxPresupuestoProm.Text = dest.PresupuestoPromedio.ToString();
                    numericUpDownPuntuacion.Text = dest.Puntuacion.ToString();
                    checkBoxFavorito.Checked = dest.Favorito;
                }
            }
        
        
        //OBTENER TOTAL DE REGISTROS
        public void ActualizarTotalRegistros()
        {
            todos_losRegistros = conexionDestinos.ObtenerTodosLosRegistros();

            if (todos_losRegistros.Count > -1)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }


        //VALIDAR LOS DATOS INGRESADOS
        private bool validarDatosIngresados()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxPais.Text) || string.IsNullOrWhiteSpace(comboBoxTipoDestino.Text) ||
                string.IsNullOrWhiteSpace(textBoxPresupuestoProm.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (Array.IndexOf(tiposDestinos, comboBoxTipoDestino.Text) == -1)
            {
                MessageBox.Show("El tipo de destino solo puede ser una de las opciones dadas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (dateTimePickerLlegada.Value.Date > dateTimePickerSalida.Value.Date)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de llegada.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!decimal.TryParse(textBoxPresupuestoProm.Text, out decimal presupuestoPromedio))
            {
                MessageBox.Show("El presupuesto promedio debe ser un valor decimal.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!int.TryParse(numericUpDownPuntuacion.Text, out int puntuacion) && (puntuacion < 0 && puntuacion > 10))
            {
                MessageBox.Show("La puntuación debe ser un valor entero entre 0 y 10.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
