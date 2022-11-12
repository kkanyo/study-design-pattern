using CS_Study.Chapter01;
using CS_Study.Chapter02;
using CS_Study.Chapter03;
using CS_Study.Chapter04;
using CS_Study.Chapter05;
using CS_Study.Chapter06;
using CS_Study.Chapter07_1;

namespace CS_Study
{
    class Program
    {
        static void Main( string[] args )
        {
            Chapter07_1.Duck duck = new Chapter07_1.MallardDuck();

            Turkey turkey = new WildTurkey();
            Turkey duckAdapter = new DuckAdapter( duck );

            Console.WriteLine( "Turkey says" );
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine( "Duck says" );
            TestDuck( duck );

            Console.WriteLine( "Duck adapter says" );
            duckAdapter.Gobble();
            duckAdapter.Fly();
        }

        static void TestDuck(Chapter07_1.Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}