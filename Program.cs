namespace Day3B_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Constructors obj = new Constructors();
            Console.WriteLine(obj.Name);
            Constructors1 obj1 = new Constructors1("ckzncndskncl");
             Console.WriteLine(obj1.model);
            Constructors2 obj2 = new Constructors2("fishhhhhhh", "teeeeeeeeenaaaaaaaa");
            Console.WriteLine(obj2.Name1);
               Console.WriteLine(obj2.Name2);
            
        }
    }
}