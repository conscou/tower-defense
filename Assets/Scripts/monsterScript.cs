using UnityEngine;
using System.Collections;

public class monsterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject nav_castle = GameObject.Find("castle");

		if (nav_castle)
			GetComponent<NavMeshAgent> ().destination = nav_castle.transform.position;
	}

	void OnTriggerEnter(Collider co){

		if (co.name == "castle") {
			co.GetComponentInChildren<healthScript>().decrease();
			Destroy(gameObject);
		}
	}
	

}
