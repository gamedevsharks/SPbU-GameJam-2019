using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class AccumulatorScript : MonoBehaviour
{
    public float maxCharge = 200f;

    public float decreaseSpeedPerSecond = 80f;

    private float charge = 0f;

    public float Charge
    {
        get { return charge; }
    }

    private bool isActive = false;
    
    public bool IsActive
    {
        get => isActive;
        set => isActive = value;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (charge == 0f)
            {
                var transformation = Object.FindObjectOfType<TransformationScript>();
                transformation.ChangeState(TransformationScript.State.Human);
                isActive = false;
            } else {
                charge = Math.Max(0f, charge - decreaseSpeedPerSecond * Time.deltaTime);
            }
        }
    }

    public void AddBattery()
    {
        Debug.Log("foo");
        charge = Math.Min(maxCharge, charge + 18);
    }

    public void BreakWallDecrease()
    {
        charge -= 15f;
    }
}
