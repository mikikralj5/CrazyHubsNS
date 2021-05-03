using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject lvlCompleteFadeIn;
    public GameObject groundDestruction;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            groundDestruction.SetActive(false);
            lvlCompleteFadeIn.SetActive(true);
        }
    }
}
