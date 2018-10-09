using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    // Defining prefabs to shoot via dragging to inspector window
    public GameObject ballbullet = null;
    public GameObject ballbullet2 = null;

    // Theactual game object to shoot
    private GameObject bullet = null;

    // Bring in sounds
    private AudioSource[] sounds = null;

    // Defining how fast the ammunition launches and how it rotates
    private float force = 100000f;
    private float rotation = 1000f;

    // Defining multiples for rotation
    private Vector3 rotationmultiples = new Vector3(0.2f, 0.4f, 0.8f);


	void Start () {

        // Gets the audiosource
        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();

    } // start
	
	
	void Update () {

        // If player presses left mouse button
        if (Input.GetButtonUp("Fire1"))
        {
           // Sound is played
           this.sounds[1].Play();
           // Nwe object from prefab is created
           Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
           this.bullet = Instantiate(this.ballbullet, this.GetComponent<Transform>().position, form);
           // Directional force is applied to ammo
           this.bullet.GetComponent<Rigidbody>().AddForce(this.GetComponent<Transform>().forward * this.force);
           // Rotation is applied to ammo
           this.bullet.GetComponent<Rigidbody>().AddTorque(this.rotationmultiples * this.rotation);
           // Bullet is destroyed after 10 seconds
           Destroy(this.bullet, 10f);
        
        } // if

        // If player presses right mouse button
        if (Input.GetButtonUp("Fire2"))
        {
            // Sound is played
            this.sounds[1].Play();
            // Nwe object from prefab is created
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            this.bullet = Instantiate(this.ballbullet2, this.GetComponent<Transform>().position, form);
            // Directional force is applied to ammo
            this.bullet.GetComponent<Rigidbody>().AddForce(this.GetComponent<Transform>().forward * this.force);
            // Rotation is applied to ammo
            this.bullet.GetComponent<Rigidbody>().AddTorque(this.rotationmultiples * this.rotation);
            // Bullet is destroyed after 10 seconds
            Destroy(this.bullet, 10f);
        } // if


    } //update

} // Class
