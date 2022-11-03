namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyListInt myListInt = new MyListInt(5);
            MyListInt myListInt1 = new MyListInt(5);

            myListInt.Add(2);
            myListInt1.Add(4);


            Console.WriteLine(myListInt == myListInt1);
        }
    }
}