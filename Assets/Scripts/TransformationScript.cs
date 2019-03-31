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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ChangeState();
        }
    }

    public void ChangeState()
    {
        m_Character.Move(0f, false, false);
        if (currentState == State.Human)
        {
            currentState = State.Robot;
            GetComponent<AccumulatorScript>().IsActive = true;

            GetComponent<ControllersManager>().SetController<RobotController>();
        }
        else
        {
            currentState = State.Human;
            GetComponent<AccumulatorScript>().IsActive = false;
            
            GetComponent<ControllersManager>().SetController<Platformer2DUserControl>();
        }
    }
}