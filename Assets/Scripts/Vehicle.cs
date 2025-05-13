using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // ENCAPSULATION: backing field with property
    [SerializeField] protected float speed = 10f;
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value < 0)
                Debug.LogWarning("Speed can't be negative.");
            else
                speed = value;
        }
    }

    // ENCAPSULATION: backing field with property
    [SerializeField] protected float turnSpeed = 100f;
    public float TurnSpeed
    {
        get { return turnSpeed; }
        set
        {
            if (value < 0)
                Debug.LogWarning("Turn speed can't be negative.");
            else
                turnSpeed = value;
        }
    }

    [SerializeField] public Camera vehicleCamera;

    protected string vehicleName = "Generic Vehicle";

    // ABSTRACTION: movement logic
    public virtual void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * vertical * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);
    }

    // ABSTRACTION: Display vehicle info
    public virtual void DisplayInfo()
    {
        Debug.Log("This is a: " + vehicleName);
    }
}
