using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTriggers : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other){

		print ("Collision detected.");

		if (this.tag == "earth") {
			Physics.gravity = new Vector3 (0, -9.81f, 0);
		}

		if (this.tag == "moon") {
			Physics.gravity = new Vector3 (0, -1.62f, 0);
		}

		if (this.tag == "sun") {
			Physics.gravity = new Vector3 (0, -274f, 0);
		}

		if (this.tag == "mars") {
			Physics.gravity = new Vector3 (0, -3.711f, 0);
		}

		if (this.tag == "pluto") {
			Physics.gravity = new Vector3 (0, -0.62f, 0);
		}

	}

}
