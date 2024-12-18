using Godot;
using System;

namespace SpaceGame.Scripts;

public class Item {
	
	public enum ItemType {
		Equipment,
		Consumable,
		Miscellaneous,
	}

	private String _name { get; }
	
	private String _description { get;  }

	private int _id { get; }

	private int _value { get; }

	public Item(String name, String description, int id, int value) {
		
		_name = name;
		_description = description;
		_id = id;
		_value = value;
		
	}

}