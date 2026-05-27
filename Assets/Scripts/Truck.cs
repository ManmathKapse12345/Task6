using UnityEngine;

public class Truck : Vehicle
{
    public override bool isStarted
    {
        get { return false; }
    }
    public override bool isMoving
    {
        get { return false; }
    }
    public override bool isStopped
    {
        get { return true; }
    }
    public override float power
    {
        get { return 50.0f; }
    }

    public override float speed
    {
        get { return 5.0f; }
    }

    public override float rotationSpeed
    {
        get { return 10.0f; }
    }

    public override string engineType
    {
        get { return "Diesel"; }
    }

    public override Color color
    {
        get { return Color.green; }
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
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * speed);
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
