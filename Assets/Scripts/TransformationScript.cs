using UnityEngine;

public class TransformationScript : MonoBehaviour
{
    public enum State
    {
        Human, Robot
    }

    public State currentState = State.Human;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ChangeState();
        }
    }

    private void ChangeState()
    {
        if (currentState == State.Human)
        {
            currentState = State.Robot;
            GetComponent<AccumulatorScript>().IsActive = true;
        }
        else
        {
            currentState = State.Human;
            GetComponent<AccumulatorScript>().IsActive = false;
        }
    }
}