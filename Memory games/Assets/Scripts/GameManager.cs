using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public Question[] questions;
	private static List<Question> unaswered;
	private Question current;
	[SerializeField]
	private Text questionText;
	[SerializeField]
	private Text answerText1;
	[SerializeField]
	private Text answerText2;
	[SerializeField]
	private float delayNextQuestion = 2;
	[SerializeField]
	private Text firstAnswerText;
	[SerializeField]
	private Text secondAnswerText;
	[SerializeField]
	private Animator animator;
	void Start() {
		if (unaswered == null || unaswered.Count == 0)
			unaswered = questions.ToList<Question> ();

		SetQuestion ();
//		Debug.Log (current.question + " " + current.isTrue);
	}
	void SetQuestion() {
		int randomIndex = Random.Range (0, unaswered.Count);
		current = unaswered [randomIndex];

		questionText.text = current.question;
		answerText1.text = current.answer1;
		answerText2.text = current.answer2;

		if (current.correctAnswer == 1) {
			firstAnswerText.text = "Poprawnie";
			secondAnswerText.text = "Źle";
		} else {
			firstAnswerText.text = "Żle";
			secondAnswerText.text = "Poprwanie";
		}
	}

	IEnumerator Transition () {
		unaswered.Remove (current);

		yield return new WaitForSeconds (delayNextQuestion);

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
	public void userSelectTrue () {
		animator.SetTrigger("True");
//		if (current.isTrue)
//			Debug.Log ("CORRECT");
//		else
//			Debug.Log ("FALSE");
		StartCoroutine(Transition ());
	}
	public void userSelectFalse () {
		animator.SetTrigger("New Trigger");
//		if (!current.isTrue)
//			Debug.Log ("CORRECT");
//		else
//			Debug.Log ("FALSE");
		StartCoroutine(Transition ());
	}
}
