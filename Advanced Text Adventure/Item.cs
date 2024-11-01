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
	public static Item stackOfPrintinfPaper = new Item(7, "stacking printing paper", 4, "An absurdly large stack of printing paper");
	public static Item Monitor = new Item(33, "Computer monitor", 15, "A SONY INZONE M9 4K HDR 144HZ GAMING MONITOR.");
	public static Item Water = new Item(12, "Pack of water", 6, "A 12 pack of water.");
	public static Item crayons = new Item(8, "box of crayons", 4, "a pack of 8 crayons");
	public static Item wigs = new Item(23, "A wig", 10, "a red wig, smells really weird");
	



    public Item ( int itemPrice, string itemName, int sellPrice,string itemDescription)
	{
		this.itemPrice = itemPrice;
		this.itemName = itemName;
	    this.sellPrice = sellPrice;
		this.itemDescription = itemDescription;

	}

}
