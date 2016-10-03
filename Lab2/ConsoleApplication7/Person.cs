

namespace ConsoleApplication7
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static double SumOfAllAges;

        public string GetfullName()
        
        {
            return this.FirstName+"" +this.LastName;
            
        }


        
        public void PrintNameAndAge()
        {

            System.Console.WriteLine("PrintName"+this.FirstName);
            System.Console.WriteLine("PrintName" + this.LastName);
            System.Console.WriteLine("PrintAge" + this.Age);



        }
    }
}
