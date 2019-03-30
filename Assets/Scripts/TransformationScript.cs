using System;
using UnityEngine;
using UnityStandardAssets._2D;

public class TransformationScript : MonoBehaviour
{
    public enum State
    {
        Human, Robot
    }

    public State currentState = State.Human;

    private PlatformerCharacter2D m_Character;
    
    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            ChangeState();
        }
    }

    private void ChangeState()
    {
        m_Character.Move(0f, false, false);
        if (currentState == State.Human)
        {
            currentState = State.Robot;
            GetComponent<AccumulatorScript>().IsActive = true;
            GetComponent<Platformer2DUserControl>().enabled = false;
        }
        else
        {
            currentState = State.Human;
            GetComponent<AccumulatorScript>().IsActive = false;
            GetComponent<Platformer2DUserControl>().enabled = true;
        }
    }
}