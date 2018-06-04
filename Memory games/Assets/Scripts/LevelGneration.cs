using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LevelGneration : MonoBehaviour {

	// Use this for initialization

	   
		public GameObject[] objects;

	    

		
	void Start () {


			int rand = Random.Range (0, objects.Length);
			Instantiate (objects [rand], transform.position, Quaternion.identity);
		  
		  

		}





	

}