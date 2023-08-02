using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            float pleyerHelth = 100;
            int playerDamage = 15;
            int playerArmor = Random.Next(1,101);

            float enemyHelth = 100;
            int enemyDamage = 15;
            int enemyArmor = Random.Next(1,101);

            var fraсtion = new List<string>
            {
                "Good",
                "Evel",
                "Neutral"
            };

            int fractionRandomIndexPlayer = Random.Next(fraсtion.Count);
            string fractionPlayer = fraсtion[fraсtionRandomIndexPlayer];

            int fractionRandomIndexEnemy = Random.Next(fraсtion.Count);
            string fractionEnemy = fraсtion[fraсtionRandomIndexEnemy];

            int BersercPlayer = Random.Next(2);
            int BersercEnemy = Random.Next(2);
            float armorPlayerAfterBerserc = (float)armorPlayer;
            float armorEnemyAfterBerserc = (float)armorEnemy;

            if (BersercPlayer == 1)
            {
                playerDamage *= 2;
                armorPlayerAfterBerserc *= 0.2f;
            }
            else
            {
                armorPlayerAfterBerserc = playerArmor
            }

            if (BersercEnemy == 1)
            {
                enemyDamage *= 2;
                armorEnemyAfterBerserc *= 0.2f;
            }
            else 
            {
                armorEnemyAfterBerserc = enemyArmor;
            }

            float damagePlayer
    }
}
