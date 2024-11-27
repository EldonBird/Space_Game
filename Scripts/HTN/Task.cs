using System;
using Godot;
using Godot.Collections;

namespace SpaceGame.Scripts;

public class Task : RefCounted {

	public enum Result {
		
		Success,
		Failure,
		Processing,
		
	}

	

	
	// The actual changes made from the output, not the logic though, Eldon
	public void Apply_Output() {
		var TMP = _output();

		// foreach dictionary object, etc...
		
	}

	// this is the same as the "Apply_Output" but it is just a counting of what will be done for the HTN PLanner, Eldon
	private Dictionary _output() {
		return null;
	}

	
	// Conditions are the "inputs" for the task, 'Prerequisites', Eldon
	public Dictionary Conditions() {


		return null;
	}

	
	// This is for functions to determine the state of completion. "Has this task suceeded, failed...", Eldon
	public Result Execute() {

		return Result.Processing;

	}
}