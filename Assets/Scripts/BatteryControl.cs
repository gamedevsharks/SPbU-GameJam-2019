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
        AccumulatorScript[] accumulators = Object.FindObjectsOfType<AccumulatorScript>();

        if (accumulators.Length > 0)
        {
            accumulators[0].AddBattery();
        }
        
        Destroy (this.gameObject);
    }
}
