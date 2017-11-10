using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			SceneManager.LoadScene("gameoverscene");
		}
	
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("MainScene");
		}	
	}
}
