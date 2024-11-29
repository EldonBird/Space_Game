using System.Collections.Generic;
using Godot;

namespace SpaceGame.Scripts;
using System;

public partial class WorldState {

	public enum StateKey {
		Hunger, 
		Panicked,
		
	}
	
	private Dictionary<StateKey, string> _state;

	public WorldState(Dictionary<StateKey, string> state) {
		_state = state;
	}

	public bool set_value(Enum state_key, Variant value) {

		if (_state.TryGetValue(state_key, out) == value) {
			return true;
		}
		
	}

	public Variant Get_value(StateKey key, Variant defaultValue) {
		return _state.GetValueOrDefault(key, defaultValue.ToString());
	}

	public WorldState Duplicate() {
		return new WorldState(_state);
	}

}