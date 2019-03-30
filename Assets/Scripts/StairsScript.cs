using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsScript : MonoBehaviour
{
    public float speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float prevGravity = -1000000;

    void OnTriggerEnter2D(Collider2D other)
    {
        //prevGravity = other.GetComponent<Rigidbody2D>().gravityScale;
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        //other.GetComponent<Rigidbody2D>().gravityScale = prevGravity;  
    }

    void OnTriggerStay2D(Collider2D other)
    {              
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }
            else
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
    }
}
