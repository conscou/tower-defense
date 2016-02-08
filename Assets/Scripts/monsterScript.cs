using UnityEngine;
using System.Collections;

public class monsterScript : MonoBehaviour {

	public GameObject deathParticle;

	// Use this for initialization
	void Start () {

		GameObject nav_castle = GameObject.Find("castle");

		if (nav_castle)
			GetComponent<NavMeshAgent> ().destination = nav_castle.transform.position;
	}

	void OnTriggerEnter(Collider co){

		if (co.name == "castle") {
			co.GetComponentInChildren<healthScript> ().decrease ();
			Instantiate (deathParticle, this.transform.position, Quaternion.identity);
			Destroy (gameObject);
		} else if (co.name == "Hero") {
			Instantiate (deathParticle, this.transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

}
