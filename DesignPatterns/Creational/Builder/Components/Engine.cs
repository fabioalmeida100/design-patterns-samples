namespace Builder.Components
{
    public class Engine
    {
        private int _power;

        public int Power {
            get 
            {
                return _power;
            }

            set
            {
                _power = value;
            } 
        }

        public Engine(int power)
        {
            _power = power;
        }
    }
}
