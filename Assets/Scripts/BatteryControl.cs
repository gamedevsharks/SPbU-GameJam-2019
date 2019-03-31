using UnityEngine;

public class BatteryControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = GameObject.Find("CharacterRobotBoy");
        if (obj == null)
        {
            return;
        }
        
        obj.GetComponent<AccumulatorScript>().AddBattery();
        Destroy (this.gameObject);
    }
}
