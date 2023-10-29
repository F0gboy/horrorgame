using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    RaycastHit hit;
    void Update()
        {
        
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.forward, Color.red);
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.forward, out hit))
        {
            hit.transform.SendMessage("HitByRay", null, SendMessageOptions.DontRequireReceiver);

        }
        }
}
