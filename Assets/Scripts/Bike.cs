using UnityEngine;

public class Bike : Vehicle
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
        Debug.Log("Bike is started");
    }
    public override void StopVehicle()
    {
        Debug.Log("Bike is stopped");
        //isMoving = true;
    }

    public override void MoveForward()
    {
        Debug.Log("Bike is moving forward");
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
    }

    public override void MoveBackward()
    {
        Debug.Log("Bike is moving backward");
        transform.Translate(Vector3.back * Time.deltaTime * currentSpeed);
    }

    public override void MoveLeft()
    {
        Debug.Log("Bike is moving left");
        transform.Rotate(Vector3.down * Time.deltaTime * currentSpeed);
    }

    public override void MoveRight()
    {
        Debug.Log("Bike is moving right");
        transform.Rotate(Vector3.up * Time.deltaTime * currentSpeed);
    }


    public override void Move()
    {
        Debug.Log("Bike is moved");
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();

        }
        if (Input.GetKey(KeyCode.Q))
        {
            accelerate();
        }
    }
    public void accelerate()
    {
        speed = speed + 2.0f;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 20.0f;
        rotationSpeed = 20.0f;
        engineType = "Petrol";
        color = Color.blue;
        speed = 30.0f;
        var rend = GetComponent<Renderer>();
        rend.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
