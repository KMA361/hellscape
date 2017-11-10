using UnityEngine;
using System;


public class PlayerController : MonoBehaviour 
{

	public float speed = 800.0f;
	public Vector3 jumpForce;

	private Rigidbody _rigidbody;

	void Start() {
		jumpForce = new Vector3 (0.0f, 100.0f, 0.0f);
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		_rigidbody.AddForce (movement * speed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space)) {
			_rigidbody.AddForce (jumpForce);
		}
	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Pickup")
		{
	other.gameObject.SetActive(false);
		}
	}
}