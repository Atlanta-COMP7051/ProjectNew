using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMove : MonoBehaviour
{
    /*private GameObject wheelFL;
    private GameObject wheelFR;
    private GameObject wheelBA;*/
    private GameObject car;
    private CarMove carMove;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("jeep");
        carMove = car.GetComponent<CarMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 45)
        {
            speed = carMove.speed * 50;
        }
        if(!carMove.pause && !carMove.end)
        {
            transform.Rotate(Vector3.right, speed);
        }
    }

    //function to move the wheel
    void moveWheel(Transform transform)
    {
        transform.Rotate(Vector3.back, speed);
    }
}
