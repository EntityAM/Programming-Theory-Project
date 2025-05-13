using UnityEngine;

public class Tank : Vehicle  // INHERITANCE
{
    void Start()
    {
        Speed = 4f;                     // ENCAPSULATION: Using the protected property to safely set speed
        vehicleName = "Tank";          // ENCAPSULATION: Direct access within derived class
    }

    void Update()
    {
        Move();                        // ABSTRACTION: Using the generalized Move() method from base class
    }

    public override void DisplayInfo()  // POLYMORPHISM: Overriding method from base class
    {
        Debug.Log("This is a heavy-duty tank, built for power over speed.");
    }
}
