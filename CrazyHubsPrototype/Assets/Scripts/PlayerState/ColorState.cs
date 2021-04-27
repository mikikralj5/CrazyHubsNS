using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ColorState 
{

   
    public abstract void ChagneColor(Color color,GameObject player);
    public abstract void ChangeState(Color color,int index);
    public abstract void CollisionChangeUp(GameObject player);
    public abstract void CollisionChangeDown(GameObject player);



}
