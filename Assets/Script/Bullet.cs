using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 0.0001f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
	}

	void OnBecameInvisible () {
		Destroy (this.gameObject);
	}
}
