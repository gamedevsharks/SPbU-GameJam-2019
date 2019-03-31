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
        var transformationScript = Object.FindObjectOfType<TransformationScript>();
        if (transformationScript == null)
        {
            return;
        }
        
        if (transformationScript.currentState == reactOn)
        {
            Destroy(this.gameObject);
            transformationScript.GetComponent<AccumulatorScript>().BreakWallDecrease();
        }
    }
}
