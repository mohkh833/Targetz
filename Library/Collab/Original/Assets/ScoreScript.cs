using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static bool flag = false;
    Text score;
    GameObject[] targets;
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("target");
        score.text = "Score: " + scoreValue;

        winGame();
        
        

    }
    public void winGame()

    {
        

        if (targets.Length == 0)
        {
            Cursor.visible = true;
            Screen.lockCursor = false;
            SceneManager.LoadScene(2);
            scoreValue = 0;
        }

        

 
    }
    


}
