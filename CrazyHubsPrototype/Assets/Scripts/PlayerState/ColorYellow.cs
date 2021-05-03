using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorYellow : ColorState
{

   

    public override void ChagneColor(Color color, GameObject player)
    {

        List<UnityEngine.Color> colors = new List<UnityEngine.Color>(2)
        {
             new UnityEngine.Color(128, 0, 0), //red
             new UnityEngine.Color(0,0,128) //blue
        };

       
        if (!RubicksCollectionSwitch(color))
        {
            int index = Random.Range(0, 2);
            player.GetComponent<Renderer>().material.color = colors[index];
            ChangeState(color, index, player);
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
        else
        {
            RenderSettings.skybox = color.skyBoxBlue;
            color.ShowBlueParticle(player);
            color.state = new ColorBlue();
        }
           
    }

    public override void CollisionChangeUp(GameObject player)
    {
        //player.GetComponent<PlayerController>().ForwardSpeed += speedUp;
        //Debug.Log(speedUp);
        player.GetComponent<PlayerController>().ForwardSpeed = speedUp;
    }

    public override void CollisionChangeDown(GameObject player)
    {
        //player.GetComponent<PlayerController>().ForwardSpeed -= speedDown;
        //Debug.Log(speedDown);
        if (!((player.GetComponent<PlayerController>().ForwardSpeed - speedDown) < minSpeed))
            player.GetComponent<PlayerController>().ForwardSpeed -= speedDown;
    }
}
