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
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

        winGame();

    }
    public void winGame()

    {
        

        if (scoreValue == 10)
        {
            SceneManager.LoadScene(3);
            Cursor.visible = true;
            Screen.lockCursor = false;

            flag = true;
        }

 
    }
    


}
