using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    class StubbornCharacter : Character 
    {
        public static StubbornCharacter Craige = new StubbornCharacter("craig",25,"he","Stubborn",0);

        


        public string characteristic;
        public int convinceMeter;

        public StubbornCharacter(string name, int age, string gender, string Characteristic, int convinceMeter) : base(name, age, gender) 
        {
            this.characteristic = Characteristic;
            this.convinceMeter = convinceMeter;
        }




        public void BuyItem(Player from)
        {
            Console.WriteLine(this.name, "bought", from.CurrentItem, "!!");
            Player.player.CurrentItem = null;
            

        }





    }
}
