using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTocircle : MonoBehaviour
{

    public CircleCollider2D m_circleOneCollider;
    public CircleCollider2D m_circleTwoCollider;
    // Start is called before the first frame update
    void Start()
    {

    }

   
   


    public void VarInitFunc(CircleCollider2D circleOne, CircleCollider2D circleTwo)
    {
        m_circleOneCollider = circleOne;
        m_circleTwoCollider = circleTwo;

    }

    void Update()
    {

        circleToCircleFunc();
    }

    public bool circleToCircleFunc()
    {

        float distance = Vector3.Distance(m_circleOneCollider.bounds.center, m_circleTwoCollider.bounds.center);
        // if the distance is less than the radius they are colliding if it is not they are not colliding
        if (distance< Mathf.Sqrt((m_circleOneCollider.radius) + m_circleTwoCollider.radius))
        {
            
            return true;
        }
        else
        {
            return false;
        }
       

    }
}
