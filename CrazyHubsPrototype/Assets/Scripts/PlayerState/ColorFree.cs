using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFree : ColorState
{
    public override void ChagneColor(Color color, GameObject player)
    {

        List<UnityEngine.Color> colors = new List<UnityEngine.Color>(3)
        {
             new UnityEngine.Color(128, 0, 0), //red
             new UnityEngine.Color(0,0,128),//blue
             new UnityEngine.Color(255,255,0) //yellow
        };

        RemoveRubiks(color);
        //player.tag = "ColorFree";
        int index = Random.Range(0, 3);
        player.GetComponent<Renderer>().material.color = colors[index];
        ChangeState(color, index, player);
    }

    private void RemoveRubiks(Color color)
    {
        if (color.gameObject.transform.GetChild(0).gameObject.activeSelf)
        {
            color.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public override void ChangeState(Color color, int index, GameObject player)
    {
        if (index == 0)
        {
            RenderSettings.skybox = color.skyBoxRed;
            color.ShowRedParticle(player);
            color.state = new ColorRed();          
        } 
        else if (index == 1)
        {
            RenderSettings.skybox = color.skyBoxBlue;
            color.ShowBlueParticle(player);
            color.state = new ColorBlue();
        }   
        else
        {
            RenderSettings.skybox = color.skyBoxYellow;
            color.ShowYellowParticle(player);
            color.state = new ColorYellow();
        }
           
    }

    public override void CollisionChangeUp(GameObject player)
    {
        //player.GetComponent<PlayerController>().ForwardSpeed += 0.1f;
        speedUp += 0.04f;
        player.GetComponent<PlayerController>().ForwardSpeed = speedUp;
        Debug.Log("SpeedUp" + speedUp);
    }

    public override void CollisionChangeDown(GameObject player)
    {
        return;
    }

   
}
