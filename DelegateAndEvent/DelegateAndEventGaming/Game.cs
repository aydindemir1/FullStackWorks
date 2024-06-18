using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    public class Game
    {
        public Character Player { get; set; }
        public Enemy CurrentEnemy { get; set; }

        public Game()
        {
            Player = new Character("Hero", 100);
            CurrentEnemy = new Enemy("Goblin", 50);

            Player.HealthChanged += OnPlayerHealthChanged;
            Player.LowHealth += OnPlayerLowHealth;
            CurrentEnemy.EnemyKilled += OnEnemyKilled;
        }

        private void OnPlayerHealthChanged(object sender, HealthChangedEventArgs e)
        {
            Console.WriteLine($"Player health changed to {e.CurrentHealth}.");
        }

        private void OnPlayerLowHealth(object sender, HealthChangedEventArgs e)
        {
            Console.WriteLine($"Warning: Player health is low ({e.CurrentHealth}).");
        }

        private void OnEnemyKilled(object sender, EnemyKilledEventArgs e)
        {
            Console.WriteLine($"Enemy {e.EnemyName} has been killed.");
        }
    }

}
