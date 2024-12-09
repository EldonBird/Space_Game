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

	public Dictionary<WorldState.StateKey, Variant> Prerequisites() {
		
		Dictionary<WorldState.StateKey, Variant> prerequisites = new Dictionary<WorldState.StateKey, Variant>();
		
		return prerequisites;
		
	}

	public Dictionary<WorldState.StateKey, Variant> Effects() {

		return new Dictionary<WorldState.StateKey, Variant> { };

	}

	public WorldState ApplyEffects(WorldState worldState) {

		WorldState tmpState = worldState.Duplicate();
		
		foreach (var item in Effects()) {
			
			tmpState.set_value(item.Key, item.Value);
			
		}

		return tmpState;

	}
	
	
	
	
}