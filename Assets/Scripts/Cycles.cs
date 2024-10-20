using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Unicycle : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Unicycle");
    }
}
    public class Bicycle : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Bicycle");
    }
}

    public class Tandem : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Tandem");
    }
}

    public class Tricyle : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Tricycle");
    }
}

    public class FamilyBike : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Family Bike");
    }
}

    public class GoKart : IVehicle
    {
    public void Speak()
    {
        Debug.Log("GoKart");
    }
}

