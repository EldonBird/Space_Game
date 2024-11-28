using System.Security.Principal;
using Godot;
using static Godot.GD;
namespace SpaceGame.Scripts;

public partial class TempOutput : Node {

	static TempOutput() {
		GD.Print("TempOutput");
		
		Generation.Galaxy galaxy = new Generation.Galaxy(200, 200, 100);
	}
	


}
