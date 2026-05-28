using UnityEngine;

public class Truck : Vehicle
{

    private float currentSpeed;
    public override float speed
    {
        get { return currentSpeed; }
        set
        {
            currentSpeed = value;
        }
    }
    

    public override void StartVehicle()
    {
        Debug.Log("Truck is started");
    }
    public override void StopVehicle()
    {
        Debug.Log("Truck is stopped");
        //isMoving = true;
    }

    public override void MoveForward()
    {
        Debug.Log("Truck is moving forward");
        transform.Translate(Vector3.up * Time.deltaTime * currentSpeed);
    }

    public override void MoveBackward()
    {
        Debug.Log("Truck is moving backward");
        transform.Translate(Vector3.down * Time.deltaTime * currentSpeed);
    }

    public override void MoveRight()
    {
        Debug.Log("Truck is moving right");
        transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);

    }

    public override void MoveLeft()
    {
        {
            Debug.Log("Truck is moving left");
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }
    public override void Move()
    {
        Debug.Log("Truck is moved");
        if (Input.GetKey(KeyCode.I))
        {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.K))
        {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.L))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.J))
        {
            MoveLeft();

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 50.0f;
        rotationSpeed = 10.0f;
        engineType = "Diesel";
        color = Color.green;
        speed = 10.0f;
        var rend = GetComponent<Renderer>();
        rend.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
