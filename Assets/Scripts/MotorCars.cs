using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Sedan : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Sedan");
    }
}

    public class MPV : IVehicle
    {
    public void Speak()
    {
        Debug.Log("MPV");
    }
}

    public class Van : IVehicle
    {
    public void Speak()
    {
        Debug.Log("Van");
    }
}
