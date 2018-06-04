using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour {

	public GameObject karta1;
	public GameObject karta2;
	public GameObject karta3;
	public GameObject karta4;
	public GameObject karta5;
	public GameObject karta6;




	private string Karta1;
	private string Karta2;
	private string Karta3;
	private string Karta4;
	private string Karta5;
	private string Karta6;



	[SerializeField]
	private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLScA2QJiNIFyi_Q_DOs2rp7Q-SM7FSHccMXIAkrw0kjr4rkg2Q/formResponse";

	IEnumerator Post(string karta1, string karta2, string karta3, string karta4, string karta5,  string karta6){

		WWWForm form = new WWWForm();
		form.AddField ("entry.15867321", karta1);
		form.AddField ("entry.274834867", karta2);
		form.AddField ("entry.1216017270", karta3);
		form.AddField ("entry.1178462386", karta4);
		form.AddField ("entry.1821317107", karta5);
		form.AddField ("entry.1328345514", karta6);

		byte[] rawData = form.data;
		WWW WWW = new WWW (BASE_URL, rawData);
		yield return WWW;
	}


	public void Send() {


		Karta1= karta1.GetComponent<InputField>().text;
		Karta2= karta2.GetComponent<InputField>().text;
		Karta3= karta3.GetComponent<InputField>().text;
		Karta4= karta4.GetComponent<InputField>().text;
		Karta5= karta5.GetComponent<InputField>().text;
		Karta6= karta6.GetComponent<InputField>().text;

		StartCoroutine(Post (Karta1, Karta2, Karta3, Karta4, Karta5,Karta6)); 

	}




}


