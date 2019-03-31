using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class AccumulatorScript : MonoBehaviour
{
    public float maxCharge = 100f;

    public float decreaseSpeedPerSecond = 10f;

    private float charge = 50f;

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
        charge = Math.Min(maxCharge, charge + 10);
    }

    public void BreakWallDecrease()
    {
        charge -= 50f;
    }
}
