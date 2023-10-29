using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowCamScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    Camera cam;

    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        if (transform.eulerAngles.x > 36 && transform.eulerAngles.x < 100)
        {
                
            transform.eulerAngles = new Vector3(35, transform.eulerAngles.y, transform.eulerAngles.z);
        }
        if (transform.eulerAngles.x < 355 && transform.eulerAngles.x > 100)
        {

            transform.eulerAngles = new Vector3(-5, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if (Input.GetMouseButton(1))
        {
            if(cam.fieldOfView > 15)
            {
                cam.fieldOfView -= 20f * Time.deltaTime;
            }
        }
        else
        {
            if (cam.fieldOfView < 40)
            {
                cam.fieldOfView += 20f * Time.deltaTime;
            }
        }

        //if (transform.eulerAngles.y > 221)
        //{

        //    transform.eulerAngles = new Vector3(transform.eulerAngles.x, 220, transform.eulerAngles.z);
        //    Debug.Log("Error 3");
        //}
        //if (transform.eulerAngles.y < 141)
        //{

        //    transform.eulerAngles = new Vector3(transform.eulerAngles.x, 140, transform.eulerAngles.z);
        //    Debug.Log("Error 4");
        //}

    }
}
