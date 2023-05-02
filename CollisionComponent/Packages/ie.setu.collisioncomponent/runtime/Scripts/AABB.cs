using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABB : MonoBehaviour
{
    public GameObject object2;// the second object
    public GameObject object1;// the first object

    public BoxCollider2D object2Collider;
    public BoxCollider2D object1Collider;
    
    public void VarInitFunc(GameObject g_1,GameObject g_2)
    {
        object1 = g_1!;
        object2 = g_2;
        object2Collider = object2.GetComponent<BoxCollider2D>();
        object1Collider = object1.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {

        AAbbCollision();
    }

    // box to box collision function 
    public bool AAbbCollision()
    {
        // checks to see if object 1.pos.x is less than object 2+the width of object 2
        if (object1.transform.position.x < object2.transform.position.x + object2Collider.bounds.size.x &&
            // checks to see if object 1 + width is greater than the object 2. postition . x
            object1.transform.position.x + object1Collider.bounds.size.x > object2.transform.position.x &&
            // checks to see if object 1 .y is less than object 2 .position.y + height of object 2
            object1.transform.position.y < object2.transform.position.y + object2Collider.bounds.size.y &&
            // checks to see if object 1 position.y is greater than object 2. position + object 2 height
            object1.transform.position.y + object1Collider.bounds.size.y > object2.transform.position.y)
        {
            //Debug.Log(" box to box collision");
            return true;
        }
        else
        {
            return false;
        }
    }
}
