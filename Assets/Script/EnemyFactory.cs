using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class EnemyFactory : MonoBehaviour {

	// ==============================
	// ■ Private, Protected
	// ==============================

	private float x = 0.0f;

	// ==============================
	// ■ Public
	// ==============================

	public GameObject enemy;
	public List<float> positions;

	// ==============================
	// ■ Override
	// ==============================

	void Start () {
		x = 0.0f;
	}
	
	void Update () {
		x += 0.1f;

		create ();
	}

	// ==============================
	// ■ Mine
	// ==============================

	void create () {
		if (positions.Count <= 0) {
			return;
		}
		positions.RemoveAll (delegate (float position) {
			if (position < x) {
				Instantiate (enemy, transform.position, transform.rotation);
				return true;
			}
			return false;
		});
	}

}
