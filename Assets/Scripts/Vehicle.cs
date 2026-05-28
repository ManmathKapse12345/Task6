using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float power = 50.0f;
    private float currentSpeed;
    public virtual float speed
    {
        get { return currentSpeed; }
        set
        {
            currentSpeed = value;
        }
    }

    public float rotationSpeed = 5.0f;
    public string engineType = "fuel";
    public Color color = Color.white;
    
    public virtual void StartVehicle()
    {
        Debug.Log("Vehicle is started");
    }

    public virtual void StopVehicle()
    {
        Debug.Log("Vehicle is stopped");
        //isMoving = true;
    }

    public virtual void Move()
    {
        Debug.Log("Vehicle is moved");
    }
}
