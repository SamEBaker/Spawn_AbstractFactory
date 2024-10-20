using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MotorBike : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Motorbike");
    }
}

    public class TriBike : IVehicle
    {
    public void Speak()
    {
        Debug.Log("TriBike");
    }
}
