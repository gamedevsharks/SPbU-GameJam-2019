using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class FlyController : BaseController
{
    private PlatformerCharacter2D m_Character;
    
    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }
    
    private void OnEnable()
    {
        m_Character.Fly(true);
    }

    private void OnDisable()
    {
        m_Character.Fly(false);
    }
}
