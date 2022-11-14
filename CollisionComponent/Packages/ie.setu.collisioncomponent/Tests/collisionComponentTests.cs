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




    [Test]
    public void CircleToaabbTest()
    {

        GameObject rightSquare = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/rightSquare"));
        GameObject LeftCircle = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LeftObject"));
        GameObject colManager = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));

        Rigidbody2D RightmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();
        Rigidbody2D LeftmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();

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



    [Test]
    public void rayCollisionTests()
    {

        GameObject rightSquare = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/rightSquare"));
        GameObject LeftCircle = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/LeftObject"));
        GameObject colManager = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/CollisionManager"));

        Rigidbody2D RightmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();
        Rigidbody2D LeftmovmentRb = LeftCircle.GetComponent<Rigidbody2D>();

        BoxCollider2D RightCollider = rightSquare.GetComponent<BoxCollider2D>();
        CircleCollider2D leftCollider = LeftCircle.GetComponent<CircleCollider2D>();

        colManager.GetComponent<circleAABB>().VarInitFunc(RightCollider, leftCollider);
        colManager.GetComponent<AABB>().VarInitFunc(rightSquare, LeftCircle);

        float speed = 0.0f;
        float Minusspeed = 0.0f;

        LeftCircle.GetComponent<movement>().varInit(speed, LeftmovmentRb);
        rightSquare.GetComponent<movement>().varInit(Minusspeed, LeftmovmentRb);

        rightSquare.transform.position = new Vector3(0, 0, 0);
        LeftCircle.transform.position = new Vector3(0, 0, 0);

        bool status = colManager.GetComponent<circleAABB>().circleToAABBFunc();

        Assert.IsTrue(status);


    }

}
