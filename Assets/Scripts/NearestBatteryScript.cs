using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DefaultNamespace
{
    public class NearestBatteryScript : MonoBehaviour
    {
        void Update()
        {
        }
        private static float Length(Vector3 v)
        {
            return Math.Abs(v.x) + Math.Abs(v.y) + Math.Abs(v.z);
        }

        /**
         * Returns the nearest battery or null if there are no batteries.
         */
        public BatteryControl FindBattery()
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

            if (nearestBattery != null)
            {
                Object.Destroy(nearestBattery.gameObject);   
            }

            return nearestBattery;

        }

        
    }
}