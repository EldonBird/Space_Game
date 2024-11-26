using Godot;
using System;
using SpaceGame.Scripts;

public class Object : RefCounted {

	public Domain domain = new Domain();
	public WorldState worldState = new WorldState();

	public int oid; // This is it's index number, I'm thinking of making all index numbers cronologically based, i.e. first in first out.

	
	


}
