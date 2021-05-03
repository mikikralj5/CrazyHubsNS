using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFree : ColorState
{
    public override void ChagneColor(Color color, GameObject player)
    {


        List<Material> colors = new List<Material>(2)
        {
              color.playerRed, //red
              color.playerBlue, //blue
              color.playerYellow //yellow
        };

        RemoveRubiks(color);
        //player.tag = "ColorFree";
        int index = Random.Range(0, 3);
        player.GetComponent<Renderer>().material = colors[index];
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
