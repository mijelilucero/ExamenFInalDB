using ExamenFInalDB.Data;
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
    public partial class Form1 : Form
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



        public Form1()
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
                MessageBox.Show("Algo fallo al intentar hacer la conexion con la base de datos.");
            }

            comboBoxTipoDestino.Items.AddRange(tiposDestinos);
            ActualizarTotalRegistros();
        }



        private void buttonCrearRegistro_Click(object sender, EventArgs e)
        {
            if (validarDatosIngresados())
            {
                dest.Nombre = textBoxNombre.Text;
                dest.Pais = textBoxPais.Text;
                dest.TipoDestino = comboBoxTipoDestino.Text;
                dest.FechaLlegada = dateTimePickerLlegada.Value;
                dest.FechaSalida = dateTimePickerSalida.Value;
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



        private void buttonCargarTodosRegistros_Click(object sender, EventArgs e)
        {
            todos_losRegistros = conexionDestinos.ObtenerTodosLosRegistros();
            dataGridViewRegistros.DataSource = todos_losRegistros;

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }



        private void buttonBuscarPorID_Click(object sender, EventArgs e)
        {
            if (textBoxBuscarPorId.Text != "")
            {
                int id_buscar = Int32.Parse(textBoxBuscarPorId.Text);
                DataRow registro_encontrado = conexionDestinos.BuscarRegistroporID(id_buscar);
                bool esFavorito;

                if (registro_encontrado != null)
                {
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
                    cursor1.actual = id_buscar - 1;
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


            if (!int.TryParse(numericUpDownPuntuacion.Text, out int puntuacion) && (puntuacion >= 0 && puntuacion <= 10))
            {
                MessageBox.Show("La puntuación debe ser un valor entero entre 0 y 10.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

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
                    dest.FechaLlegada = dateTimePickerLlegada.Value;
                    dest.FechaSalida = dateTimePickerSalida.Value;
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

        private void buttonFiltrarFavoritos_Click(object sender, EventArgs e)
        {
            registros_favoritos = conexionDestinos.ObtenerRegistosFavoritos();
            dataGridViewRegistros.DataSource = registros_favoritos;
        }

        
        //NAVEGACION DE REGISTROS
        private void MostrarRegistroActual()
        {
            if (cursor1.actual >= 0 && cursor1.actual < cursor1.totalRegistros)
            {
                Destino dest = todos_losRegistros[cursor1.actual];
                bool esFavorito;

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

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (cursor1.actual > 0) // Verificar antes de decrementar
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
            if (cursor1.actual < cursor1.totalRegistros - 1) // Verificar antes de incrementar
            {
                cursor1.actual++;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }


        public void ActualizarTotalRegistros()
        {
            todos_losRegistros = conexionDestinos.ObtenerTodosLosRegistros();

            if (todos_losRegistros.Count > -1)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }
    }
}
