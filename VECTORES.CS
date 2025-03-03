using System;
namespace PROYECTO_FINAL_2025_FB_NNNY
{
    class Vectores
    {
        static void Ejercicio16()
        {
            static void Main()
            {
                Console.Write("Ingrese una serie de números separados por comas: ");
                string input = Console.ReadLine();

                int[] numeros = input.Split(',').Select(int.Parse).ToArray();

                int cantidadPares = ContarPares(numeros);

                Console.WriteLine($"Cantidad de números pares: {cantidadPares}");
            }

            static int ContarPares(int[] vector)
            {
                int contador = 0;
                foreach (int num in vector)
                {
                    if (num % 2 == 0)
                    {
                        contador++;
                    }
                }
                return contador;
            }

        }

        static void Ejercicio17()
        {
            static void Main()
            {
                Console.Write("Ingrese una serie de números separados por comas: ");
                string input = Console.ReadLine();

                int[] numeros = input.Split(',').Select(int.Parse).ToArray();

                MergeSort(numeros, 0, numeros.Length - 1);

                Console.WriteLine("Vector ordenado: " + string.Join(",", numeros));
            }

            static void MergeSort(int[] arr, int izquierda, int derecha)
            {
                if (izquierda < derecha)
                {
                    int medio = (izquierda + derecha) / 2;

                    MergeSort(arr, izquierda, medio);
                    MergeSort(arr, medio + 1, derecha);
                    Merge(arr, izquierda, medio, derecha);
                }
            }

            static void Merge(int[] arr, int izquierda, int medio, int derecha)
            {
                int n1 = medio - izquierda + 1;
                int n2 = derecha - medio;

                int[] izquierdaArr = new int[n1];
                int[] derechaArr = new int[n2];

                for (int i = 0; i < n1; i++)
                    izquierdaArr[i] = arr[izquierda + i];

                for (int j = 0; j < n2; j++)
                    derechaArr[j] = arr[medio + 1 + j];

                int iIndex = 0, jIndex = 0, kIndex = izquierda;

                while (iIndex < n1 && jIndex < n2)
                {
                    if (izquierdaArr[iIndex] <= derechaArr[jIndex])
                    {
                        arr[kIndex] = izquierdaArr[iIndex];
                        iIndex++;
                    }
                    else
                    {
                        arr[kIndex] = derechaArr[jIndex];
                        jIndex++;
                    }
                    kIndex++;
                }

                while (iIndex < n1)
                {
                    arr[kIndex] = izquierdaArr[iIndex];
                    iIndex++;
                    kIndex++;
                }

                while (jIndex < n2)
                {
                    arr[kIndex] = derechaArr[jIndex];
                    jIndex++;
                    kIndex++;
                }
            }

        }

        static void Ejercicio18()
        {
            static void Main()
            {
                Console.Write("Ingrese una serie de números separados por comas: ");
                string input = Console.ReadLine();
                int[] numeros = input.Split(',').Select(int.Parse).ToArray();
                InsertionSort(numeros);

                Console.WriteLine("Vector ordenado: " + string.Join(",", numeros));
            }

            static void InsertionSort(int[] arr)
            {
                int n = arr.Length;

                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
            }

        }

        static void Ejercicio19()
        {
            static void Main()
            {
                Console.Write("Ingrese una serie de números separados por comas: ");
                string input = Console.ReadLine();

                string[] inputArray = input.Split(',');
                List<int> v = new List<int>();

                foreach (var item in inputArray)
                {
                    v.Add(int.Parse(item.Trim()));
                }

                Console.Write("Ingrese el número a eliminar: ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + string.Join(",", v));
            }

            static void EliminarX(List<int> v, int x)
            {
                v.RemoveAll(val => val == x);
            }

        }

        static void Ejercicio20()
        {
            static void Main()
            {
                Console.Write("Ingrese una serie de números separados por comas: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("La entrada no puede estar vacía.");
                    return;
                }

                string[] inputArray = input.Split(',');
                List<int> v = new List<int>();

                foreach (var item in inputArray)
                {
                    if (int.TryParse(item.Trim(), out int number))
                    {
                        v.Add(number);
                    }
                    else
                    {
                        Console.WriteLine($"Valor no válido: {item}. Se ignorará.");
                    }
                }

                Console.Write("Ingrese el índice 'a': ");
                if (!int.TryParse(Console.ReadLine(), out int a) || a < 0 || a >= v.Count)
                {
                    Console.WriteLine("Índice 'a' no válido.");
                    return;
                }

                Console.Write("Ingrese el índice 'b': ");
                if (!int.TryParse(Console.ReadLine(), out int b) || b < 0 || b >= v.Count || b <= a)
                {
                    Console.WriteLine("Índice 'b' no válido.");
                    return;
                }

                Invertir(v, a, b);

                Console.WriteLine("Resultado: " + string.Join(",", v));
            }

            static void Invertir(List<int> v, int a, int b)
            {
                while (a < b)
                {
                    int temp = v[a];
                    v[a] = v[b];
                    v[b] = temp;

                    a++;
                    b--;
                }
            }
        }
    }
}
