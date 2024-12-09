using Godot;
using Godot.Collections;

namespace SpaceGame.Scripts.HTN;

public partial class PrimitiveTask : Task{

	
	// returns true if the task is possible to complete given a world state, eldon
	public bool availabile(WorldState worldState) {

		if (true) {
			return false;
		}


		return true;
	}

	public Dictionary<WorldState.StateKey, Variant> Effects() {

		return new Dictionary<WorldState.StateKey, Variant> { };

	}

	public void ApplyEffects(WorldState worldState) {

		foreach (var item in Effects()) {
			
			worldState.set_value(item.Key, item.Value);
			
		}
		
	}
	
	public Dictionary
	
	
}