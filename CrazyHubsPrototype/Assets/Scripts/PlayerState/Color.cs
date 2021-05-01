using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public ColorState state;
    public Text blueText;
    public Text redText;
    public Text yellowText;
    private int cubesToCollect = 2;


    void Start()
    {
        state = new ColorRed();
        InvokeRepeating("ChangeColor", 5, 5);
        
      
    }

    private void Update()
    {
        RubicksCollectionSwitch();
    }
    void ChangeColor()
    {
        state.ChagneColor(this,gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Platform is" + other.tag);
        Debug.Log("State is" + state.GetType().Name);
        if(other.CompareTag(state.GetType().Name))
        {
            state.CollisionChangeUp(gameObject);

            Debug.Log("speedup");
        }
        else if (state.GetType().Name == "ColorFree")
        {
            state.CollisionChangeUp(gameObject);
            Debug.Log("speedup in ColorFree state");
        }
        else if(!other.CompareTag(state.GetType().Name))
        {
            state.CollisionChangeDown(gameObject);
            Debug.Log("slowed");
        }
      
       
    }

    private void RubicksCollectionSwitch()
    {
        int blueValue = int.Parse(blueText.text);
        int redValue = int.Parse(redText.text);
        int yellowValue = int.Parse(yellowText.text);


        if (blueValue >= cubesToCollect && redValue >= cubesToCollect && yellowValue >= cubesToCollect)
        {
            state = new ColorFree();
            blueText.text = "0";
            redText.text = "0";
            yellowText.text = "0";
        }
    }
}
