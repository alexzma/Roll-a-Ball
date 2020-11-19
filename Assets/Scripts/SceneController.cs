﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public void loadScene(string scene){
        if (scene.Equals("Menu")){
            OverallTracker overallTracker = FindObjectOfType<OverallTracker>();
            overallTracker.Start();
        }
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
