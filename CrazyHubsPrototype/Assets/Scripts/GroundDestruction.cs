using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestruction : MonoBehaviour
{
    //private GameObject[] groundParts;
    private List<Transform> groundParts = new List<Transform>();
    public GameObject ground;
    private void Start()
    {

        //groundParts=ground.GetComponentsInChildren<GameObject>();
        foreach (Transform child in ground.transform)
        {
            groundParts.Add(child);
        }

      

        InvokeRepeating("GroundDestroy", 0, 0.7f);
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
