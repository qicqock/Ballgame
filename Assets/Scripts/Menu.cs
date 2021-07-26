using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject restartMenuUI;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }
            else {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        // Time.timeScale 은 시간의 흐름 의미 1이면 원래 시간, 0 이면 멈춤
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Exit_Restart(){
        restartMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameObject.Find("Player").GetComponent<Player>().ResetPlayerPosition();
    }

    public void Enter_Restart(){
        restartMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        Debug.Log("Loading Menu...");
        // Time.timeScale = 1f;
        // SceneManager.LoadScene("Menu");
    }
    
    public void QuitGame(){
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
