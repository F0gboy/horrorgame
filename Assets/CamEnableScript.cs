using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamEnableScript : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] GameObject Cam;
    bool windowActive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void HitByRay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = Player.transform.position - transform.position;
            Debug.Log(Vector3.Distance(Player.transform.position, transform.position) + " " + Vector3.Dot(forward.normalized, toOther.normalized));
            if (Vector3.Distance(Player.transform.position, transform.position) < 2f)
            {
                Debug.Log("Did the thing");
                Player.SetActive(false);
                Cam.SetActive(true);
                windowActive = true;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (windowActive == true)
            {
                Player.SetActive(true);
                Cam.SetActive(false);
                windowActive = false;

            }
        }
    }
}

