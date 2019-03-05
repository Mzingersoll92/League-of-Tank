using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float maxSpeed;
	public GameObject bullet;
	public float fireRate = 0.5f;

	Rigidbody2D rb;
	float nextFire = 0.0f;
	Vector2 bulletPos;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			fire ();
			
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");

		rb.velocity = new Vector2 (move * maxSpeed, rb.velocity.y);
	}

	void fire() {
		bulletPos = transform.position;
		bulletPos += new Vector2(+1f, -0.43f);
		Instantiate (bullet, bulletPos, Quaternion.identity);

	}
			
} 
