using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public GameObject player;
    Vector3 offset = new Vector3(0, 1.7f, -8);
 

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
