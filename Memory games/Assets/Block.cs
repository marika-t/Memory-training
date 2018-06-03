using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	
	void Start()
	{
		Rigidbody m_rb = GetComponent<Rigidbody>();
		m_rb.AddForce (Physics.gravity * -20f);
	}

	void Update () {
		if (transform.position.y < -2f) {
			Destroy (gameObject);
		}
	}
}
