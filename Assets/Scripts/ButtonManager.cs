using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    private void OnEnable()
    {
        if (gameObject.name.ToLower().Contains("hint"))
        {
            gameObject.SetActive(false);
        }
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
   
	}

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    int contc;
    public void Play()
    {
       SceneManager.LoadScene("LevelMenu");
    }
    public void Hint()
    {
        
    }
    public void NextLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Close()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
