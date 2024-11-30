using System.Collections.Generic;
using Godot;

namespace SpaceGame.Scripts;
using System;

public partial class WorldState {

	
	// State key is for anything a player might contain, for example if you have an item, the state key would be "item" and the Variant would the the item id... , Eldon
	public enum StateKey {
		Health,
		Hunger,
		Fatigue,
		Money,
		
	}
	
	private Dictionary<StateKey, Variant> _state;

	public WorldState(Dictionary<StateKey, Variant> state) {
		_state = state;
	}

	public bool set_value(StateKey key, Variant value) {

		_state[key] = value;
		return false;

	}

	public Variant Get_value(StateKey key, Variant defaultValue) {
		
		return _state.GetValueOrDefault(key, defaultValue.ToString());
		
	}

	public WorldState Duplicate() {
		return new WorldState(_state);
	}

}