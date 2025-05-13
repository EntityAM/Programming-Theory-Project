using UnityEngine;

// INHERITANCE
public class Bus : Vehicle
{
    private int passengerCapacity = 40; // ENCAPSULATION example (private field)

    private void Start()
    {
        Speed = 6f;        // ENCAPSULATION via property
        TurnSpeed = 40f;   // ENCAPSULATION via property
        vehicleName = "Bus";
    }

    // POLYMORPHISM: Override Move with custom logging
    public override void Move()
    {
        base.Move(); // ABSTRACTION: Reuse base movement
        Debug.Log("Bus is moving steadily with passengers.");
    }

    // POLYMORPHISM: Override DisplayInfo
    public override void DisplayInfo()
    {
        Debug.Log("This is a bus that can carry " + passengerCapacity + " passengers.");
    }
}
