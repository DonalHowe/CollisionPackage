using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactions : MonoBehaviour
{
    public AABB m_aabb;
    public circleAABB m_circleAABB;
    public circleTocircle m_circleTocircle;
    public SpriteRenderer m_circleColor;
    public SpriteRenderer m_squareColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the reaction for the bounding box to bounding box collision
        if (m_aabb.AAbbCollision() == true)
        {
            Debug.Log(" box to box collision");
            m_squareColor.material.color=  Color.yellow;
        }
        else
        {
            m_squareColor.color = new Color(1, 1, 1);
        }
        // the reaction for the circle to bounding box collision
        if (m_circleAABB.circleToAABBFunc() == true)
        {
            Debug.Log(" circle to box collision");
            m_circleColor.material.color = Color.blue;
        }
        else
        {
            m_circleColor.color = new Color(1, 1, 1);
        }
        // the reaction for the circle to circle collision
        if(m_circleTocircle.circleToCircleFunc() == true)
        {
            Debug.Log(" circle to circle collision");
            m_circleColor.material.color = Color.green;
        }
        else
        {
            m_circleColor.color = new Color(1, 1, 1);
        }
    }
}
