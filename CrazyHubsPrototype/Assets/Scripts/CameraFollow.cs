using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform playerPos;
    //private Vector3 offset;

    //void Start()
    //{
    //    offset = transform.position - playerPos.position;
    //}

    //void LateUpdate()
    //{
    //    Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z + playerPos.position.z);
    //    transform.position = Vector3.Lerp(transform.position, newPosition, 0.6f);
    //}

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
