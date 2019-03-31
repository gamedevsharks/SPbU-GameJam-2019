using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class FlyController : BaseController
{
    private PlatformerCharacter2D m_Character;
    
    public float targetY = 0f;
    
    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }
    
    private void OnEnable()
    {
        Vector2 position = new Vector2(0f, transform.position.y);
        m_Character.Fly(true, new Vector2(0f, targetY) - position);
    }

    private void OnDisable()
    {
        
        m_Character.Fly(false, Vector2.zero);
    }

    private void Update()
    {
        if (Math.Abs(transform.position.y - targetY) < 0.1)
        {
            GetComponent<TransformationScript>().ChangeState(TransformationScript.State.RobotRun);
        }
    }
}
