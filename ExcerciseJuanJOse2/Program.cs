using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseJuanJOse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la opcion del ejercicio que desea ejecutar");
            ushort opcion = ushort.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:  Funciones.Excercise1(); break;
                case 2: Funciones.Excercise2(); break;
                case 3: Funciones.Excercise3(); break;
                case 4: Funciones.Excercise4(); break;
                case 5: Funciones.Excercise5(); break;
                case 6: Funciones.Excercise6(); break;
                case 7: Funciones.Excercise7(); break;
                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}
