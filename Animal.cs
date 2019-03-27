namespace CartoonFarm
{
    abstract class Animal
    {
        private const int _speed = 10;
        private Sex _gender;
        private const int _lifespan = 20;

        public abstract int Speed { get; }
        public abstract Sex Gender { get; }
        public abstract int Lifespan { get; }
    }
}