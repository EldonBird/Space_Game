using Godot;
using System;

namespace SpaceGame.Scripts;

public class Item {
	
	public enum ItemType {
		Equipment,
		Consumable,
		Miscellaneous,
	}

	private String name = "Null Name";

	private int Value;
	
	private String description = "Null Description";
	

	public Item(String name) {
		
	}

}