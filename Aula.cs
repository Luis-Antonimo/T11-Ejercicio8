using System;

namespace T11_Ejercicio8
{
    public class Aula
    {
        private int identificador;
        private string materia;
        private Profesor profesor;
        private Alumno[] alumnos;

        private string[] materiasAula = { "Matemáticas", "Filosofía", "Física" };
        private const int numMaxEstudiantes = 30;

        public Aula()
        {
            Random rnd = new Random();
            identificador = rnd.Next(1, 11);
            materia = materiasAula[rnd.Next(0, 3)];
            profesor = new Profesor();
            alumnos = new Alumno[numMaxEstudiantes];
            creaAlumnos();
        }

        private void creaAlumnos()
        {
            //bucle para crear objetos en array
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = new Alumno();
            }
        }

        private bool asistenciaAlumnos()
        {
            int counter = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i].getdisponible())
                {
                    counter++;
                }
            }

            Console.WriteLine("Han asistido " + counter + " alumnos");

            return counter >= ((int)(alumnos.Length / 2));
        }

        public bool darClases()
        {

            if (!profesor.getdisponible())
            {
                Console.WriteLine("El profesor no esta, por lo que no se puede dar clase");
                return false;
            }
            else if (!profesor.getMateria().Equals(materia))
            {
                Console.WriteLine("La materia del profesor y del aula no es la misma. No se puede dar clase");
                return false;
            }
            else if (!asistenciaAlumnos())
            {
                Console.WriteLine("No hay suficiente asistencia. No se puede dar clase");
                return false;
            }

            Console.WriteLine("Se puede dar clase");
            return true;

        }

        public void notas()
        {
            int chicosApro = 0;
            int chicasApro = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i].getCalificacion() >= 5)
                {
                    if (alumnos[i].getSexo() == "Hombre")
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }
                    Console.WriteLine(alumnos[i].toString());
                }
            }
            Console.WriteLine("Hay " + chicosApro + " chicos y " + chicasApro + " chicas aprobados/as");
        }

    }
}