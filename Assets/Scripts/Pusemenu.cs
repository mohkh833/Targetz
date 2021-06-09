using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pusemenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject PuseMenu;
    //[SerializeField] GameObject PuseMenu;

    void Start()
    {
        PuseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();

            }
            else
            {
                Pause(); 
            }
        }
    }
    public void Resume()
    {
        PuseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        Cursor.visible = false;
        Screen.lockCursor = true;

    }
    void Pause()
    {
        PuseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
    public void QuitGame()
    {
       
        //Debug.Log("QUIT!");
        Application.Quit();
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
       
    }


}
