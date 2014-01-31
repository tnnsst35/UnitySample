using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// ==============================
	// ■ Private, Protected
	// ==============================

	// ==============================
	// ■ Public
	// ==============================

	// ==============================
	// ■ Override
	// ==============================

	void Start () {
		
	}
	
	void Update () {
		transform.Translate (-0.01f, 0, 0);
	}
	
	void OnBecameInvisible() {
		Destroy (this.gameObject);
	}

	// ==============================
	// ■ Mine
	// ==============================

}
