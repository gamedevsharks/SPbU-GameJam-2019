using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets._2D;

public class RobotController : MonoBehaviour
{
    private PlatformerCharacter2D m_Character;

    private Vector2 target = new Vector2(-5f, 0f);
    
    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }


    private void Update()
    {
    }


    private void FixedUpdate()
    {
        float diff = transform.position.x - target.x;
        if (Math.Abs(diff) < 0.1)
        {
            m_Character.Move(0f, false, false);
            return;
        }
        
        if (diff < 0)
        {
            m_Character.Move(1f, false, false);
        }
        else
        {
            m_Character.Move(-1f, false, false);
        }
        
    }
}
