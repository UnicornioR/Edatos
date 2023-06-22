using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos = new ArrayList();
        ArrayList Animales = new ArrayList();

        Carnivoros.Add("Tigre");
        Carnivoros.Add("León");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");
        Acuaticos.Add("Tiburón");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");

        Animales.AddRange(Carnivoros);
        foreach (Object n in Animales)
        {
            Console.WriteLine(n.ToString());
        }
        Console.WriteLine("\n================================");

        Animales.AddRange(Acuaticos);
        foreach (Object n in Animales)
        {
            Console.WriteLine(n.ToString());
        }
        Console.WriteLine("\n================================");
        
        Carnivoros.Clear();
        // ArrayList myAL = new ArrayList();
        // myAL.Add("The");
        // myAL.Add("quick");
        // myAL.Add("brown");
        // myAL.Add("fox");
        // foreach (Object n in myAL){

        // Console.WriteLine("Hello, World!");
        // }
    }
}
