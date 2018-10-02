using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

	
	void Start () {
		
	} // Start

	
	
	void Update () {
		
	} // Update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            Destroy(gameObject);
        }
    }

}
