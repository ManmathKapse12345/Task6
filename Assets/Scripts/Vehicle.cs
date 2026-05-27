using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public virtual bool isStarted
    {
        get { return false; }
    }
    public virtual bool isMoving
    {
        get { return false; }
    }
    public virtual bool isStopped
    {
        get { return true; }
    }
    public virtual float power
    {
        get { return 50.0f; }
    }
    public virtual float speed
    {
        get { return 5.0f; }
    }
    public virtual string engineType
    {
        get { return "fuel"; }
    }
    public virtual Color color
    {
        get { return Color.white; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    StartVehicle();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //if (isStarted && !isMoving && !isStopped)
    //    //{
    //    //    StartVehicle();
    //    //}
    //    //if (isMoving && !isStopped)
    //    //{
    //    //    Move();
    //    //}
    //    //if (isStopped)
    //    //{
    //    //    StopVehicle();
    //    //}

    //    if (isStarted)
    //    {
    //        StartVehicle();
    //    }
    //    if (isMoving)
    //    {
    //        Move();
    //    }
    //    if (isStopped)
    //    {
    //        StopVehicle();
    //    }
    //}
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
        //if(gameObject.name == "Cylinder")
        //{
        //    transform.Translate(Vector3.up * Time.deltaTime * speed);
        //}
        //else
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    //public void OnMouseDown()
    //{
    //    if (!isStarted)
    //    {
    //        isStarted = true;
    //        isStopped = false;
    //    }
    //    else if (!isMoving)
    //    {
    //        isStarted = false;
    //        isMoving = true;
    //        isStopped = false;
    //    }
    //    else if (!isStopped)
    //    {
    //        isMoving = false;
    //        isStopped = true;
    //        isStarted = false;
    //    }

    //}
}
