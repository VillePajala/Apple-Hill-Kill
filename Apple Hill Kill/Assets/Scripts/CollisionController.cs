using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    // Game object for printing points to UI
    private GameObject score = null;
    // Game object for audio
    private AudioSource[] sounds = null;

    // The amount of force on impact (not used)
    public float force = 1f;

    // Defining a few points in 3D space
    Vector3 destination = new Vector3(-235f, 50f, -220f);
    Vector3 destination2 = new Vector3(-135f, 50f, -220f);
    Vector3 location;
    Vector3 location2;

    // The size of animation step
    float step = 1f;

    // A trigger variable
    private float counter = 0;



    void Start () {

        // Finding game objects
        this.score = GameObject.Find("PointsPanel");
        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();
        // Making sure the mouse cursor doesn't get hidden on scene change
        Screen.lockCursor = false;
        
    } // Start

	
	
	void Update () {

        // Defining what happens when trigger variable is 1
        if (counter == 1)
        {
            // On impact, the game object's collider is turned off
            gameObject.GetComponent<MeshCollider>().enabled = false;
            // Game object's location is saved
            location = gameObject.GetComponent<Transform>().position;
            // Animating the game object to go from point a to point b
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location, destination, step);
            
        } // if

        // Defining what happens when trigger variable is 2
        if (counter == 2)
        {
            // On impact, the game object's collider is turned off
            gameObject.GetComponent<MeshCollider>().enabled = false;
            // Game object's location is saved
            location2 = gameObject.GetComponent<Transform>().position;
            // Animating the game object to go from point a to point b
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location2, destination2, step);

        } // if

        // If the key G is pressed and hold
        if (Input.GetKey(KeyCode.G))
        {
            // Game object rotates
            gameObject.GetComponent<Transform>().Rotate(0.5f, 0.5f, 0.5f);

        } // if

        // If the key G is pressed
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Sound is played
            this.sounds[3].Play();

        } // if

        // If the key T is pressed
        if (Input.GetKey(KeyCode.T))
        {
            // The game object is destroyed
            Destroy(gameObject);

        } // if

    } // Update


    // Defining what happens when ammunition hits the game object
    private void OnCollisionEnter(Collision collision)
    {
        // If the bullet from clicking the left mouse button collides with the game object
        if (collision.gameObject.tag == "sphere")
        {
            // Sound is played
            this.sounds[2].Play();
            // Point counter on another script gets updated
            this.score.GetComponent<PointsController>().points += 1;
            // Trigger varable is set to 1
            counter = 1;

            // This was the original plan. I tried to make game objects to turn to physical objects and
            // fly around uncontrollably. I abandoned the idea because of too many complex bugs:
                    // gameObject.GetComponent<MeshCollider>().convex = true;
                    // gameObject.AddComponent<Rigidbody>();
                    // gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
                    // Destroy(gameObject, 10f);
        } // if

        // If the bullet from clicking the right mouse button collides with the game object
        if (collision.gameObject.tag == "sphere1")
        {
            // Sound is played
            this.sounds[2].Play();
            // Point counter on another script gets updated
            this.score.GetComponent<PointsController>().points2 += 1;
            // Trigger varable is set to 2
            counter = 2;

            // This was the original plan. I tried to make game objects to turn to physical objects and
            // fly around uncontrollably. I abandoned the idea because of too many complex bugs:
                    // gameObject.GetComponent<MeshCollider>().convex = true;
                    // gameObject.AddComponent<Rigidbody>();
                    // gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
                    // Destroy(gameObject, 10f);
        }

    } // OnCollisionEnter

} // Class
