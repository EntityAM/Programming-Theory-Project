using UnityEngine;

// INHERITANCE
public class Car : Vehicle
{
    private void Start()
    {
        Speed = 10f;             // ENCAPSULATION: Setting via property
        TurnSpeed = 80f;         // ENCAPSULATION: Custom turn speed via property
        vehicleName = "Car";     // ENCAPSULATION: Accessing protected field
    }

    private void Update()
    {
        Move();                  // ABSTRACTION: Shared movement logic
    }

    public override void DisplayInfo()   // POLYMORPHISM
    {
        Debug.Log("This is a standard car, designed for balanced performance.");
    }
}
