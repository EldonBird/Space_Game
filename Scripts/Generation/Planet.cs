using System;
using System.Numerics;

namespace SpaceGame.Scripts.Generation;

public partial class Planet : Patient {
    
    private String name { get; set; }
    
    private int _index;
    private Vector2 _position;
    
    private Planet[] neighbors;

    private Area[] _areas { get; set; }
    
    public Planet(Vector2 position, int index) {
        _position = position;
        _index = index;
        
        Console.WriteLine(index + ": " + _position);
    }
    
    public Vector2 GetPosition()
    {
        return _position;
    }

    public Planet[] GetNeighbors() {
        return neighbors;
    }

    public void SetNeighbors(Planet[] neighborSet) {
        neighbors = neighborSet;
    }
    
    
    
    
}