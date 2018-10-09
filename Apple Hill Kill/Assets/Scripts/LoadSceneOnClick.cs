using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneOnClick : MonoBehaviour {

    // When button is pressed
	public void LoadByIndex(int sceneIndex)
    {
        // The defined scene is loaded
        SceneManager.LoadScene(sceneIndex);

    } // LoadByIndex

} // Class
