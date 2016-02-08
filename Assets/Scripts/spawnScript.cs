using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public GameObject monsterPrefab;
	public float interval = 5;
	public int numMonsters = 15;
	int currentNum = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnNext", interval, interval);
	
	}

	void spawnNext(){
		Instantiate(monsterPrefab, transform.position, Quaternion.identity);
		currentNum++;
		if (currentNum == numMonsters) {
			CancelInvoke("spawnNext");

		}
	}

	void Update() {
		if (currentNum == numMonsters && GameObject.FindGameObjectsWithTag("Monster").Length == 0) {
			int i = Application.loadedLevel;
			Application.LoadLevel("next_scene");
		}
	}
	
}
