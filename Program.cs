internal class Program
{
    private static void Main(string[] args)
    {
       
        // Bước 1: Khai báo biến số nguyên number và nhập giá trị từ bàn phím
        int number;
        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Bước 2: Kiểm tra số vừa nhập có phải là số nguyên tố
        if (number < 2)
        {
            Console.WriteLine(number + " is not a prime");
        }
        else
        {
            int i = 2;
            bool isPrime = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime");
            }
            else
            {
                Console.WriteLine(number + " is not a prime");
            }
        }
    }
}