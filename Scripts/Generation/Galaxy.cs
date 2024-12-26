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
			
			// find the center point, and the radius of the circle.

			Vector2 tmpPos = _allplanets[i].GetPosition();

			Double distance = Mathf.Sqrt(Mathf.Pow((planet.GetPosition().X - _allplanets[i].GetPosition().X), 2) + MathF.Pow((planet.GetPosition().Y - _allplanets[i].GetPosition().Y), 2));

			Double XCoordinate = (planet.GetPosition().X - _allplanets[i].GetPosition().X) / 2;
			Double YCoordinate = (planet.GetPosition().Y - _allplanets[i].GetPosition().Y) / 2;

			bool valid = false;

			for (int j = 0; j < _allplanets.Length - 1; j++) {
				
				
				
			}

		}
		
		return neighbors.ToArray();
	}
	
}
