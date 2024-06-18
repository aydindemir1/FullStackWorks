using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventGaming
{
    // Senaryo 2: Oyun Geliştirme
    public class DelegateAndEventGaming
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            // Oyun başlıyor ve bazı işlemler yapılıyor
            game.Player.Health = 80; // Can değişimi
            game.Player.Health = 15; // Düşük can uyarısı
            game.CurrentEnemy.TakeDamage(30); // Düşmana zarar verme
            game.CurrentEnemy.TakeDamage(25); // Düşmanı öldürme
        }
    }
}
