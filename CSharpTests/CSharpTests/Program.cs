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
            WriteLine(mything.isEatableOrDrinkable("nothing"));
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

        public bool isEatableOrDrinkable(string mything)
        {
            return this.isEatable(mything) || this.isDrinkable(mything);
        }
    }
}
