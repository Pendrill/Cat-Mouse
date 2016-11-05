using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	
	public Transform mouse;
	public Transform cat;
	public Rigidbody catRigidBody;
	float visionConeCat = 60f;
	float distanceSeen = 0.6f;
	// Use this for initialization
	void Start () {
		catRigidBody = cat.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (mouse == null) {
			return;
		}
		Vector3 directionToMouse = mouse.position - transform.position;
		if (Vector3.Angle (directionToMouse, transform.forward) < visionConeCat) {
			Ray catRay = new Ray (transform.position, directionToMouse);
			RaycastHit catRayHitInfo;
			if (Physics.Raycast (catRay, out catRayHitInfo, 10f)) {
				if (catRayHitInfo.collider.tag != "Wall") {
					if (catRayHitInfo.distance < distanceSeen) {
						if (catRayHitInfo.collider.tag == "Mouse") {
							Destroy (mouse.gameObject);
						}
					} else {
						Debug.Log ("Adding Force to Cat");
						catRigidBody.AddForce (directionToMouse.normalized * 1200f);
					}
				}
			}
		}
	}
}
