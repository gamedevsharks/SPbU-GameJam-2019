using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumulatorScript : MonoBehaviour
{
    public float maxCharge = 100f;

    public float decreaseSpeedPerSecond = 10f;

    public float charge = 50f;
    
    private Vector2 pos = new Vector2(20,40);
    private Vector2 size = new Vector2(60,20);
    private Texture2D emptyTex;
    private Texture2D fullTex;
    
    void OnGUI() {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
            GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
         
            //draw the filled-in part:
            GUI.BeginGroup(new Rect(0,0, size.x * charge / maxCharge, size.y));
                GUI.Box(new Rect(0,0, size.x, size.y), fullTex);
            GUI.EndGroup();
        GUI.EndGroup();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (charge > 0)
        {
            charge = Math.Max(0f, charge - decreaseSpeedPerSecond * Time.deltaTime);
        }
    }

    public void AddBattery()
    {
        charge = Math.Min(maxCharge, charge + 10);
    }
}
