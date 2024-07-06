namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Kelly";
            int exerciseNumber = 4;
            char lastInitial = 'A';
            bool isCoding = true;
            double percentComplete = 3.5;
            decimal worth = 1.95m;
            Console.Write(name + " " + lastInitial + " is working on exercise " + exerciseNumber + ". Currently, she is " );
            Console.Write(isCoding ? "coding." : "not coding");
            Console.WriteLine(" She is " + percentComplete + "% complete with this project worth $" + worth);
        }
    }
}
