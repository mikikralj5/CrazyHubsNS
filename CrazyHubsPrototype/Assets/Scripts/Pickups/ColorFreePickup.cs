using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFreePickup : MonoBehaviour
{
    public GameObject player;
    private Color color;

    private void Start()
    {
        color = player.GetComponent<Color>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameObject.FindObjectOfType<SoundEffectManager>().PlaySound("FreeState");
            other.transform.GetChild(0).gameObject.SetActive(true);
            color.state = new ColorFree();
            Destroy(this.gameObject);
        }
    }
}
