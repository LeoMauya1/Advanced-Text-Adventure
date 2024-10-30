using System;

public class Item
{
    public int itemPrice;
	public string itemName;
	public int sellPrice;
	public string itemDescription;



    public static Item bomb = new Item(23, "BOMB", 18, "mass destruction");
	public static Item canOfTuna = new Item(10, "A Can of tuna", 5, "a can of tuna! quite delectable");
	public static Item appleSeeds = new Item(3, "Some apple seeds.", 1, "apple seeds");
	public static Item rpg = new Item(21, "AN RPG!!!!!", 17, "an insane weapon, not a toy");
	public static Item babyBib = new Item(6, "a baby bib", 3, "a bib for a baby, a baby for a bib!!");
	public static Item wheel = new Item(8, "single wheel", 4, "a singular wheel for a bike");
	public static Item unicycle = new Item(3, "Unicycle", 1, "weird ah bike");
	public static Item popcycleSticks = new Item(3, "pop cycle sticks", 1, "sticks for popcycles");
	//public static Item printingPapers = new Item()



    public Item ( int itemPrice, string itemName, int sellPrice,string itemDescription)
	{
		this.itemPrice = itemPrice;
		this.itemName = itemName;
	    this.sellPrice = sellPrice;
		this.itemDescription = itemDescription;

	}

}
