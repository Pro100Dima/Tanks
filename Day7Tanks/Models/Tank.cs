using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Models
{
    enum TankType { T34, Pantera }
    class Tank
    {
        /// <summary>
        /// boekomplekt
        /// </summary>
        private int Ammunition { get; set; }
        /// <summary>
        /// bronya
        /// </summary>
        private int Armor { get; set; }
        /// <summary>
        /// manevrennost
        /// </summary>
        private int Maneuverability { get; set; }

        private TankType TankType { get; set; }
        public Tank()
        {

        }
        public Tank(TankType Tank)
        {
            Random rand = new Random();
            Ammunition = rand.Next(0, 100);
            Armor = rand.Next(0, 100);
            Maneuverability = rand.Next(0, 100);
            TankType = Tank;
        }
        public static Tank operator *(Tank t1, Tank t2)
        {
            Tank winner = new Tank();
            if (t1.Ammunition > t2.Ammunition && t1.Armor > t2.Armor)
                winner = t1;
            else if (t1.Ammunition > t2.Ammunition && t1.Maneuverability > t2.Maneuverability)
                winner = t1;
            else if (t1.Armor > t2.Armor && t1.Maneuverability > t2.Maneuverability)
                winner = t1;
            else winner = t2;

            return winner;
        }

        public override string ToString()
        {
            string info = string.Format(
                                     "tip : {0}" +
                                     "\n boekomplekt : {1}" +
                                     "\n manevrennost : {2} ",
                                     this.TankType.ToString(),
                                     this.Armor,
                                     this.Maneuverability
                                     );
            return info;
        }
    }
}
