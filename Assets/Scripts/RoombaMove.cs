using UnityEngine;
using System.Collections;

public class RoombaMove : MonoBehaviour {

	public Transform player;
	public Rigidbody playerRigidBody;
	public int[] rotate = { 90, -90 };
	public int speed;
	// Use this for initialization
	void Start () {
		playerRigidBody = player.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		playerRigidBody.velocity = player.forward * speed + Physics.gravity;
		Ray moveRay = new Ray (player.position, transform.forward);
		if (Physics.SphereCast (moveRay, 0.1f, 0.5f)) {
			player.Rotate (0f, rotate [Random.Range (0, 2)], 0f);;
		}
		Debug.DrawRay (moveRay.origin, moveRay.direction * 0.5f);
	}
}
