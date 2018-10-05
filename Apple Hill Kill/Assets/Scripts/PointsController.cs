using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour {

    public GameObject Big_House = null;
    private GameObject House = null;

    private GameObject scoretext = null;

    public int points = 0;
	
	void Start () {
        this.scoretext = GameObject.Find("ScoreText");
    } // Start
	
	
	void Update () {

        this.scoretext.GetComponent<Text>().text = "Score: " + points;
        


        if (points == 100)
        {
            Debug.Log("TALO");
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.House = Instantiate(this.Big_House, new Vector3(-450f, -1.3f, -220f), form);
        }

	} // Update
}
