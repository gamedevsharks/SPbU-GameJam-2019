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
    
    
    
    void OnTriggerEnter2D(Collider2D other)
    {   
        var robot = Object.FindObjectOfType<RobotController>();
        if (robot == null)
        {
            return;
        }
        
        if (robot.GetComponent<TransformationScript>().currentState == reactOn)
        {
            Destroy(this.gameObject);
        }
    }
}
