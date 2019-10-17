using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    public GameObject mainCamera;
    public bool firstView = false;
   // public Camera thirdViewCam;
    //public Camera firstViewCam;
    // Start is called before the first frame update
    void Start()
    {
        //mainCamera = GameObject.Find("Camera");
        //changeCamera();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            firstView = !firstView;
            changeCamera();
        }*/
        if (!firstView)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                mainCamera.transform.Rotate(Vector3.right, 1);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                mainCamera.transform.Rotate(Vector3.left, 1);
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                mainCamera.transform.Rotate(Vector3.down, 2);
            }
            if (Input.GetAxis("Mouse X") > 0)
            {
                mainCamera.transform.Rotate(Vector3.up, 2);
            }
        }
    }

    /*void changeCamera()
    {
        if (firstView)
        {
            firstViewCam.enabled = true;
            //thirdViewCam.enabled = false;
        }
        else
        {
          //  thirdViewCam.enabled = false;
            firstViewCam.enabled = false;
        }
    }*/
}
