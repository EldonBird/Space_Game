using System;
using System.Collections.Generic;
using Godot;

namespace SpaceGame.Scripts.Generation;
using System.Numerics;

public partial class Galaxy {
	
	private Planet[] _allplanets { get; set; }

	
	
	public Galaxy(float sizeX, float sizeY, int planetNum) {
		
		//Phase 1 Local generation
		
		for (var i = 0; i < planetNum; i++) {

			float x = (HaltonSequence.Sequence(2, i) - 0.5f) * sizeX;
			float y = (HaltonSequence.Sequence(3, i) - 0.5f) * sizeY;
			
			Vector2 position = new(x, y);

			Planet p = new Planet(position, i);
			

		}
		
		// phase 2, "global" generation

		foreach (var planet in _allplanets) {
			
			planet.SetNeighbors(Gabriel(planet));
			
			
			
		}

	}
	
	


	// this function returns all "gabriel" neighbors to create a network.
	public Planet[] Gabriel(Planet planet) {
		
		List<Planet> neighbors = new List<Planet>();
		
		
		for (int i = 0; i < _allplanets.Length; i++) {

			Vector2 center;
			center.X = (_allplanets[i].GetPosition().X + planet.GetPosition().X ) / 2;
			center.Y = (_allplanets[i].GetPosition().Y + planet.GetPosition().Y ) / 2;

			float radius = GetDistace(_allplanets[i], planet) / 2;

			bool match = true;

			foreach (var p in _allplanets) {

				if (GetDistace(p, planet) <= radius) {
					
					match = false;
					
				}
			}

			if (match) {
				neighbors.Add(_allplanets[i]);
			}
			
		}
		
		
		
		return neighbors.ToArray();
	}

	
	// im lazy
	private float GetDistace(Planet planet1, Planet planet2) {
		
		return MathF.Sqrt(Mathf.Pow((planet1.GetPosition().X - planet2.GetPosition().X), 2) + Mathf.Pow((planet1.GetPosition().Y - planet2.GetPosition().Y), 2));

	}
	
}
