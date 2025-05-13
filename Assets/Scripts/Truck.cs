using UnityEngine;

public class Truck : Vehicle  // INHERITANCE
{
    private float cargoCapacity = 500f;  // ENCAPSULATION: Private field only used internally

    void Start()
    {
        Speed = 6f;                      // ENCAPSULATION: Setting via public property with validation
        vehicleName = "Truck";          // ENCAPSULATION: Protected field from base class
    }

    void Update()
    {
        Move();                          // ABSTRACTION: Inherited generalized movement behavior
    }

    public override void DisplayInfo()   // POLYMORPHISM: Overridden method
    {
        Debug.Log("This is a truck with a cargo capacity of " + cargoCapacity + " kg.");
    }
}
