using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	Camera cam;
	float v;
	float h;
	float f;
	float x;
	float a;
	public Rigidbody mainObject;
	public Transform dylo;
	public Camera zoom;

	Rigidbody clone;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		tr = GetComponent <Transform> ();
		cam = GetComponent <Camera> ();
	}

	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		x = Input.GetAxis ("Mouse X");
		f = Input.GetAxis ("Fire1");
		a = Input.GetAxis ("Fire2");
		//Vector3 force = new Vector3 (0,0,v);
		rb.AddForce (tr.forward * v * 50f);

		Vector3 rotation = new Vector3 (0,x,0);
		tr.Rotate (rotation * 5f);
		if (f > 0) {
			clone = Instantiate (mainObject, dylo.position, dylo.rotation);
			clone.AddForce (tr.forward * 5000f);


		}

	}
		

}
