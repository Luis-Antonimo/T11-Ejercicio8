using System;

namespace T11_Ejercicio8
{
    public class Profesor : MiembroInstituto
    {

        private string materia;
        private string[] materias = { "Matemáticas", "Filosofía", "Física" };

        //Constructor
        public Profesor()
        {
            Random rnd = new Random();
            setEdad(rnd.Next(25, 66));
            materia = materias[rnd.Next(0, 3)];
        }

        public string getMateria()
        {
            return materia;
        }

        public void setMateria(string _materia)
        {
            this.materia = _materia;
        }

        public override void disponibilidad()
        {

            Random rnd = new Random();
            if (rnd.Next(0, 100) < 20)
            {
                setdisponible(false);
            }
            else
            {
                setdisponible(true);
            }
        }
    }
}