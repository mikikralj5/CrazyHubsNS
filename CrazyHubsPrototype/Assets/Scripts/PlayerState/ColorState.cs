using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ColorState 
{

   
    public abstract void ChagneColor(Color color,GameObject player);
    public abstract void ChangeState(Color color,int index);
    public abstract void CollisionChangeUp(GameObject player);
    public abstract void CollisionChangeDown(GameObject player);

    //protected float speedUp = PlayerPrefs.GetFloat("PlayerSpeedup",0.5f);
    //protected float speedDown = PlayerPrefs.GetFloat("PlayerSlow", 0.3f);

    protected float speedUp = PlayerPrefs.GetFloat("PlayerSpeedup", 10f);
    protected float speedDown = PlayerPrefs.GetFloat("PlayerSlow", 5f);




    protected bool RubicksCollectionSwitch(Color color)
    {
        int blueValue = int.Parse(color.blueText.text);
        int redValue = int.Parse(color.redText.text);
        int yellowValue = int.Parse(color.yellowText.text);
        bool temp = false;


        if (blueValue >= color.cubesToCollect && redValue >= color.cubesToCollect && yellowValue >= color.cubesToCollect)
        {
            color.state = new ColorFree();
            color.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            temp = true;
            color.blueText.text = (blueValue - color.cubesToCollect).ToString();
            color.redText.text = (redValue - color.cubesToCollect).ToString();
            color.yellowText.text = (yellowValue - color.cubesToCollect).ToString();
            
        }

        return temp;
    }
   



}
