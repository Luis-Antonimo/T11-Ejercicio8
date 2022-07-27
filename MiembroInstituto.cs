using System;

namespace T11_Ejercicio8
{
    abstract public class MiembroInstituto
    {
        private string nombre;
        private string sexo;
        private int edad;
        private bool disponible;
        private const int hombre = 0;

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String _nombre)
        {
            this.nombre = _nombre;
        }

        public string getSexo()
        {
            return sexo;
        }

        public void setSexo(string _sexo)
        {
            this.sexo = _sexo;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int _edad)
        {
            this.edad = _edad;
        }

        public bool getdisponible()
        {
            return disponible;
        }

        public void setdisponible(bool _disponible)
        {
            this.disponible = _disponible;
        }

        //Constructores
        public MiembroInstituto()
        {
            Random rnd = new Random();
            int sexoAdeterminar;
            sexoAdeterminar = rnd.Next(0, 2);
            if (sexoAdeterminar == hombre)
            {
                sexo = "Hombre";
                nombre = nombresHombres[rnd.Next(0, 16)];
            }
            else
            {
                sexo = "Mujer";
                nombre = nombresMujeres[rnd.Next(0, 16)];
            }
            disponibilidad();
        }

        public string[] nombresHombres = {"Ramón", "Jose", "Luis", "Antonio", "Jordi", "Juan", "Santiado",
            "Ricardo", "Francisco", "Manuel", "David", "Javier", "Jose Antonio", "Daniel", "Carlos", "Alex"};
        public string[] nombresMujeres = {"María","María Carmen", "Carmen", "Ana María", "Josefa", "María Pilar",
        "Isabel", "Laura", "María Dolores", "Ana", "Misericordia", "Cristina", "Marta", "Lucía", "María Isabel", "Sara"};

        //Las clases hijas deben tener este método heredado
        public abstract void disponibilidad();
    }
}

