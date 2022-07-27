using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseJuanJOse2
{
    class Funciones
    {
        public static void Excercise1()
        {
            //Crea un array de 10 posiciones, pide los valores por consola y muestra el array.

            Console.WriteLine("Ha elegido la opcion 1 ");
            try
            {
                int[] valores = new int[10];

                for (int num = 0; num < valores.Length; num++)
                {
                    Console.WriteLine("Ingrese un numero");
                    int numero = int.Parse(Console.ReadLine());
                    valores[num] = numero;
                }

                Console.WriteLine("Sus valores ingresados son: \n");
                for (int i = 0; i < valores.Length; i++)
                {
                    Console.WriteLine(valores[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Debe ingresar numeros");
            }
        }

        public static void Excercise2()
        {
            //Sumar los valores de un array y mostrar el resultado.
            Console.WriteLine(" Has elegido la opcion 2. Ingresa 3 valores y seran sumados");
            try
            {
                int[] valores = new int[3];
                int suma = 0;

                for (int num = 0; num < valores.Length; num++)
                {
                    Console.WriteLine("Ingrese un numero");
                    int numero = int.Parse(Console.ReadLine());
                    suma += numero;
                    valores[num] = numero;

                }

                Console.WriteLine("Sus valores sumados son: " + suma);
            }
            catch (Exception)
            {

                Console.WriteLine("deben ser numeros");
            }
        }
        public static void Excercise3()
        {
            //Obtener la media de los valores de un array y mostrar el resultado.
            Console.WriteLine("Has elegido la opcion 3. Obtendras la media entre 5 valores");
            try
            {
                int[] valores = new int[5];
                int suma = 0;
                int media = 0;
                for (int num = 0; num < valores.Length; num++)
                {
                    Console.WriteLine("Ingrese un numero");
                    int numero = int.Parse(Console.ReadLine());
                    suma += numero;
                    media = suma / 5;
                    valores[num] = numero;

                }

                Console.WriteLine("La media es: " + media);
            }
            catch (Exception)
            {

                Console.WriteLine("deben ser numeros");
            }
        }
        public static void Excercise4()
        {
            //Crear un array de 5 posiciones e ingresar los valores por consola, luego Pedir un número por teclado
            //y multiplicar todos los valores del array con el número ingresado y mostrar el resultado como un nuevo array
            Console.WriteLine("Has elegido la opcion 4. Ingresa 5 numeros y otro numero para multiplicarlos");
            try
            {
                int[] valores = new int[5];
                int[] tabla = new int[5];


                for (int num = 0; num < valores.Length; num++)
                {
                    Console.WriteLine("Ingrese un numero a multiplicar");
                    int numero = int.Parse(Console.ReadLine());

                    valores[num] = numero;
                }

                Console.WriteLine("\nIngrese el numero de multiplicacion");
                int numeroMultiplicar = int.Parse(Console.ReadLine());
                for (int j = 0; j < tabla.Length; j++)

                {
                    int multiplicacion = numeroMultiplicar * valores[j];
                    tabla[j] = multiplicacion;


                }
                Console.WriteLine("\nSus valores multiplicados son: ");
                Console.WriteLine(String.Join("\n", tabla));
            }
            catch (Exception)
            {

                Console.WriteLine("deben ser numeros");
            }
        }

        public static void Excercise5()
        {
            //Ingresar un array  de 10 posiciones por consola, luego con el metodo Sort, ordenalos y mostrar su contenido
            Console.WriteLine("Ha elegido la opcion 5. ingresa 10 numeros y obten su orden");
            try
            {
                int[] valores = new int[10];

                for (int num = 0; num < valores.Length; num++)
                {
                    Console.WriteLine("Ingrese un numero");
                    int numero = int.Parse(Console.ReadLine());
                    valores[num] = numero;
                }
                Console.WriteLine("\nLos valores son> \n");
                Array.Sort(valores);
                Console.WriteLine(String.Join("\n", valores));

            }
            catch (Exception)
            {

                Console.WriteLine();
            }
        }
        public static void Excercise6()
        {
            //Ingresa por consola un array de números, muestra el mayor y el menor.
            Console.WriteLine("Has elegido la opcion 6. Ingresa valores y obten el mayor y menor");

            int[] valores = new int[4];

            for (int num = 0; num < valores.Length; num++)
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());
                valores[num] = numero;
            }
            Array.Sort(valores);
            Console.WriteLine(" El numero menor es: "+ valores[0]+" El numero mayor es: "+ valores[3]);
        }

        public static void Excercise7()
        {
            ////Ingresar un array por consola con nombres de estudiantes, luego pedir por consola una letra, luego filtrar los 
            ////estudiantes que su nombre empiecen por esa letra ingresada. (No importa si la letra es minuscula o mayuscula,
            ////se debe de filtrar iguamente)
            Console.WriteLine("Has elegido la opcion 7. Ingresa 4 nombres y realiza una busqueda por letra");
            string[] nombres = new string[4];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("Ingrese letra a buscar");
            string busqueda = Console.ReadLine();
            foreach (var nombre in nombres)
            {
                if (nombre.Contains(busqueda.ToLowerInvariant()))
                {
                    Console.WriteLine(nombre);
                }
            }
            Console.ReadLine();
           
           
        }
    }
}
