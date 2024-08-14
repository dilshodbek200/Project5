class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int num = rnd.Next(1,100);

        for(int i = 0; i <= 9; i++)
        {
            Console.WriteLine("Randomni sonni topishga urinib ko'ring");
            int son1 = Convert.ToInt32(Console.ReadLine());

            if(i != 9)
            {
                if(son1 == num)
                {
                    Console.WriteLine("Siz Random sonni to'g'ri topdingiz");
                    break;
                }
                else
                {
                    Console.WriteLine("Yo'q");
                }
            }
            else
            {
                Console.WriteLine("Siz random sonni topish uchun 10 marta urindingiz.");
                Console.WriteLine($"Random son {num} edi.");
            }
        }
    }
}