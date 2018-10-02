using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public GameObject ballbullet = null;

    private GameObject bullet = null;

    private float force = 100000f;
    private float rotation = 1000f;

    private Vector3 rotationmultiples = new Vector3(0.2f, 0.4f, 0.8f);
	void Start () {
		
	} // start
	
	
	void Update () {

        if (Input.GetButtonUp("Fire1"))
        {
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.bullet = Instantiate(this.ballbullet, this.GetComponent<Transform>().position, form);
            this.bullet.GetComponent<Rigidbody>().AddForce(this.GetComponent<Transform>().forward * this.force);
            this.bullet.GetComponent<Rigidbody>().AddTorque(this.rotationmultiples * this.rotation);
            Destroy(this.bullet, 10f);
        }

           
        


    } //update
}
