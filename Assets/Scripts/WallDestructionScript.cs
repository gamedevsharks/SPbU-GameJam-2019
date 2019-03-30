using UnityEngine;
public class WallDestructionScript : MonoBehaviour
{
    
    void Start()
    {
            
    }

    void Update()
    {
//        Debug.Log("fsoo");
    }
    
    
    
    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("foo");

        
        
//        if ((int)GameObject.Find("CharacterRobotBoy").GetComponent<TransformationScript>().currentState == 1)
//        {
//            Debug.Log("hello");
//            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
//            Debug.Log("hello1");
//            Destroy(this.gameObject);
//        }
//        else
//        {
//            this.gameObject.GetComponent<Collider>().isTrigger = false;
//        }
    }
}
