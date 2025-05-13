using UnityEngine;

public class VehicleController : MonoBehaviour
{
    private Vehicle[] vehicles;
    private int currentIndex = 0;

    void Start()
    {
        vehicles = GetComponentsInChildren<Vehicle>(true); // includes inactive
        ActivateVehicle(currentIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentIndex = (currentIndex + 1) % vehicles.Length;
            ActivateVehicle(currentIndex);
        }

        if (vehicles[currentIndex] != null)
        {
            vehicles[currentIndex].Move();
        }
    }

    private void ActivateVehicle(int index)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            bool isActive = (i == index);
            vehicles[i].gameObject.SetActive(isActive);

            if (vehicles[i].vehicleCamera != null)
                vehicles[i].vehicleCamera.enabled = isActive;
        }

        Debug.Log("Switched to: " + vehicles[index].name);
    }
}
