using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsController : MonoBehaviour {

    // Game object Big_House can be defined from inpector window
    public GameObject Big_House = null;
    // Game object for new house
    private GameObject House = null;

    // Game obects for points
    private GameObject scoretext = null;
    private GameObject scoretext2 = null;

    // Variables for points
    public int points = 0;
    public int points2 = 0;


    void Start () {

        // Finding game objects
        this.scoretext = GameObject.Find("ScoreText");
        this.scoretext2 = GameObject.Find("ScoreText2");

    } // Start
	
	

	void Update () {

        // If points..
        if (points < 100 || points > 100)
        {
            // Current points are printed on UI
            this.scoretext.GetComponent<Text>().text = "White Score: " + points;
           
        } // if

        // If points..
        if (points2 < 100 || points2 > 100)
        {
            // Current points are printed on UI
            this.scoretext2.GetComponent<Text>().text = "Black Score: " + points2;

        } // if

        // If points..
        if (points2 == 100)
        {
            // New instanse of House is created
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.House = Instantiate(this.Big_House, new Vector3(-250f, -1.3f, -220f), form);
            // Adding 1 point to variable so that only one house is created
            points2 += 1;

        } // if

        // If points..
        if (points == 100)
        {
            // New instanse of House is created
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.House = Instantiate(this.Big_House, new Vector3(-350f, -1.3f, -220f), form);
            // Adding 1 point to variable so that only one house is created
            points += 1;

        } // if

        // If points..
        if (points == 200)
        {
           // Level Cleared -scene is loaded
            SceneManager.LoadScene(2);

        } // if

        // If points..
        if (points2 == 200)
        {
            // Level Cleared -scene is loaded
            SceneManager.LoadScene(2);

        } // if

    } // Update

} // Class
