using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleAABB : MonoBehaviour
{

    public CircleCollider2D CircleCollider;
    public BoxCollider2D object1Collider;

    // Update is called once per frame
    void Update()
    {

        circleToAABBFunc();
    }

    public void VarInitFunc(BoxCollider2D Box, CircleCollider2D circle)
    {
        CircleCollider = circle!;
        object1Collider = Box;
       
    }

    public bool circleToAABBFunc()
    {
        bool retunrValue=false;
        //circle to aabb collision
        float sqDistanceBetweenCenters = Vector3.Distance(object1Collider.bounds.center, CircleCollider.bounds.center);
        if (sqDistanceBetweenCenters > Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        {
            retunrValue = false;
        }
        if (sqDistanceBetweenCenters < Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        {
            // this shows that they are colliding
            Debug.Log("yes collision");
            retunrValue= true;
        }
        return retunrValue;
    }
}
