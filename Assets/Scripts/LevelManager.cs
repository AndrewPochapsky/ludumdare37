using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private MusicPlayer musicPlayer;
    
    void Awake()
    {
        musicPlayer = GameObject.FindObjectOfType<MusicPlayer>();
    }

	public void LoadLevel (string name)
    {
        Debug.Log("Level load requested for " + name);
       
        SceneManager.LoadScene(name);
        musicPlayer.ResetVolume();

    }

    public void QuitRequest ()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
       
    }

    

    
   
}
