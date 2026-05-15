namespace CreatureFighter.Models
{
    public class Stats
    {
        private int strength;
        private int dexterity;

        public static Stats operator +(Stats a, Stats b)
        {
            return new Stats(
                a.Health + b.Health,
                a.Strength + b.Strength,
                a.Dexterity + b.Dexterity
            );
        }

        public static Stats operator -(Stats a, Stats b)
        {
            return new Stats(
                a.Health - b.Health,
                a.Strength - b.Strength,
                a.Dexterity - b.Dexterity
            );
        }

        public int Strength
        {
            get => strength;
            private set => strength = Math.Clamp(value, 1, 10);
        }

        public int Dexterity
        {
            get => dexterity;
            private set => dexterity = Math.Clamp(value, 1, 10);
        }


        public int Health { get; private set; }

        private static Random random = new Random();

        public Stats(int health, int strength, int dexterity)
        {
            Health = health;
            Strength = strength;     // 👈 przechodzi przez zabezpieczenie
            Dexterity = dexterity;   // 👈 przechodzi przez zabezpieczenie
        }

        public Stats()
        {
            Health = Roll() * 10;
            Strength = Roll();
            Dexterity = Roll();
        }

        //przeciążone operatory
        public void Plus(int health, int strength, int dexterity)
        {
            var result = this + new Stats(health, strength, dexterity);

            Health = result.Health;
            Strength = result.Strength;
            Dexterity = result.Dexterity;
        }
        public void Minus(int health, int strength, int dexterity)
        {
            var result = this - new Stats(health, strength, dexterity);

            Health = result.Health;
            Strength = result.Strength;
            Dexterity = result.Dexterity;
        }


        private static int Roll()
        {
            return random.Next(1, 11);
        }

        public override string ToString()
        {
            return $"HP={Health}, STR={Strength}, DEX={Dexterity}";
        }

    }
}
