using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        private TransformationScript transformationScript;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
            transformationScript = GetComponent<TransformationScript>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            if (transformationScript.currentState == TransformationScript.State.Robot)
            {
                return;
            }
            
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, false, m_Jump);
            m_Jump = false;
        }
    }
}
