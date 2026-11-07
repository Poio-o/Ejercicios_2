using System;

class Program
{
    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   MENÚ DE EJERCICIOS - ESTRUCTURAS     ");
            Console.WriteLine("========================================");
            Console.WriteLine(" 1. Mayor de dos números");
            Console.WriteLine(" 2. Coste de la factura de la luz");
            Console.WriteLine(" 3. Estado civil con estructura case");
            Console.WriteLine(" 4. Tabla de multiplicar (1 al 9)");
            Console.WriteLine(" 5. Operaciones con cadenas de texto");
            Console.WriteLine(" 6. Cálculo del factorial");
            Console.WriteLine(" 7. Abecedario inverso (Z a A)");
            Console.WriteLine(" 8. Número aleatorio entre 10 y 30");
            Console.WriteLine(" 9. Array de enteros (Pares e impares)");
            Console.WriteLine("10. Ordenar array con System.Array");
            Console.WriteLine("11. Uso de pila (System.Collections.Stack)");
            Console.WriteLine(" 0. Salir");
            Console.WriteLine("========================================");
            Console.Write("Introduce el número del ejercicio: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine();
                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Ejercicio4(); break;
                    case 5: Ejercicio5(); break;
                    case 6: Ejercicio6(); break;
                    case 7: Ejercicio7(); break;
                    case 8: Ejercicio8(); break;
                    case 9: Ejercicio9(); break;
                    case 10: Ejercicio10(); break;
                    case 11: Ejercicio11(); break;
                    case 0: Console.WriteLine("Saliendo de la aplicación..."); break;
                    default: Console.WriteLine("Opción no válida. Inténtalo de nuevo."); break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    // 1. Dos números, muestra el mayor en una sola línea de WriteLine sin concatenaciones.
    static void Ejercicio1()
    {
        Console.WriteLine("--- Ejercicio 1: Mayor de dos números ---");
        Console.Write("Introduce el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El número mayor es: {0}", num1 > num2 ? num1 : (num2 > num1 ? num2 : "Ambos son iguales"));
    }

    // 2. Coste de la factura de la luz según consumo.
    static void Ejercicio2()
    {
        Console.WriteLine("--- Ejercicio 2: Factura de la luz ---");
        Console.Write("Introduce los Kilovatios consumidos: ");
        double kwh = Convert.ToDouble(Console.ReadLine());
        double precio = 0;

        if (kwh > 1800)
        {
            precio = 0.8;
        }
        else if (kwh >= 1000)
        {
            precio = 0.12;
        }
        else
        {
            precio = 0.14;
        }

        double total = kwh * precio;
        Console.WriteLine($"Total a pagar: {total:C2} (Consumo: {kwh} kWh a {precio} por kWh)");
    }

    // 3. Estado civil abreviado mediante estructura case y default.
    static void Ejercicio3()
    {
        Console.WriteLine("--- Ejercicio 3: Estado civil ---");
        Console.Write("Introduce tu estado civil (C, S, V o D): ");
        string estado = Console.ReadLine().ToUpper();

        switch (estado)
        {
            case "C":
                Console.WriteLine("Tu estado civil es Casad@");
                break;
            case "S":
                Console.WriteLine("Tu estado civil es Solter@");
                break;
            case "V":
                Console.WriteLine("Tu estado civil es Viud@");
                break;
            case "D":
                Console.WriteLine("Tu estado civil es Divorciad@");
                break;
            default:
                Console.WriteLine("Error: No has introducido ninguna opción correcta.");
                break;
        }
    }

    // 4. Tabla de multiplicar de un número del 1 al 9.
    static void Ejercicio4()
    {
        Console.WriteLine("--- Ejercicio 4: Tabla de multiplicar ---");
        Console.Write("Introduce un número del 1 al 9: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 1 || num > 9)
        {
            Console.WriteLine("Error: El número está fuera del rango permitido (1 al 9).");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num}x{i}={num * i}");
        }
    }

    // 5. Operaciones variadas sobre una cadena de texto.
    static void Ejercicio5()
    {
        Console.WriteLine("--- Ejercicio 5: Operaciones con cadenas ---");
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"- Longitud: {texto.Length}");

        Console.Write("- Introduce una subcadena a buscar: ");
        string sub = Console.ReadLine();
        Console.WriteLine($"  ¿Contiene la subcadena?: {texto.Contains(sub)}");

        Console.Write("- Letra que deseas reemplazar: ");
        char viejo = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("- Nueva letra: ");
        char nuevo = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine($"  Resultado del reemplazo: {texto.Replace(viejo, nuevo)}");

        Console.WriteLine($"- Todo a mayúsculas: {texto.ToUpper()}");
        Console.WriteLine($"- Todo a minúsculas: {texto.ToLower()}");

        if (texto.Length > 0)
        {
            Console.WriteLine($"- Eliminar el primer carácter (posición 0): {texto.Remove(0, 1)}");
        }

        if (texto.Length >= 2)
        {
            Console.WriteLine($"- Subcadena (inicio 0, fin 2): {texto.Substring(0, 2)}");
        }
    }

    // 6. Cálculo del factorial de un número.
    static void Ejercicio6()
    {
        Console.WriteLine("--- Ejercicio 6: Factorial ---");
        Console.Write("Introduce un número entero: ");
        int n = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {n} es {factorial}");
    }

    // 7. Abecedario en mayúsculas de la Z a la A usando ASCII y Convert.ToString.
    static void Ejercicio7()
    {
        Console.WriteLine("--- Ejercicio 7: Abecedario inverso ---");
        Console.WriteLine("Abecedario de Z a A:");
        for (int i = 90; i >= 65; i--)
        {
            Console.Write(Convert.ToString((char)i) + " ");
        }
        Console.WriteLine();
    }

    // 8. Número aleatorio entre 10 y 30 con Random.
    static void Ejercicio8()
    {
        Console.WriteLine("--- Ejercicio 8: Número aleatorio ---");
        Random rnd = new Random();
        int aleatorio = rnd.Next(10, 31);
        Console.WriteLine($"Número aleatorio generado entre 10 y 30: {aleatorio}");
    }

    // 9. Array de tamaño indicado por usuario, mostrar pares e impares.
    static void Ejercicio9()
    {
        Console.WriteLine("--- Ejercicio 9: Array Pares e Impares ---");
        Console.Write("Indica el tamaño del array: ");
        int tam = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[tam];

        for (int i = 0; i < tam; i++)
        {
            Console.Write($"Introduce el valor para la posición [{i}]: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nResultados:");
        foreach (int num in arr)
        {
            string tipo = (num % 2 == 0) ? "PAR" : "IMPAR";
            Console.WriteLine($"El número {num} es {tipo}");
        }
    }

    // 10. Array de 10 enteros desordenados, ordenar con System.Array y mostrar con for.
    static void Ejercicio10()
    {
        Console.WriteLine("--- Ejercicio 10: Ordenar Array ---");
        int[] arr = { 42, 7, 89, 15, 23, 4, 99, 31, 12, 56 };

        Console.Write("Array desordenado: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Array.Sort(arr);

        Console.Write("Array ordenado:    ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    // 11. Uso de System.Collections.Stack.
    static void Ejercicio11()
    {
        Console.WriteLine("--- Ejercicio 11: Uso de Stack (Pila) ---");
        System.Collections.Stack pila = new System.Collections.Stack();

        Console.WriteLine("Introduce 3 valores enteros para agregarlos a la pila:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            int val = Convert.ToInt32(Console.ReadLine());
            pila.Push(val);
        }

        Console.WriteLine("\nValores actuales en la pila:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }

        if (pila.Count >= 2)
        {
            Console.WriteLine($"\nSacando elemento (Pop): {pila.Pop()}");
            Console.WriteLine($"Sacando elemento (Pop): {pila.Pop()}");
        }

        Console.WriteLine("\nValores de la pila tras extraer los dos elementos:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }
    }
}