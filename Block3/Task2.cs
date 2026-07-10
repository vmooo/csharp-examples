using System.Diagnostics.CodeAnalysis;

namespace task3_2
{
    public interface IDamageable
    {
        void TakeDamage(int damage);
    }
    
    internal class Enemy : IDamageable
    {
        private string _name;
        private int _health;

        [SetsRequiredMembers]
        protected Enemy(string name, int health) =>
            (Name, Health) = (name, health);
        public required string Name
        {
            get => _name;
            
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

        public required int Health
        {
            get => _health;
            
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
    
    internal class Goblin : Enemy
    {

        [SetsRequiredMembers]
        public Goblin(string name, int health) : base(name, health)
        {}
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine("Гоблин визжит!");
        }
    }

    internal class Troll : Enemy
    {
        private int _regeneration;

        [SetsRequiredMembers]
        public Troll(string name, int health, int regeneration) : base(name, health)
        {
            Regeneration = regeneration;
        }

        public int Regeneration
        {
            get => _regeneration;
            set
            {
                if (value >= 0)
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
    
    public class Player : IDamageable
    {
        private string _name;
        private int _health;
        private int _score;

        private static int _totalPlayers;

        public string Name
        {
            get => _name;
            
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
            get => _health;
            
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
            get => _score;
            
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

    internal static class Task2
    { private static void Attack(IDamageable target, int damage)
        {
            target.TakeDamage(damage);
        }
        
        private static void Main(string[] args) {
            var player = new Player("Player", 100, 0);
            var enemies = new List<Enemy>();

            enemies.Add(new Goblin("Goblin", 30));
            enemies.Add(new Troll("Troll", 30, 5));

            foreach(var item in enemies)
            {
                Attack(item, 10);
                Console.WriteLine($"{item.Name}. Health: {item.Health}");
            }
            
            Attack(player, 50);
            player.PrintInfo();
        }
    }
 }