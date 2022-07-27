using System;

namespace T11_Ejercicio8
{
    public class Alumno : MiembroInstituto
    {
        private int calificacion;

        public Alumno()
        {
            Random rnd = new Random();
            calificacion = rnd.Next(0, 11);
            setEdad(rnd.Next(12, 19));
        }

        public int getCalificacion()
        {
            return calificacion;
        }

        public void setCalificacion(int _calificacion)
        {
            this.calificacion = _calificacion;
        }


        public override void disponibilidad()
        {
            Random rnd = new Random();

            if (rnd.Next(0, 100) < 50)
            {
                setdisponible(false);
            }
            else
            {
                setdisponible(true);
            }
        }

        public string toString()
        {
            return "Nombre: " + getNombre() + " , sexo: " + getSexo() + " , nota: " + calificacion;
        }
    }
}