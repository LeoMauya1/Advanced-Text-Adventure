using System;

public abstract class Item
{

	



    public int itemPrice;
	public string itemName;
	public int sellPrice;
	public string itemDescription;

	public Item ( int itemPrice, string itemName, int sellPrice,string itemDescription)
	{
		this.itemPrice = itemPrice;
		this.itemName = itemName;
	    this.sellPrice = sellPrice;
		this.itemDescription = itemDescription;

	}

}
