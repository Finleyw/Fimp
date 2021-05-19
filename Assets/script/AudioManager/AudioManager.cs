using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;
	int musicman=0;
	void Awake()
	{
		
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
	}
	void Start()
	{
		/*Scene currentScene = SceneManager.GetActiveScene ();
 
        
        string sceneName = currentScene.name;
		if (sceneName=="Menu")
		{
			
		}
		else
		{
			Play("music2");
		}*/
	}
	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Play();
	}
	
	void Update()
	{
		Scene currentScene = SceneManager.GetActiveScene ();
 
        
        string sceneName = currentScene.name;
		if (sceneName=="Menu")
		{
			
		}
		else if (musicman==0)
		{
			Play("music2");
			musicman=musicman+1;
		}
	}
}
