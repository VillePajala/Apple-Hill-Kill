using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour {

	
	void Start () {
		
	} // Start
	
	
	void Update () {
		
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // Closing the Game
            Application.Quit();
        }

	} // Update
} // Class
