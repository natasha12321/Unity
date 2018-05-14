using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	Transform tr;

	public Transform zombie;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawner", 4f, 10f);
		tr = GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void spawner(){
		 Instantiate (zombie,tr.position,tr.rotation);

	}
}
