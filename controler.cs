﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controler : MonoBehaviour {
	NavMeshAgent nav;
	Animator anim;

	public Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (target.position);


	}
	void OnCollisionEnter(Collision arg){
		
		if (arg.gameObject.tag == "bullet") {
			anim.SetFloat ("dead", 0.5f);
			nav.enabled = false;
		}
		if (arg.gameObject.tag == "maincamera") {
		//	Destroy (arg.gameObject);
		}

		if (arg.gameObject.tag == "stena") {
			Destroy (arg.gameObject);
		}
	

	}
}
