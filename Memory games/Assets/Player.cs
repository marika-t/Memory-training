using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 15f;
	public float mapWidth = 1f;

	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal") * Time.fixedDeltaTime * speed;

		Vector3 newPosition = rb.position + Vector3.right * x;

		newPosition.x = Mathf.Clamp (newPosition.x, -mapWidth, mapWidth);

		rb.MovePosition (newPosition);
	}
	void OnCollisionEnter() 
	{
		FindObjectOfType<DodgeGameManager> ().EndGame ();
	}
}
