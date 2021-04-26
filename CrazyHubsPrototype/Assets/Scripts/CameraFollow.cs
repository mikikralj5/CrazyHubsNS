using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
    public GameObject player;
    Vector3 offset;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(-player.transform.position.x, 2, -12);
        transform.position = player.transform.position + offset;

        
    }
}
