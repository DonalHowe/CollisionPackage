using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleAABB : MonoBehaviour
{

    public CircleCollider2D CircleCollider;
    public BoxCollider2D object1Collider;
    public  bool isCOlliding = false;
  

    public void VarInitFunc(BoxCollider2D Box, CircleCollider2D circle)
    {
        CircleCollider = circle!;
        object1Collider = Box;
       
    }
    
    void Update()
    {
        
        isCOlliding = circleToAABBFunc();
    }

    public bool circleToAABBFunc()
    {

        //circle to aabb collision
        float sqDistanceBetweenCenters = Vector3.Distance(object1Collider.bounds.center, CircleCollider.bounds.center);
        //if (sqDistanceBetweenCenters > Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        //{
        //   // if they dont collide
        //}
        if (sqDistanceBetweenCenters < Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        {
            // this shows that they are colliding
           // Debug.Log("circle to box collision");
            return true;
        }
        return false;
    }
}
