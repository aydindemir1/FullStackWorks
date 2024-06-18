using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    public delegate void HealthChangedEventHandler(object sender, HealthChangedEventArgs e);
    public delegate void EnemyKilledEventHandler(object sender, EnemyKilledEventArgs e);

    // Event argümanları için sınıf tanımları
    public class HealthChangedEventArgs : EventArgs
    {
        public int CurrentHealth { get; set; }

        public HealthChangedEventArgs(int currentHealth)
        {
            CurrentHealth = currentHealth;
        }
    }
}
