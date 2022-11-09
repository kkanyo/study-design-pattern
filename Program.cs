using CS_Study.Chapter01;
using CS_Study.Chapter02;
using CS_Study.Chapter03;
using CS_Study.Chapter04;

namespace CS_Study
{
    class Program
    {
        static void Main( string[] args )
        {
            PizzaStore nyStore = new NewYorkStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza( "cheese" );
            Console.WriteLine( "Ethan ordered a " + pizza.GetName() + "\n" );

            pizza = chicagoStore.OrderPizza( "cheese" );
            Console.WriteLine( "Joel ordered a " + pizza.GetName() + "\n" );
        }
    }
}