using Godot;
using Godot.Collections;

namespace SpaceGame.Scripts;

public class Task : RefCounted {

	public enum Result {
		
		Success,
		Failure,
		Processing,
		
	}

	public void Apply_Output() {
		var TMP = _output();

		// foreach dictionary object, etc...

	}


	private Dictionary _output() {

		return null;
	}

	public Dictionary Conditions() {


		return null;
	}

	public Result Execute() {

		return Result.Processing;

	}
}