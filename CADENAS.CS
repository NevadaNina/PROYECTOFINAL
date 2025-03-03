using System;
namespace PROYECTO_FINAL_2025_FB_NNNY
{
    class Cadenas 
    {
        static void Ejercicio11()
        {
            static void Main()
            {

                Console.Write("Ingrese una frase: ");
                string input = Console.ReadLine();

                
                int cantidadPalabras = ContarPalabras(input);

                
                Console.WriteLine($"Cantidad de palabras: {cantidadPalabras}");
            }

            static int ContarPalabras(string texto)
            {
                
                if (string.IsNullOrWhiteSpace(texto))
                    return 0;

               
                string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

               
                return palabras.Length;
            }

        }

        static void Ejercicio12()
        {
            static void Main()
            {
               
                Console.Write("Ingrese una frase: ");
                string input = Console.ReadLine();

                
                string resultado = EliminarVocales(input);

                
                Console.WriteLine($"Resultado: {resultado}");
            }

            static string EliminarVocales(string texto)
            {
              
                string vocales = "aeiouAEIOU";

               
                string resultado = "";
                foreach (char c in texto)
                {
                    if (!vocales.Contains(c))
                    {
                        resultado += c;
                    }
                }

                return resultado;
            }

        }

        static void Ejercicio13()
        {
            static void Main()
            {
                Console.Write("Ingrese una frase: ");
                string input = Console.ReadLine();
                string palabraMasLarga = ObtenerPalabraMasLarga(input);

                Console.WriteLine($"La palabra más larga es: {palabraMasLarga}");
            }

            static string ObtenerPalabraMasLarga(string texto)
            {
                string[] palabras = texto.Split(' ');

                string palabraLarga = "";

                foreach (string palabra in palabras)
                {
                    if (palabra.Length > palabraLarga.Length)
                    {
                        palabraLarga = palabra;
                    }
                }

                return palabraLarga;
            }
        }

        static void Ejercicio14()
        {
            static void Main()
            {
                Console.Write("Ingrese una frase: ");
                string input = Console.ReadLine();
                string resultado = EliminarPrimerLetra(input);

                Console.WriteLine($"Resultado: {resultado}");
            }

            static string EliminarPrimerLetra(string texto)
            {
                string[] palabras = texto.Split(' ');

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Length > 1)
                    {
                        palabras[i] = palabras[i].Substring(1);
                    }
                    else
                    {
                        palabras[i] = "";
                    }
                }

                return string.Join(" ", palabras);
            }

        }

        static void Ejercicio15()
        {
            static void Main()
            {
                Console.Write("Ingrese una frase: ");
                string input = Console.ReadLine();

                string resultado = InvertirPalabras(input);

                Console.WriteLine($"Resultado: {resultado}");
            }

            static string InvertirPalabras(string texto)
            {
                string[] palabras = texto.Split(' ');

                for (int i = 0; i < palabras.Length; i++)
                {

                    char[] palabraArray = palabras[i].ToCharArray();
                    Array.Reverse(palabraArray);
                    palabras[i] = new string(palabraArray);
                }
                return string.Join(" ", palabras);
            }
        }
    }
}
