internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("Enumerable");
        Console.WriteLine("----------------------------------\n");

        #region Lista

        var lista = new List<string>
        {
            "Juan",
            "Cesar",
            "Pineda",
            "Franco",
            "Morales",
            "Kid",
            "Dicktin",
            "Hector",
            "Telas-Poncho"
        };

        lista.Add("Sony");

        //foreach (var item in lista) 
        //{
        //    Console.WriteLine(item);
        //}

        //lista.Clear();

        lista.Sort();

        lista.OrderBy(x => x);

        for (int i = 0; i < lista.Count; i++) 
        {
            Console.WriteLine($"{i+1}.- {lista[i]}");
        }

        #endregion 

        Console.ReadKey();

    }
}