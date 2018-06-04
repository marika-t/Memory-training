using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

using System.Collections;

public class ChangeVolume : MonoBehaviour {
	public static AudioManager instance;
	public Slider volumeSlider;
	public Sound sound;

	public void VolumeController(){
		sound.source = AudioManager.instance.GetComponent<AudioSource>();
		sound.source.volume = volumeSlider.value;
	}
}