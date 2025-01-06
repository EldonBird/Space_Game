namespace SpaceGame.Scripts.Generation;
using System;
public class Area {

    
    // for current locations, This is the funciton taht you would want to call when you want to get all of the locaitons currently in the location.sure
    private Location[] _locations { get; set; }

    
    
    // this is for all available locations, not for the current ones. The same as in the domain, given the name.
    public virtual Location[] DomainOfLocations() {


        return null;
    }
    
}