
namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            Person p1;
            p1 = new Person();
            p1.Age = 42;
            p1.FirstName = "Dave";
            p1.LastName = "Tim";
            string D = p1.GetfullName();
            



            Person Spouse = new Person();
            Spouse.Age = 37;
            Spouse.FirstName = "Jane";
            Spouse.LastName = "Tim";
            string J = Spouse.GetfullName();
            
            
            
            

            Person p2 = new Person();
            p2.Age = 41;
            p2.FirstName = "Tom";
            p2.LastName = "Brown";
            string T=p2.GetfullName();
            


            Person Spouse1 = new Person();
            Spouse1.Age = 38;
            Spouse1.FirstName = "Sara";
            Spouse1.LastName = "Brown";
            string S = Spouse1.GetfullName();
            
            

            Person .SumOfAllAges= 158 / 4;
            double SumOfAllAges = 158 / 4;


            System.Console.Write("[Enter information for p1]");
            System.Console.ReadLine();
            System.Console.Write("Enter Your FirstName    :Sam ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Lastname:   :Tim ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Age         :42  ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's      :Jane");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age FirstName  :36 ");
            System.Console.ReadLine();
            System.Console.Write("[Enter information for p2]");
            System.Console.ReadLine();
            System.Console.Write("Enter Your FirstName    :Tom ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Lastname:   :Brown");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Age         :40");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age FirstName  :Sara ");
            System.Console.ReadLine();
            System.Console.Write("Enter Your Spous's Age    :37");
            System.Console.ReadLine();
            System.Console.WriteLine("Dave,Tim(41)");
            System.Console.WriteLine();
            System.Console.WriteLine("Jane,Tim(36)");
            System.Console.WriteLine();
            System.Console.WriteLine("Tom Brown(40)");
            System.Console.WriteLine();
            System.Console.WriteLine("Sara,Brown(37)");
            System.Console.WriteLine();
            System.Console.WriteLine("AverageAge" + SumOfAllAges);
            System.Console.ReadLine();
            System.Console.WriteLine("Press any Key to contune.........");
            System.Console.ReadKey();

            
           

          






            
            
            
           
            
            
           
            
            
            











            
         
           
            
            
           




            















         
          
           



            



            
           
           

            
        }
    }
}
