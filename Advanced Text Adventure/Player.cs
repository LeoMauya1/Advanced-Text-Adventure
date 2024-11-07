using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    public class Player : Character
    {


        public static Player player = new Player(Item.bomb, Program.playerName, 21, "he");
        public object CurrentItem;


        public Player (Item currentItem, string name, int age, string gender ): base(name, age, gender)
        {
            this.CurrentItem = currentItem;
        }
 

        public void BuyFromShop()
        {
            //player buys items from shop. 
        }


       public void MoveItemToCurrent(List<Item>items, Player player)
        {
            player.CurrentItem = items[0];
            Console.WriteLine($"YOUR CURRENT ITEM IS A {items[0].itemName}, IT SELLS FOR {items[0].sellPrice}");
        }
        




    }
}
