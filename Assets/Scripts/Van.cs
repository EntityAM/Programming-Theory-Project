using UnityEngine;

public class Van : Vehicle  // INHERITANCE
{
    void Start()
    {
        Speed = 7f;                   // ENCAPSULATION: Using the property with validation
        vehicleName = "Van";         // ENCAPSULATION: Accessing protected field from base class
    }

    void Update()
    {
        Move();                       // ABSTRACTION: Inherited method for movement
    }

    public override void DisplayInfo()  // POLYMORPHISM: Overridden method
    {
        Debug.Log("This is a versatile van, good for transporting gear.");
    }
}
