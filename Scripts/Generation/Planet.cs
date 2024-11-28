using System;
using System.Numerics;

namespace SpaceGame.Scripts.Generation;

public class Planet : Patient {
    
    private int _index;
    private Vector2 _position;
    
    
    
    
    public Planet(Vector2 position, int index) {
        _position = position;
        _index = index;
        
        Console.WriteLine(index + ": " + _position);
    }
    
    
    
    
}