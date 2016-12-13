using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
        
    static MusicPlayer instance = null;

    public AudioClip startClip, gameClip, endClip;

    private AudioSource music;


    void Awake()
    {
        music = GetComponent<AudioSource>();
        music.volume = 0.328f;
    }

    void Start ()
    {
        
       
        Debug.Log("Music Player Awake " + GetInstanceID());
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            print("Duplicated music player destroyed");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = startClip;
            music.loop = true;
            music.Play();
        }
    }

    void OnLevelWasLoaded(int level)
    {
        if (music == null)
        {
            music = GetComponent<AudioSource>();
        }
        else {
            music.Stop();
        }
        if (level == 0)
        {
            music.clip = startClip;
           
        }

        if (level == 1)
        {
            music.clip = gameClip;
        }

        if (level == 2)
        {
            music.clip = endClip;
        }
        
        music.loop = true;
        music.Play();
    }

    public void FadeOutMusic()
    {
        music.volume -= 0.33f * Time.deltaTime;
    }
    public void ResetVolume()
    {
        music.volume = 0.328f;
    }
    //public void ChangeVolume(float _volume)
    //{
    //    music.volume = _volume;
    //}

}
