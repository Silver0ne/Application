using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {
	
	Transform tr;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		print(this.guiTexture.transform.position.x);
	}
}
