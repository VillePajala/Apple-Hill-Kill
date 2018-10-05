using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHouse : MonoBehaviour {

    // public GameObject Big_House = null;
    // private GameObject House = null;

    Vector3 location = new Vector3(0f, -1.3f, 0f);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.R))
        {
           // Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
           // this.House = Instantiate(this.Big_House, new Vector3(-450f, -1.3f, -220f), form);

        }

    }
}
