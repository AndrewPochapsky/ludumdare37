using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeOut : MonoBehaviour {

    private MusicPlayer musicPlayer;
    public float fadeOutTime = 1.5f;
    //private Image fadePanel;
    private Color currentColor = Color.black;
    private float timeSinceFadeStart = 0;
    private Image fadePanel;
    void Awake()
    {
        Time.timeScale = 1;
        timeSinceFadeStart = 0;
        currentColor.a = 0;

    }

    void Start()
    {
        musicPlayer = GameObject.FindObjectOfType<MusicPlayer>();
        fadePanel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceFadeStart < fadeOutTime)
        {
            musicPlayer.FadeOutMusic();
            //fade out
            timeSinceFadeStart += Time.deltaTime;
            float alphaChange = Time.deltaTime / fadeOutTime;
            currentColor.a += alphaChange;
            fadePanel.color = currentColor;
            Debug.Log("Fading");
        }
        else
        {

            SceneManager.LoadScene("End");
        }
        //gameObject.SetActive(isActive);
    }
}
