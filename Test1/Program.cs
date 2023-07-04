namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Display date time in 2023-06-27 13:30
            Console.WriteLine(DateTime.Now.ToString("yyyy-mm-dd hh:mm"));


            //find age of the person
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dob.Year + " " + dob.Month + " " + dob.Day);
            Console.WriteLine(int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dob.ToString("yyyy")));
            TimeSpan difference = DateTime.Now.Subtract(dob);
            Console.WriteLine(difference);


            //display each character of given word
            String name = "Chaithra";
            foreach(char letter in name)
            {
                Console.Write(letter+" ");
            }


            //Search specific word in given string
            String str = "Arrays can be passed as arguments to method parameters. ";
            String search = "arguments";
            Console.WriteLine();
            Console.WriteLine(str.Contains(search));


            //insert at fixed position
            String insertStr = "What is your ?";
            int index = 13;
            Console.WriteLine(insertStr.Insert(index,"name"));
        }
    }
}