using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepUpright : MonoBehaviour {

	public float frontBackRightingForce = 100.0f;
	public float leanRightingForce = 100.0f;

	private Rigidbody rb;
	private Vector3 leanCorrection;
	private Vector3 tiltCorrection;
	private Vector3 totalCorrection;
	// Use this for initialization
	void Start () 
	{
		rb = gameObject.GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		leanCorrection = leanRightingForce*Vector3.Cross(transform.up, Vector3.up);
		leanCorrection.x = 0.0f;
		leanCorrection.y = 0.0f;

		tiltCorrection = frontBackRightingForce*Vector3.Cross(transform.up, Vector3.up);
		tiltCorrection.z = 0.0f;
		tiltCorrection.y = 0.0f;

		rb.AddTorque(leanCorrection, ForceMode.Force);
		rb.AddTorque(tiltCorrection, ForceMode.Force);
	}
}
