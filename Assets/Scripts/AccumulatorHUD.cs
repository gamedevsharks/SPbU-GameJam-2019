using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccumulatorHUD : MonoBehaviour
{
    public GameObject objectWithAccumulator;
    
    private Vector2 pos = new Vector2(20,40);
    private Vector2 size = new Vector2(60,20);
    private Texture2D emptyTex;
    private Texture2D fullTex;
    
    void OnGUI() {
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);

        AccumulatorScript accumulator = objectWithAccumulator.GetComponent<AccumulatorScript>();
        
        GUI.BeginGroup(new Rect(0,0, size.x * accumulator.Charge / accumulator.maxCharge, size.y));
        GUI.Box(new Rect(0,0, size.x, size.y), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();
    }
}
