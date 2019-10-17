using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour
{
    //public GameObject vectorObject;
    //public GameObject car;
    public float speed;
    public int life;
    public int times;
    public int time;
    public bool pause = false;
    public bool end = false;
    public Vector3 origVec;
    public Quaternion origQuat;

	//arrive wall
	private Text arriveText;

	//coin count
	private int count;
	private Text coinCount;

    // Start is called before the first frame update
    void Start()
    {
        //car = GameObject.Find("lamborghini-aventador");
        origVec = transform.position;
        origQuat = transform.rotation;
        speed = 0.15f;
        life = 10;
        time = 0;
        times = 100;

		//coin and arrive all
		count = 0;
		arriveText = GameObject.FindGameObjectWithTag ("Finish").GetComponent<Text>();
		arriveText.enabled = false;
		coinCount = GameObject.FindGameObjectWithTag ("CoinCountText").GetComponent<Text> ();
		coinCount.text = coinCount.text = "Coins: " + count.ToString() + "   Speed: " + speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
		coinCount.text = "Coins: " + count.ToString() +"   Speed: " + speed.ToString();
        if (!pause && !end)
        {
            checkSpeed();
            Vector3 originalDir = transform.forward;
            Vector3 targetDir = Vector3.zero;
            Quaternion offsetRot = Quaternion.AngleAxis(0, transform.up);
            targetDir = offsetRot * originalDir * speed;
            transform.position += targetDir;
        }
		if (Input.GetKeyDown(KeyCode.W) && speed <= 1)
        {
            if (pause)
            {
                pause = false;
            }
            else
            {
                speed = speed + 0.05f;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 2);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up;
        }
        if (end)
        {
            //transform.position = origVec;
            //transform.rotation = origQuat;
            if (Input.GetKeyDown(KeyCode.Escape))
            {
				SceneManager.LoadScene("Quit");
                //end = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!end)
            {
                pause = !pause;
            }
            else
            {
                end = false;
            }
        }
    }

    void checkSpeed()
    {
        if (time == 0 && speed <= 1)
        {
            speed = speed + 0.03f;
            time = times;
        }
        time--;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Break")
        {
            speed -= 0.05f;
            collision.gameObject.SetActive(false);
        }

		if (collision.gameObject.tag == "Coin") {
			collision.gameObject.SetActive (false);
			count++;
		}

		if (collision.gameObject.tag == "Arrive") {
			arriveText.enabled = true;
			end = true;
		}
		
        if (collision.gameObject.name == "mountain-race-track")
        {
            pause = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "mountain-race-track")
        {
            pause = true;
        }
    }
}
