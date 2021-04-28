﻿using System.Collections;
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
       
        player.tag = "ColorYellow";
        int index = Random.Range(0, 2);
        player.GetComponent<Renderer>().material.color = colors[index];
        ChangeState(color, index);
    }

    public override void ChangeState(Color color, int index)
    {


        if (index == 0)
            color.state = new ColorRed();
        else
            color.state = new ColorBlue();
    }

    public override void CollisionChangeUp(GameObject player)
    {
        player.GetComponent<PlayerController>().ForwardSpeed += 0.5f;
    }

    public override void CollisionChangeDown(GameObject player)
    {
        player.GetComponent<PlayerController>().ForwardSpeed -= 0.3f;
    }
}