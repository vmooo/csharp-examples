namespace task1_1
{
        public class Player
        {
        private string _name;
        private int _health;
        private int _score;

        private static int _totalPlayers;

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
                    throw new ArgumentException("name is null or white space");
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
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else
                {
                    throw new ArgumentException("health is incorrect");
                }
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 0)
                {
                    _score = value;
                }
                else
                {
                    throw new ArgumentException("score is below zero");
                }
            }
        }

        public Player(string name, int health, int score)
        {
            Name = name;
            Health = health;
            Score = score;

            ++_totalPlayers;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}, health: {_health}, score: {_score}.");
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("Damage is below zero");
            }
            _health = Math.Max(0, _health - damage);
        }

        public void AddScore(int points)
        {
            if (points < 0)
            {
                throw new ArgumentException("Points cannot be below zero");
            }
            _score += points;
        }

        public static int ShowTotalPlayers()
        {
            return _totalPlayers;
        }
    }

    class Task1
{
    static void Main(string[] args)
    {
        Player player = new ("James", 56, 33);
        
        player.Name = "John";
        player.Health = 34;
        player.Score = 555;

        player.TakeDamage(1);
        player.AddScore(1);

        player.PrintInfo();

        Player player2 = new ("Player2", 3, 3);

        Console.WriteLine($"Total players: {Player.ShowTotalPlayers()}");
    }
}
}

