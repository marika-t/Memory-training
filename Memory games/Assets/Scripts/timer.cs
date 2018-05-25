using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class timer : MonoBehaviour {

	public Text timerText;
	//private bool finnished = false;

	[SerializeField]
	private float delayBeforeLoading = 10f;
	[SerializeField]
	private string sceneNameToLoad;


	private float timeElapsed;


	private void Update()
	{


		timeElapsed += Time.deltaTime;

		string minutes = ((int)timeElapsed / 60).ToString ();
		string seconds = (timeElapsed % 60).ToString ("f2");

		timerText.text = minutes + ":" + seconds;

		if (timeElapsed > delayBeforeLoading)
		{
			SceneManager.LoadScene (sceneNameToLoad);

		}

	}




}
