﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

        if (GUI.Button(new Rect(Screen.width / 2 - 40, 300, 60, 30), "Retry?"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); -- for current scene loading
            SceneManager.LoadScene(0);
        }
    }
}