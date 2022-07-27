using System;
 
namespace T11_Ejercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aula aula = new Aula();

            if (aula.darClases())
            {
                aula.notas();
            }
            Aula aula1 = new Aula();

            if (aula1.darClases())
            {
                aula1.notas();
            }
            Aula aula2 = new Aula();

            if (aula2.darClases())
            {
                aula2.notas();
            }
            Aula aula3 = new Aula();

            if (aula3.darClases())
            {
                aula3.notas();
            }
            Aula aula4 = new Aula();

            if (aula4.darClases())
            {
                aula4.notas();
            }
            Aula aula5 = new Aula();

            if (aula5.darClases())
            {
                aula5.notas();
            }
        }
    }
}