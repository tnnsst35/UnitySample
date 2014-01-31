using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// ==============================
	// ■ Private, Protected
	// ==============================

	private const int SHOOT_FRAME = 20;

	private int shoot_frame;
	private bool is_landing;

	// ==============================
	// ■ Public
	// ==============================

	public GameObject bullet;	
	public float walk_speed;
	public float jump_power;

	// ==============================
	// ■ Override
	// ==============================

	void Start () {
		shoot_frame = 0;
		is_landing = false;
	}
	
	void Update () {
		if (0 < shoot_frame) {
			shoot_frame--;
		}
		move ();
		jump ();
		shoot ();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		is_landing = true;
	}

	// ==============================
	// ■ Mine
	// ==============================
	
	void move () {
		if (Input.GetKey ("right")) {
			transform.Translate (walk_speed, 0, 0);
		}
		if (Input.GetKey ("left")) {
			transform.Translate (walk_speed * -1, 0, 0);
		}
	}

	void jump () {
		if (!is_landing || !Input.GetKey ("space")) {
			return;
		}
		rigidbody2D.AddForce (Vector2.up * jump_power * 100);
		is_landing = false;
	}
	
	void shoot () {
		if (0 < shoot_frame || !Input.GetKey ("z")) {
			return;
		}
		Vector3 position = new Vector3 (transform.position.x + 1, transform.position.y, transform.position.z);
		Instantiate(bullet, position,  transform.rotation);
		shoot_frame = SHOOT_FRAME;
	}

}
