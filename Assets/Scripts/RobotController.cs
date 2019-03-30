using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets._2D;

public class RobotController : MonoBehaviour
{
    private PlatformerCharacter2D m_Character;


    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }


    private void Update()
    {
    }


    private void FixedUpdate()
    {
        m_Character.Move(1f, false, false);
    }
}
