﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuSceneLoader : MonoBehaviour {
	public void changeMenuScene(string scenename)
	{
		SceneManager.LoadScene (scenename);
	}
}
