using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SendToGoogle : MonoBehaviour {


	public GameObject cecha1;
	public GameObject cecha2;
	public GameObject cecha3;

	private string Cecha1;
	private string Cecha2;
	private string Cecha3;

	[SerializeField]
	private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSeIoSGlCyw7ZDDAnliWJinOJu_eshqVnpqymU2v8tRKI7Gusw/formResponse";

	IEnumerator Post(string Cecha1, string Cecha2, string Cecha3){

		WWWForm form = new WWWForm();
		form.AddField ("entry.1733597551", Cecha1);
		form.AddField ("entry.276762257", Cecha2);
		form.AddField ("entry.643751579", Cecha3);
		byte[] rawData = form.data;
		WWW WWW = new WWW (BASE_URL, rawData);
		yield return WWW;
	}


	public void Send() {


		Cecha1= cecha1.GetComponent<InputField>().text;
		Cecha2= cecha2.GetComponent<InputField>().text;
		Cecha3= cecha3.GetComponent<InputField>().text;

		StartCoroutine(Post (Cecha1, Cecha2, Cecha3)); 

	}




}
