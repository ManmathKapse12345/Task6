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
    public override void Move()
    {
        Debug.Log("Truck is moved");
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.up * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.down * Time.deltaTime * currentSpeed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);

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
