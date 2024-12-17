using System.Collections.Generic;
using System.Linq;
using Godot;
using SpaceGame.Scripts.HTN;

namespace SpaceGame.Scripts;
using System;

public partial class WorldState {

	
	// State key is for anything a player might contain, for example if you have an item, the state key would be "item" and the Variant would the the item id... , Eldon
	public enum StateKey {
		Health,
		Hunger,
		Energy,
		Joy,
	}
	
	
	private Godot.Collections.Dictionary<StateKey, Variant> _state; // this is the saved state that you will call from functions, later I will make it so you can only grab this with permissions, Eldon

	private Item[] _items; // just an array of items, Eldon

	public void add_item(Item item) {
		if (item == null) {
			GD.PrintErr("Cant Add Null Item");
			return;
		}

		_items.Append(item);
		
	}

	public void Remove_Item(Item item) {
		if(item == null) { 
			Console.WriteLine("Cannot Remove Null Item");
			return;
		}

		List<Item> _remain = new List<Item>();
		
		for (int i = 0; i < _items.Length; i++) {

			if (_items[i] != item) {
				_remain.Append(_items[i]);
			}
		}
		_items = _remain.ToArray();
	}

	public Item[] Get_Items() {
		return _items;
	}
	
	
	
	// Creates the initial State for an object. In the future I may have spesific World states for different types of actors/patients, but for now this will work.
	public WorldState(Godot.Collections.Dictionary<StateKey, Variant> state) {

		_state = state;
		
		// you may need to include logic in the case of a null state... but I'll leave that for another time, Eldon
		
	}

	public void set_value(StateKey key, Variant value) {

		_state[key] = value;

	}

	public Variant Get_value(StateKey key, Variant defaultValue) {

		return _state[key];

	}

	// Only use this when actually accessing the state, not to get the internal state,
	// I.E, dont use this to interact with the system, use this in the internal process after accessesing the worldstate duplicated, etc. Eldon
	public Godot.Collections.Dictionary<StateKey, Variant>  Get_State() { 
		return _state;
	}

	public WorldState Duplicate() {
		return new WorldState(_state);
	}

}