using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour {

    public float rotate = 0f;

	void Start () {
		
	} // Start
	

	void Update () {

        this.rotate += Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Rotation", this.rotate);
		
	} // Update
}
