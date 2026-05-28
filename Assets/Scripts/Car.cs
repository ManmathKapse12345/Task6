using UnityEngine;

public class Car : Vehicle
{
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
        get { return 30.0f; }
    }

    public override float speed
    {
        get { return 10.0f; }
    }
    public override float rotationSpeed
    {
        get { return 15.0f; }
    }
    public override string engineType
    {
        get { return "CNG"; }
    }

    public override Color color
    {
        get { return Color.red; }
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
    public override void Move()
    {
        Debug.Log("Car is moved");
        if (Input.GetKey(KeyCode.T))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var rend = GetComponent<Renderer>();
        rend.material.color = color;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
