using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    private GameObject score = null;
    private AudioSource[] sounds = null;

    public float force = 1f;

    Vector3 destination = new Vector3(-235f, 50f, -220f);
    Vector3 destination2 = new Vector3(-135f, 50f, -220f);
    Vector3 location;
    Vector3 location2;

    float step = 1f;
    private float counter = 0;


    void Start () {
        this.score = GameObject.Find("PointsPanel");
        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();
        Screen.lockCursor = false;
    } 

	void Update () {

        if (counter == 1) {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            location = gameObject.GetComponent<Transform>().position;
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location, destination, step);
        } 

        if (counter == 2) {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            location2 = gameObject.GetComponent<Transform>().position;
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location2, destination2, step);
        } 

        if (Input.GetKey(KeyCode.G)) {
            gameObject.GetComponent<Transform>().Rotate(0.5f, 0.5f, 0.5f);
        } 

        if (Input.GetKeyDown(KeyCode.G)) {
            this.sounds[3].Play();
        } 

        if (Input.GetKey(KeyCode.T)) {
            Destroy(gameObject);
        } 
    }


    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "sphere") {
            this.sounds[2].Play();
            this.score.GetComponent<PointsController>().points += 1;
            counter = 1;
        } 

        if (collision.gameObject.tag == "sphere1") {
            this.sounds[2].Play();
            this.score.GetComponent<PointsController>().points2 += 1;
            counter = 2;
        }
    } 

} 


