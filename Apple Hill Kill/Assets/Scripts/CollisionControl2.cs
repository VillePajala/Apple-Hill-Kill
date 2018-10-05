using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl2 : MonoBehaviour
{
    public float force = 1f;

    void Start()
    {

    } // Start



    void Update()
    {

    } // Update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {

            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
            Destroy(gameObject, 10f);
        }



    }

}
