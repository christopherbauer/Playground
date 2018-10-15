namespace Challenge180
{
    public class Tamagatchi
    {
        public Tamagatchi()
        {
            Age = 1;
            Hunger = 5;
            Play = 5;
            Feedings = 0;
            Energy = 5;
            TamagatchiStatus = TamagatchiStatus.Sleeping;
        }

        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Play { get; set; }
        public int Feedings { get; set; }
        public int Energy { get; set; }
        public TamagatchiStatus TamagatchiStatus { get; set; }
        public void Feed(int foodValue)
        {
            Hunger += foodValue;
            Feedings++;
        }

        public bool PutToBed()
        {
            if (Energy < 2)
            {
                return true;
            }
            return false;
        }
    }

    public enum TamagatchiStatus
    {
        Awake, Sleeping
    }
}