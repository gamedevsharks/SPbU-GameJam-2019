using UnityEngine;
public class WallDestructionScript : MonoBehaviour
{

    public TransformationScript.State reactOn;
    
    void Start()
    {
            
    }

    void Update()
    {
    }
    
    
    
    void OnTriggerStay2D(Collider2D other)
    {   
        var robot = Object.FindObjectOfType<RobotController>();
        if (robot.GetComponent<TransformationScript>().currentState == reactOn)
        {
            Destroy(this.gameObject);
            robot.GetComponent<AccumulatorScript>().BreakWallDecrease();
        }
    }
}
