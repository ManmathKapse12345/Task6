using UnityEngine;

public class Bike : Vehicle
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
        get { return 20.0f; }
    }

    public override float speed
    {
        get { return 30.0f; }
    }

    public override float rotationSpeed
    {
        get { return 20.0f; }
    }

    public override string engineType
    {
        get { return "Petrol"; }
    }

    public override Color color
    {
        get { return Color.blue; }
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
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * speed);
            transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);

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
