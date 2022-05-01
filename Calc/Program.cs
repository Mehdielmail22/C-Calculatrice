using System;
delegate long myDeleg(long x, long y);
public class CSharpCalculator
{
    private static long m_i;
    private static long m_j;
    public enum Operation
    {
        Plus = 1,
        Moins = 2,
        Produit = 3,
        Division = 4
    }
    static long Addition(long x, long y)
    {
        return x + y;
    }
    static long Sustraction(long x, long Y)
    {
        return x - Y;
    }
    static long Multiplication(long x, long y)
    {
        return x * y;
    }
    static long Division(long x, long y)
    {
        return x / y;
    }
    static void affiche(long x, long y, myDeleg deleg)
    {
        Console.WriteLine("\nLe resultat est : " + deleg(x, y) + "\n");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t\t\tProgramme de calcul simplifié");
        Console.WriteLine("\t\t\t\t\t-----------------------------\n\n");
        int z = 1;
        do
        {
            Console.WriteLine("Entre le premier nomber :");
            m_i = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre le deuxieme nombre :");
            m_j = int.Parse(Console.ReadLine());
            Operation op;
            String[] ops = Enum.GetNames(typeof(Operation));
            Console.WriteLine("Choisissez l'une des operations suivantes :\n");
            foreach (String opName in ops)
            {
                Console.WriteLine("\t- " + opName);
            }
            Console.Write("\nL'operations : ");
            try
            {
                var j = Enum.Parse(typeof(Operation), Console.ReadLine());
                op = (Operation)j;
            }
            catch
            {
                op = default(Operation);
            }
            switch (op)
            {
                case Operation.Plus:
                    affiche(m_i, m_j, Addition);
                    break;
                case Operation.Moins:
                    affiche(m_i, m_j, Sustraction);
                    break;
                case Operation.Produit:
                    affiche(m_i, m_j, Multiplication);
                    break;
                case Operation.Division:
                    affiche(m_i, m_j, Division);
                    break;
                default:
                    Console.WriteLine("\ninvalid operation\n");
                    break;

            }
            Console.WriteLine("\t\t\t\t\t1-Faire un autre calcule");
            Console.WriteLine("\t\t\t\t\t2-Quitter le programme");
            string w = Console.ReadLine();
            z = int.Parse(w);
        } while (z == 1);
    }
}