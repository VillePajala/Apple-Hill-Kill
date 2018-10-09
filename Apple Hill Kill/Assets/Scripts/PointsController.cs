using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsController : MonoBehaviour {

    public GameObject Big_House = null;
    private GameObject House = null;

    private GameObject scoretext = null;
    private GameObject scoretext2 = null;

    public int points = 0;
    public int points2 = 0;

    void Start () {
        this.scoretext = GameObject.Find("ScoreText");
        this.scoretext2 = GameObject.Find("ScoreText2");
    } // Start
	
	
	void Update () {

        



        if (points < 100 || points > 100)
        {
            this.scoretext.GetComponent<Text>().text = "White Score: " + points;
            
            
        }

        if (points2 < 100 || points2 > 100)
        {
            this.scoretext2.GetComponent<Text>().text = "Black Score: " + points2;

        }

        if (points2 == 100)
        {
            Debug.Log("TALO2");
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.House = Instantiate(this.Big_House, new Vector3(-250f, -1.3f, -220f), form);
            points2 += 1;
        }


        if (points == 100)
        {
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.House = Instantiate(this.Big_House, new Vector3(-350f, -1.3f, -220f), form);
            points += 1;
            
        }

        if (points == 200)
        {
           
            SceneManager.LoadScene(2);
            
        }

        if (points2 == 200)
        {

            SceneManager.LoadScene(2);

        }





    } // Update

   


} // Class
