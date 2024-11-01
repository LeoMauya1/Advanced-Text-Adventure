using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    class persuasiveCharacter : Character
    {
        public int convinceMeter;
        public string characteristic;


        public persuasiveCharacter(string characteristic, int convinceMeter, string name, string gender, int age) : base(name, age, gender)
        {
            this.characteristic = characteristic;
            this.convinceMeter = convinceMeter;
           
        }
        

        public void BuyItem(Player from)
        {
            Console.WriteLine(this.name, "bought", from.CurrentItem, "!!");
            Player.player.CurrentItem = default;
        }





    }
}
