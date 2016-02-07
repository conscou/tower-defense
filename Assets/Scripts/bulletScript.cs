using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	public float speed = 10;
	public Transform target;

	void FixedUpdate(){
		if (target) {
			Vector3 dir = target.position - transform.position;
			GetComponent<Rigidbody> ().velocity = dir.normalized * speed;
		} else {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider co){
		healthScript health = co.GetComponentInChildren<healthScript>();

		if (health) {
			health.decrease ();
			Destroy (gameObject);
		}
	}
}
