using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicKeyboardSteering : MonoBehaviour {

	public float turnSpeed = 10.0f;
	public float turnMax = 65.0f;

	public GameObject backWheel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		transform.Rotate( 0.0f, turnSpeed*Input.GetAxis("Horizontal"), 0.0f );
		



		Debug.Log(Input.GetAxis("Horizontal"));

		
	}
}
