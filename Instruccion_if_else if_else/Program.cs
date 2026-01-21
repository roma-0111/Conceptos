namespace Instruccion_if_else_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En este documento se ve el uso de los distinto condicionales básicos que se usa en toda la vida. (bueno eso se cree)
            //  if
            //El if normal
            int num = 10;
            if (num == 10)
            {
                Console.WriteLine($"1. Se activa el \"if\" común.");
            }
            //El if simplificado: Éstesolo funciona con 1 instrucción, pero también hay forma de hacer algo más que 1 instrucción.
            if (num == 10) Console.WriteLine($"2. Se activa el \"if\" simplificado.");

            //  if y else común
            if (num == 10)
            {
                Console.WriteLine($"3. Del \"if\" y el \"else\" se activa el \"if\".");
            }
            else
            {
                Console.WriteLine("Por si no ocurre la condición de \"if\" arriba de este \"else\".");
            }
            //  if y else simplicado
            if (num == 10) Console.WriteLine($"4. Del \"if\" y el \"else\" simplificado se activa el \"if\".");
            else Console.WriteLine("Por si no ocurre la condición de if simplificada arriba de este \"else\" simplificado.");

            //  if, else if y else
            if (num == 10)
            {
                Console.WriteLine($"5. Del \"if\", \"else if\" y \"else\", se activa el \"if\"");
            }
            else if (num != 10)
            {
                Console.WriteLine("Por su quieres poner otra condición y otras acciones.");
            }
            else
            {
                Console.WriteLine("Por si no ocurre la condición de \"if\" o \"else if\" arriba de este \"else\"");
            }

            //Para esperar y salir
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();










        }
    }
}
