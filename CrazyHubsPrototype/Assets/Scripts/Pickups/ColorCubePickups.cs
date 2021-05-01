using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCubePickups : MonoBehaviour
{
    public Text text;
    int temp = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            temp = int.Parse(text.text);
            temp++;
            text.text = temp.ToString();
            Destroy(gameObject);
        }

    }
}
