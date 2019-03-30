using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets._2D;

using Object = UnityEngine.Object;

public class RobotController : MonoBehaviour
{
    private PlatformerCharacter2D m_Character;

    private BatteryControl targetBattery = null;
    
    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter2D>();
    }


    private void Update()
    {
        if (targetBattery == null)
        {
            targetBattery = FindNearestBattery();
        }
    }


    private void FixedUpdate()
    {
        if (targetBattery == null)
        {
            return;
        }
        
        Vector2 target = new Vector2(targetBattery.transform.position.x, targetBattery.transform.position.y);
        
        float diff = transform.position.x - target.x;
        if (Math.Abs(diff) < 0.1)
        {
            m_Character.Move(0f, false, false);
            return;
        }
        
        if (diff < 0)
        {
            m_Character.Move(1f, false, false);
        }
        else
        {
            m_Character.Move(-1f, false, false);
        }
        
    }
    
    void OnEnable()
    { 
        targetBattery = FindNearestBattery();
    }

    
    private static float Length(Vector3 v)
    {
        return Math.Abs(v.x) + Math.Abs(v.y) + Math.Abs(v.z);
    }

    /**
     * Returns the nearest battery or null if there are no batteries.
     */
    private BatteryControl FindNearestBattery()
    {
        var robotPosition = this.gameObject.transform.position;

        float optimalDist = Single.PositiveInfinity;
        BatteryControl nearestBattery = null;
            
        BatteryControl[] batteries = Object.FindObjectsOfType<BatteryControl>();
        foreach (BatteryControl battery in batteries)
        {
            var batteryPosition = battery.gameObject.transform.position;
            var dist = Length(batteryPosition - robotPosition);
            if (dist < optimalDist)
            {
                optimalDist = dist;
                nearestBattery = battery;
            }
        }

        return nearestBattery;

    }
}
