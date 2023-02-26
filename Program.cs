namespace ODEV1_for_dongusu_14_02_2023
{
    internal class Program
    {
        static int Row, Col;
        static void Main(string[] args)
        {
            #region "M" harfi

            for (Row = 0; Row <= 6; Row++)
            {
                for (Col = 0; Col <= 6; Col++)
                {
                    if (Col == 1 || Col == 5 || (Row == 2 && (Col == 2 || Col == 4)) || (Row == 3 && Col == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
#endregion