using System;
using UnityEngine;
using UnityStandardAssets._2D;

public class TransformationScript : MonoBehaviour
{
    public enum State
    {
        Human, RobotRun, RobotFly
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
            if (currentState == State.Human)
            {
                ChangeState(State.RobotRun);
            }            
        }
    }

    public void ChangeState(State newState)
    {
        m_Character.Move(0f, false, false);

        currentState = newState;
        switch (newState)
        {
            case State.Human:
                GetComponent<AccumulatorScript>().IsActive = false;
            
                GetComponent<ControllersManager>().SetController<Platformer2DUserControl>();
                break;
            
            case State.RobotRun:
                GetComponent<AccumulatorScript>().IsActive = true;

                GetComponent<ControllersManager>().SetController<RobotController>();
                break;
            
            case State.RobotFly:
                GetComponent<ControllersManager>().SetController<FlyController>();
                break;
        }
    }
}