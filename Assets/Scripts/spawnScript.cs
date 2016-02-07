using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public GameObject monsterPrefab;
	public float interval = 3;

	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnNext", interval, interval);
	
	}

	void spawnNext(){
		Instantiate(monsterPrefab, transform.position, Quaternion.identity);

	}

}
