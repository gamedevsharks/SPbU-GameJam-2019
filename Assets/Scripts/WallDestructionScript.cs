using UnityEngine;
public class WallDestructionScript : MonoBehaviour
{
    
    void Start()
    {
            
    }

    void Update()
    {
    }
    
    
    
    void OnTriggerEnter2D(Collider2D other)
    {   
        var robot = Object.FindObjectOfType<RobotController>();
        if (robot.GetComponent<TransformationScript>().currentState == TransformationScript.State.Robot)
        {
            Destroy(this.gameObject);
        }
    }
}
