namespace Perfect_Numders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Frist Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect Resualt:");
            {
                if (num1 >= 0) if(num2 >= 6) if(num1 < 7 )
                {

                    Console.WriteLine("6");
                }

                if (num2 >= 28) if(num2 <= 495) if(num1 < 29)
                {
                   
                    Console.WriteLine("28");
                }
                if (num2 >= 496) if(num2 <= 8127) if( num1 < 49710)
                {
                        Console.WriteLine("496");
                }

            }









        }
    }        
} 
        
    
    