namespace CS_Study.Chapter05
{
    public enum ChocolateBoiler
    {
        INSTANCE
    }
    public class ChocolateBoilerExtensions
    {
        private bool empty;
        private bool boiled;
        private ChocolateBoilerExtensions() { }

        public void Fill()
        {
            if ( IsEmpty() )
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if ( !IsEmpty() && IsBoiled() )
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if ( !IsEmpty() && !IsBoiled() )
            {
                boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
