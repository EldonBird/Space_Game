using System;
using System.Collections.Generic;
using Godot;

namespace SpaceGame.Scripts.Generation;
using System.Numerics;

public partial class Galaxy {
	
	private Planet[] _allplanets { get; set; }

	public Galaxy(float sizeX, float sizeY, int planetNum) {

		for (var i = 0; i < planetNum; i++) {

			float x = (HaltonSequence.Sequence(2, i) - 0.5f) * sizeX;
			float y = (HaltonSequence.Sequence(3, i) - 0.5f) * sizeY;
			
			Vector2 position = new(x, y);

			Planet p = new Planet(position, i);
			
			GD.Print(position.ToString());
			

		}

	}


	public Planet[] Gabriel(Planet planet) {
		
		List<Planet> neighbors = new List<Planet>();

		for (int i = 0; i < _allplanets.Length - 1; i++) {

			if (_allplanets[i] == planet) { continue; }
			
			
			
		}
		
		return neighbors.ToArray();
	}
	
}
