﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void playButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void exitButton()
    {

        Debug.Log("Game should Exit but we are inside Unity");
        Application.Quit();
    }

}
