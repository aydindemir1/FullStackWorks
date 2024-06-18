using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public event EnemyKilledEventHandler EnemyKilled;

        public Enemy(string name, int initialHealth)
        {
            Name = name;
            Health = initialHealth;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                OnEnemyKilled(new EnemyKilledEventArgs(Name));
            }
        }

        protected virtual void OnEnemyKilled(EnemyKilledEventArgs e)
        {
            EnemyKilled?.Invoke(this, e);
        }
    }

}
