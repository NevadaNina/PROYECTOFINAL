using System;
namespace PROYECTO_FINAL_2025_FB_NNNY
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
        }

        static void Ejercicio1()
        { 
           static int MayorDeLosDigitos(int numero)
           {
              int mayor = 0;

              while (numero > 0)
              {
                int digito = numero % 10;
                if (digito > mayor)
                {
                    mayor = digito;
                }
                numero /= 10;
              }

            return mayor;
           }

            static void Main()
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                int mayor = MayorDeLosDigitos(numero);
                Console.WriteLine($"El mayor dígito es: {mayor}");
            }
        }

        static void Ejercicio2 ()
        {
            static int SumaDeDigitosPares(int numero)
            {
                int suma = 0;

                while (numero > 0)
                {
                    int digito = numero % 10;
                    if (digito % 2 == 0)
                    {
                        suma += digito;
                    }
                    numero /= 10;
                }

                return suma;
            }

            static void Main()
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                int sumaPares = SumaDeDigitosPares(numero);
                Console.WriteLine($"La suma de los dígitos pares es: {sumaPares}");
            }
        }

        static void Ejercicio3()
        { 
        
        }

        static void Ejercicio4()
        {
            static bool EstaOrdenado(int numero)
            {
                int digitoAnterior = 10; 

                while (numero > 0)
                {
                    int digitoActual = numero % 10;
                    if (digitoActual > digitoAnterior)
                    {
                        return false; 
                    }
                    digitoAnterior = digitoActual;
                    numero /= 10;
                }

                return true; 
            }

            static void Main()
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                bool ordenado = EstaOrdenado(numero);
                Console.WriteLine(ordenado ? "TRUE" : "FALSE");
            }
        }

        static void Ejercicio5()
        {
            static void Main()
            {
                Console.Write("Ingrese un número: ");
                string numero = Console.ReadLine();

                int resultado = ContarImparesAntesDePar(numero);

                Console.WriteLine("Cantidad de dígitos impares antes de un par: " + resultado);
            }

            static int ContarImparesAntesDePar(string numero)
            {
                int contador = 0;

                for (int i = 1; i < numero.Length; i++) 
                {
                    if (EsPar(numero[i])) 
                    {
                        for (int j = 0; j < i; j++) 
                        {
                            if (!EsPar(numero[j])) contador++;
                        }
                        break; 
                    }
                }

                return contador;
            }

            static bool EsPar(char c)
            {
                return (c - '0') % 2 == 0; 
            }
        }
    }
}
