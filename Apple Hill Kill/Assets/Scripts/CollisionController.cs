using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    private GameObject score = null;
    

    public float force = 1f;

    Vector3 destination = new Vector3(-235f, 50f, -220f);
    Vector3 destination2 = new Vector3(-135f, 50f, -220f);
    Vector3 location;
    Vector3 location2;

    

    float step = 1f;

    private float counter = 0;

    void Start () {

        this.score = GameObject.Find("PointsPanel");
        


    } // Start

	
	
	void Update () {

        if (counter == 1)
        {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            location = gameObject.GetComponent<Transform>().position;
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location, destination, step);
            // gameObject.GetComponent<Transform>().Rotate(0.5f, 0.5f, 0.5f);
        }

        

        if (counter == 2)
        {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            location2 = gameObject.GetComponent<Transform>().position;
            gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(location2, destination2, step);
        }

        if (Input.GetKey(KeyCode.G))
        {
            gameObject.GetComponent<Transform>().Rotate(0.5f, 0.5f, 0.5f);

        }
        if (Input.GetKey(KeyCode.T))
        {
            Destroy(gameObject);

        }
        





    } // Update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            this.score.GetComponent<PointsController>().points += 1;
            counter = 1;
            // gameObject.GetComponent<MeshCollider>().convex = true;
            // gameObject.AddComponent<Rigidbody>();
            // gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
           
            

            // Destroy(gameObject, 10f);
        }

        if (collision.gameObject.tag == "sphere1")
        {
            this.score.GetComponent<PointsController>().points += 1;
            counter = 2;
            // gameObject.GetComponent<MeshCollider>().convex = true;
            // gameObject.AddComponent<Rigidbody>();
            // gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);



            // Destroy(gameObject, 10f);
        }




    }

}
