using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour {
    public static float time;
    public Text timeText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = Time.timeSinceLevelLoad;
        timeText.text = "Time: " + System.Math.Round(time,2);
	}
}
