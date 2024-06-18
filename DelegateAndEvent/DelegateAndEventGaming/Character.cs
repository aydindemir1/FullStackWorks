using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    public class Character
    {
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                OnHealthChanged(new HealthChangedEventArgs(health));
                if (health < 20)
                {
                    OnLowHealth(new HealthChangedEventArgs(health));
                }
            }
        }

        public string Name { get; set; }

        // HealthChanged ve LowHealth event'leri
        public event HealthChangedEventHandler HealthChanged;
        public event HealthChangedEventHandler LowHealth;

        public Character(string name, int initialHealth)
        {
            Name = name;
            Health = initialHealth;
        }

        protected virtual void OnHealthChanged(HealthChangedEventArgs e)
        {
            HealthChanged?.Invoke(this, e);
        }

        protected virtual void OnLowHealth(HealthChangedEventArgs e)
        {
            LowHealth?.Invoke(this, e);
        }
    }

}
