using UnityEngine;

public class Car : Vehicle
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
        Debug.Log("Car is started");
    }

    public override void StopVehicle()
    {
        Debug.Log("Car is stopped");
        //isMoving = true;
    }

    public override void MoveForward()
    {
        Debug.Log("Car is moving forward");
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
    }

    public override void MoveBackward()
    {
        Debug.Log("Car is moving backward");
        transform.Translate(Vector3.back* Time.deltaTime * currentSpeed);
    }

    public override void MoveLeft()
    {
        Debug.Log("Car is moving left");
        transform.Rotate(Vector3.down * Time.deltaTime * currentSpeed);
    }

    public override void MoveRight()
    {
        Debug.Log("Car is moving right");
        transform.Rotate(Vector3.up*Time.deltaTime* currentSpeed);
    }
    public override void Move()
    {
        Debug.Log("Car is moved");
        if (Input.GetKey(KeyCode.T))
        {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.G))
        {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.H))
        {
            MoveRight();

        }
        if (Input.GetKey(KeyCode.F))
        {
            MoveLeft();

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 30.0f;
        rotationSpeed = 15.0f;
        speed = 20.0f;
        engineType = "CNG";
        color = Color.red;
        var rend = GetComponent<Renderer>();
        rend.material.color = color;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
