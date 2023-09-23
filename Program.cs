namespace Задача_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите шестизначное число: ");
            string chisloStr = Console.ReadLine();

            int chislo = Convert.ToInt32(chisloStr);

            if (chislo > 100000 && chislo < 999999)
            {
                int castling1 = 0;
                int castling2 = 0;
                Console.WriteLine("Введите номера разрядов для обмена местами: ");
                castling1 = Convert.ToInt32(Console.ReadLine());
                castling2 = Convert.ToInt32(Console.ReadLine());
                char[] chisloArr = chisloStr.ToCharArray();
                char tmp1 = chisloArr[castling1 - 1];
                char tmp2 = chisloArr[castling2 - 1];
                chisloArr[castling1 - 1] = tmp2;
                chisloArr[castling2 - 1] = tmp1;
                Console.WriteLine(chisloArr);
            }
            
            else Console.WriteLine("Число введено не верно!");
                                        
        }
    }
}