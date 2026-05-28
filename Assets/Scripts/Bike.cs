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
    public override void Move()
    {
        Debug.Log("Bike is moved");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);

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
