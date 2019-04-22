using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	[SerializeField] GameObject earthTransporter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
	
		other.transform.position = earthTransporter.transform.position;
		Physics.gravity = new Vector3 (0, -9.81f, 0);
	
	}
}
