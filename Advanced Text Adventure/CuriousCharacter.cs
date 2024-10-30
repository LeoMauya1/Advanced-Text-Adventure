using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
     class CuriousCharacter : Character
    {
       public int convinceMeter;
       public string characteristic;




        public CuriousCharacter(int convinceMeter, string characteristic, string name, string gender, int age) : base(name,age,gender)
        {
            this.convinceMeter = convinceMeter;
            this.characteristic = characteristic;
        }

        public void BuyItem(Player from)
        {
            Console.WriteLine(this.name, "bought", from.CurrentItem, "!!");
            Player.player.CurrentItem = null;


        }


    }
}
