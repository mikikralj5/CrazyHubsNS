using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestruction : MonoBehaviour
{
    //private GameObject[] groundParts;
    private List<Transform> groundParts = new List<Transform>();
    public GameObject ground;
    public float repeatRate = 0.4f;
    public float startRate = 1.5f;
    private void Start()
    {

        //groundParts=ground.GetComponentsInChildren<GameObject>();
        foreach (Transform child in ground.transform)
        {
            foreach(Transform item in child)
                groundParts.Add(item);
        }

      

        InvokeRepeating("GroundDestroy", startRate, repeatRate);
    }

    private void GroundDestroy()
    {

        if (groundParts.Count > 0)
        {
            Destroy(groundParts[0].gameObject);
            groundParts.RemoveAt(0);
        }
            


    }
}
