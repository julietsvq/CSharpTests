using static System.Console;

namespace CSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing mything = new Thing();

            WriteLine(mything.isEatable("food"));
            WriteLine(mything.isDrinkable("drink"));
        }
    }

    static class Extensor
    {
        public static bool isDrinkable(this IEatable ieat, string mything)
        {
            return mything == "drink";
        }
    }


    interface IEatable
    {
        bool isEatable(string mything);
    }

    class Thing : IEatable
    {
        public bool isEatable(string mything)
        {
            return mything == "food";
        }
    }
}
