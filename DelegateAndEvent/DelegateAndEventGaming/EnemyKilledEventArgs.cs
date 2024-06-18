using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    public class EnemyKilledEventArgs : EventArgs
    {
        public string EnemyName { get; set; }

        public EnemyKilledEventArgs(string enemyName)
        {
            EnemyName = enemyName;
        }
    }
}
