using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public bool isStarted = false;
    public bool isMoving = false;
    public bool isStopped = true;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartVehicle();
    }

    // Update is called once per frame
    void Update()
    {
        //if (isStarted && !isMoving && !isStopped)
        //{
        //    StartVehicle();
        //}
        //if (isMoving && !isStopped)
        //{
        //    Move();
        //}
        //if (isStopped)
        //{
        //    StopVehicle();
        //}

        if (isStarted)
        {
            StartVehicle();
        }
        if (isMoving)
        {
            Move();
        }
        if (isStopped)
        {
            StopVehicle();
        }
    }
    public void StartVehicle()
    {
        Debug.Log("Vehicle is started");
    }

    public void StopVehicle()
    {
        Debug.Log("Vehicle is stopped");
        //isMoving = true;
    }

    public void Move()
    {
        Debug.Log("Vehicle is moved");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void OnMouseDown()
    {
        if (!isStarted)
        {
            isStarted = true;
            isStopped = false;
        }
        else if (!isMoving)
        {
            isStarted = false;
            isMoving = true;
            isStopped = false;
        }
        else if (!isStopped)
        {
            isMoving = false;
            isStopped = true;
            isStarted = false;
        }

    }
}
