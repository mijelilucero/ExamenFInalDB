using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFInalDB.Data.Model
{
    internal class Destino
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string TipoDestino { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal PresupuestoPromedio { get; set; }
        public int Puntuacion { get; set; }
        public bool Favorito { get; set; }



        //Constructor sin parametros
        public Destino() {}


        //Constructor con parametros
        public Destino(int id, string nombre, string pais, string tipo_destino, DateTime fecha_llegada, DateTime fecha_salida,
            decimal presupuesto_promedio, int puntuacion, bool favorito)
        {
            ID = id;
            Nombre = nombre;
            Pais = pais;
            TipoDestino = tipo_destino;
            FechaLlegada = fecha_llegada;
            FechaSalida = fecha_salida;
            PresupuestoPromedio = presupuesto_promedio;
            Puntuacion = puntuacion;
            Favorito = favorito;
        }
    }
}
