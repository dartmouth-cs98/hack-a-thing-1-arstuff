using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    public static string currentSelectedCar = "myLamboConvert";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void quit() {
        Application.Quit();
	}

    public void changeLevel(string scene){
        SceneManager.LoadScene(scene);
    }
}
