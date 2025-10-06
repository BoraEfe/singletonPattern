namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.fill();
            chocolateBoiler.boil();
            chocolateBoiler.drain();
            chocolateBoiler.printState();

        }
    }
}   