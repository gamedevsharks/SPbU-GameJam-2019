using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatteriesNumberChecker : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        BatteryControl[] batteries = Object.FindObjectsOfType<BatteryControl>();

        if (batteries.Length == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
