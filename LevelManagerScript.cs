﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour {

public void LoadLevel(string name){

    Debug.Log("Level load requested for" + name); 

    SceneManager.LoadScene( name);
    }

	public void QuitRequest(){

	Debug.Log("Game exit requested for" + name); 

    Application.Quit();
    }

}
