using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour {

	void Start () {
		
	} 
	
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            Application.Quit();
        }
	} 

} 
