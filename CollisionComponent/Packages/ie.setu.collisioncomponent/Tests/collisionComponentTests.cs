using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class collisionComponentTests
{
    [Test]
    public void aabbTest()
    {

        GameObject rightSquare = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/rightSquare"));
        GameObject LefttSquare = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LeftObject"));
        GameObject colManager = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));

        colManager.GetComponent<AABB>().VarInitFunc(rightSquare,LefttSquare);

        Collider2D RightCollider = rightSquare.GetComponent<Collider2D>();
        Collider2D leftCollider = LefttSquare.GetComponent<Collider2D>();

        rightSquare.transform.position = new Vector3(0, 0, 0);
        LefttSquare.transform.position = new Vector3(0, 0, 0);

        bool output= collisionComponent.AABBCollision(rightSquare, LefttSquare, RightCollider, leftCollider);

        Assert.IsTrue(output);

    }



    // circle to box collision test 
    [Test]
    public void CircleToaabbTest()
    {
        // creating the objects 
        GameObject rightSquare = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/rightSquare"));
        GameObject LeftCircle = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LeftObject"));
        GameObject colManager = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));

        // creating the rigid bodys for collision
        Rigidbody2D RightmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();
        Rigidbody2D LeftmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();

        // creating the collider
        BoxCollider2D RightCollider = rightSquare.GetComponent<BoxCollider2D>();
        CircleCollider2D leftCollider = LeftCircle.GetComponent<CircleCollider2D>();

      
        colManager.GetComponent<circleAABB>().VarInitFunc(RightCollider, leftCollider);
        colManager.GetComponent<AABB>().VarInitFunc(rightSquare, LeftCircle);
        
        float speed = 0.0f;
        float Minusspeed = 0.0f;

        LeftCircle.GetComponent<movement>().varInit(speed, LeftmovmentRb);
        rightSquare.GetComponent<movement>().varInit(Minusspeed, LeftmovmentRb);

        rightSquare.transform.position = new Vector3(0,0,0);
        LeftCircle.transform.position = new Vector3(0, 0, 0);

        bool status = colManager.GetComponent<circleAABB>().circleToAABBFunc();

        Assert.IsTrue(status);


    }

    // the ray to cicrcle collision test
    [Test]
    public void rayTocircleCollisionTest()
    {
        // creting the objects and colliders and rigid bodies
        GameObject Circle_object = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LeftObject"));
        GameObject colManager_object = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));
        Rigidbody2D RightmovmentRb = Circle_object.GetComponent<Rigidbody2D>();
        CircleCollider2D leftCollider = Circle_object.GetComponent<CircleCollider2D>();

       
        Circle_object.transform.position = new Vector3(0, 0, 0);
        Vector3 raycastPos = new Vector3(1, 0, 0);

        RaycastHit2D hit = Physics2D.Raycast(Circle_object.transform.position, Vector2.left);
        bool status = false;
        if(hit.collider != null && hit.collider.GetComponent<CircleCollider2D>() != null)
        {
            status = true;
            Debug.Log("hit the circle yippee");
        }

        Assert.IsTrue(status);

       

    }

    // the ray to box collision test
    [Test]
    public void rayToAabbCollisionTest()
    {
        GameObject _squareObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/rightSquare"));
        GameObject colManager_object = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));
        Rigidbody2D RightmovmentRb = _squareObject.GetComponent<Rigidbody2D>();
        BoxCollider2D leftCollider = _squareObject.GetComponent<BoxCollider2D>();





        _squareObject.transform.position = new Vector3(0, 0, 0);
        Vector3 raycastPos = new Vector3(1, 0, 0);

        RaycastHit2D hit = Physics2D.Raycast(_squareObject.transform.position, Vector2.left);
        bool status = false;
        if (hit.collider != null && hit.collider.GetComponent<BoxCollider2D>() != null)
        {
            status = true;
            Debug.Log("hit the box yippee");
        }

        Assert.IsTrue(status);
    }


    

}
