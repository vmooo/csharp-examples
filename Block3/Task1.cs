namespace task3_1
{
    class Enemy
    {
        private string _name;
        private int _health;

        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name is null or white space");
                }
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value >= 0)
                {
                    _health = value;
                }
                else
                {
                    throw new ArgumentException("Health is incorrect");
                }
            }
        }

        public virtual void TakeDamage(int damage)
        {
            _health = Math.Max(0, _health - damage);
        }
    }

    class Goblin : Enemy
    {

        public Goblin(string name, int health) : base(name, health)
        {}
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine("Гоблин визжит!");
        }
    }

    class Troll : Enemy
    {
        int _regeneration;

        public Troll(string name, int health, int regeneration) : base(name, health)
        {
            Regeneration = regeneration;
        }

        public int Regeneration
        {
            get
            {
                return _regeneration;
            }
            set
            {
                if(value >= 0)
                {
                    _regeneration = value;
                }
                else
                {
                    throw new ArgumentException("Regeneration cannot be below zero");
                }
            }
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Health += _regeneration;
        }
    }

    class Task1
    {
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();

            enemies.Add(new Goblin("Goblin", 30));
            enemies.Add(new Troll("Troll", 30, 5));

            foreach(var item in enemies)
            {
                item.TakeDamage(10);
                Console.WriteLine($"{item.Name}. Health: {item.Health}");
            }
        }
    }
}