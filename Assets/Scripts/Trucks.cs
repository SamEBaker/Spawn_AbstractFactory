using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : IVehicle
{
    public void Speak()
    {
        Debug.Log("Truck");
    }
}

public class HeavyGoodsTruck : IVehicle
{
    public void Speak()
    {
        Debug.Log("HeavyGoodsTruck");
    }
}

public class ArticulatedLorry : IVehicle
{
    public void Speak()
    {
        Debug.Log("ArticulatedLorry");
    }
}
