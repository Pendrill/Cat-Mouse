﻿using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	public Transform cat;
	public Transform mouse;
	public Rigidbody mouseRigidbody;
	void Start(){
		mouseRigidbody = mouse.GetComponent<Rigidbody> ();
	}
	void FixedUpdate () {
		Vector3 directionToCat = cat.position - transform.position;
		Debug.Log (directionToCat);
		if (Vector3.Angle (directionToCat, transform.forward) < 30) {
			Ray mouseRay = new Ray (transform.position, directionToCat);
			RaycastHit mouseRayHitInfo;
			if(Physics.Raycast( mouseRay, out mouseRayHitInfo, 100f)){
				if(mouseRayHitInfo.collider.tag == "Cat"){
					mouseRigidbody.AddForce (-directionToCat.normalized * 1200f);
					//mouse.Rotate (0f, 90f, 0f);;
				}
			}
		}
	}
}