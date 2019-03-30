using UnityEngine;

namespace DefaultNamespace
{
    public class TransformationScript : MonoBehaviour
    {
        public enum state
        {
            HUMAN, ROBOT
        }

        public state currentState = state.HUMAN;

        void Update()
        {
            if (Input.GetKeyDown("z"))
            {
                ChangeState();
            }
        }

        private state ChangeState()
        {
            return currentState == state.HUMAN ? state.ROBOT : state.HUMAN;
        }
    }
}