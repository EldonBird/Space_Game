using Godot;
using Godot.Collections;
using SpaceGame.Scripts.HTN;

namespace SpaceGame.Scripts;
using System;

public partial class WorldState {

	
	// State key is for anything a player might contain, for example if you have an item, the state key would be "item" and the Variant would the the item id... , Eldon
	public enum StateKey {
		Health,
		Hunger,
		Energy,
		Money,
		Joy,
	}

	public enum ItemType {
		Equipment,
		Consumable,
		Resource,
		Miscellaneous,
	}
	
	private Dictionary<StateKey, Variant> _state; // this is the saved state that you will call from functions, later I will make it so you can only grab this with permissions, Eldon

	private Dictionary<ItemType, >
	
	// Creates the initial State for an object. In the future I may have spesific World states for different types of actors/patients, but for now this will work.
	public WorldState(Dictionary<StateKey, Variant> state) {

		_state = state;
		
		
		// you may need to include logic in the case of a null state... but I'll leave that for another time, Eldon
		
	}

	public bool set_value(StateKey key, Variant value) {

		_state[key] = value;

		return true;

	}

	public Variant Get_value(StateKey key, Variant defaultValue) {

		return _state[key];

	}

	public WorldState Duplicate() {
		return new WorldState(_state);
	}

}