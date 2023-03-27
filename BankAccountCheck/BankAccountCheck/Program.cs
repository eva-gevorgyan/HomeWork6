namespace BankAccountCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name - ");
            string name=Console.ReadLine();
            Console.Write("Enter your card's id - ");
            int id=int.Parse(Console.ReadLine());

            bool b = false;
            Props prop = new User(name,id);
            prop.Check(id, ref b);
            if (b)
            {
                Console.WriteLine("Wrong!");
                Console.Write("Do you want to create new account? Enter 'yes' or 'no': ");
                string choose=Console.ReadLine();
                if (choose == "yes")
                {
                    Console.Write("You name - ");
                    string newName=Console.ReadLine();
                    Random rnd=new Random();
                    int newID=rnd.Next(111111111,999999999)+2;
                    User newUser = new User(newName, newID);
                    Console.WriteLine("Your ID - "+ newID);
                    Console.WriteLine("You have created account");
                }
                if(choose == "no")
                {
                    Console.WriteLine("Program ends");
                }
            }
        }
    }
}