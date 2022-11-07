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
    void circleToAABBFunc()
    {

        //circle to aabb collision
        float sqDistanceBetweenCenters = Vector3.Distance(object1Collider.bounds.center, CircleCollider.bounds.center);
        if (sqDistanceBetweenCenters > Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        {
            // this will show that they are not colliding 
        }
        if (sqDistanceBetweenCenters < Mathf.Sqrt((object1Collider.edgeRadius) + CircleCollider.radius))
        {
            // this shows that they are colliding
            Debug.Log("yes collision");
        }

    }
}
