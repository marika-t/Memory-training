using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

	public Sound sound;
	public static AudioManager instance;
	void Awake () {
		if (instance == null)
			instance = this;
		else
		{
			Destroy (gameObject);
			return;
		}
		DontDestroyOnLoad (gameObject);
		sound.source = gameObject.AddComponent<AudioSource> ();
		sound.source.clip = sound.clip;

		sound.source.volume = sound.volume;
		sound.source.loop = sound.loop;
	}

	public void Play (string name)
	{
		Sound s = sound;
		if (s == null)
			return;
		s.source.Play();
	}

	void Start()
	{
		Play ("Theme");
	}


}
