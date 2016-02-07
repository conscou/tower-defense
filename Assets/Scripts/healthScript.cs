using UnityEngine;
using System.Collections;

public class healthScript : MonoBehaviour {

	TextMesh text_mesh;
	// Use this for initialization
	void Start () {
		//get textmesh from the castle
		text_mesh = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.forward = Camera.main.transform.forward;
	}

	public int current(){
		return text_mesh.text.Length;
	}

	public void decrease(){
		if (current () > 1)
			text_mesh.text = text_mesh.text.Remove (text_mesh.text.Length - 1);
		else
			Destroy (transform.parent.gameObject);

	}
}
