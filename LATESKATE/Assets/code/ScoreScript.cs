using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text Score;
    public Text highscore;
    public float theTime = 1;
    public static bool playing = true;
    static string minutes;
    static string seconds;

        // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(playing == true)
        {
        theTime += Time.deltaTime;
        minutes = Mathf.Floor ((theTime % 3600)/60).ToString("00");//60*60
        
        seconds = ((theTime % 60).ToString("00"));
        Score.text = "    " + minutes + ":" + seconds ;
        }


 
    }
    public void HighScore()
    {
        
    }
    
        
        
    public void timeStop() 
    {
        playing = false;
    }
    
}
