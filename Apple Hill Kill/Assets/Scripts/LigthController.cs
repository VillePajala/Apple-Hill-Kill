using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthController : MonoBehaviour {
    private GameObject sun = null;
    private GameObject sun2 = null;

    private GameObject light1 = null;
    private GameObject light2 = null;
    private GameObject light3 = null;
    private GameObject light4 = null;
    private GameObject light5 = null;
    private GameObject light6 = null;
    private GameObject light7 = null;
    private GameObject light8 = null;
    private GameObject light9 = null;
    private GameObject light10 = null;
    private GameObject light11 = null;
    private GameObject light12 = null;
    private GameObject light13 = null;

    private GameObject reflections1 = null;
    private GameObject reflections2 = null;


    void Start () {

        this.sun = GameObject.Find("Directional Light");
        this.sun2 = GameObject.Find("Directional Light2");

        this.light1 = GameObject.Find("Point Light1");
        this.light2 = GameObject.Find("Point Light2");
        this.light3 = GameObject.Find("Point Light3");
        this.light4 = GameObject.Find("Point Light4");
        this.light5 = GameObject.Find("Point Light5");
        this.light6 = GameObject.Find("Point Light6");
        this.light7 = GameObject.Find("Point Light7");
        this.light8 = GameObject.Find("Point Light8");
        this.light9 = GameObject.Find("Point Light9");
        this.light10 = GameObject.Find("Point Light10");
        this.light11 = GameObject.Find("Point Light11");
        this.light12 = GameObject.Find("Point Light12");
        this.light13 = GameObject.Find("Point Light13");

        this.reflections1 = GameObject.Find("Reflection Probe");
        this.reflections2 = GameObject.Find("Reflection Probe1");


    } // Start


    void Update () {

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (this.sun.GetComponent<Light>().enabled == false)
            {
                this.sun.GetComponent<Light>().enabled = true;
                this.sun2.GetComponent<Light>().enabled = true;
                this.light1.GetComponent<Light>().enabled = true;
                this.light2.GetComponent<Light>().enabled = true;
                this.light3.GetComponent<Light>().enabled = true;
                this.light4.GetComponent<Light>().enabled = true;
                this.light5.GetComponent<Light>().enabled = true;
                this.light6.GetComponent<Light>().enabled = true;
                this.light7.GetComponent<Light>().enabled = true;
                this.light8.GetComponent<Light>().enabled = true;
                this.light9.GetComponent<Light>().enabled = true;
                this.light10.GetComponent<Light>().enabled = true;
                this.light11.GetComponent<Light>().enabled = true;
                this.light12.GetComponent<Light>().enabled = true;
                this.light13.GetComponent<Light>().enabled = true;
            }
            else
            {
                this.sun.GetComponent<Light>().enabled = false;
                this.sun2.GetComponent<Light>().enabled = false;
                this.light1.GetComponent<Light>().enabled = false;
                this.light2.GetComponent<Light>().enabled = false;
                this.light3.GetComponent<Light>().enabled = false;
                this.light4.GetComponent<Light>().enabled = false;
                this.light5.GetComponent<Light>().enabled = false;
                this.light6.GetComponent<Light>().enabled = false;
                this.light7.GetComponent<Light>().enabled = false;
                this.light8.GetComponent<Light>().enabled = false;
                this.light9.GetComponent<Light>().enabled = false;
                this.light10.GetComponent<Light>().enabled = false;
                this.light11.GetComponent<Light>().enabled = false;
                this.light12.GetComponent<Light>().enabled = false;
                this.light13.GetComponent<Light>().enabled = false;
            }
        }




        if (Input.GetKeyDown(KeyCode.R))
        {
            if (this.reflections1.GetComponent<ReflectionProbe>().enabled == false)
            {
                this.reflections1.GetComponent<ReflectionProbe>().enabled = true;
                this.reflections2.GetComponent<ReflectionProbe>().enabled = true;
            }
            else
            {
                this.reflections1.GetComponent<ReflectionProbe>().enabled = false;
                this.reflections2.GetComponent<ReflectionProbe>().enabled = false;

            }
        }

    } // Update
}
