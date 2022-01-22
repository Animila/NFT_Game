using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_Windows : MonoBehaviour
{

    public bool Pause_Game;
    public GameObject Pause_Game_Panel;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Pause_Game){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
    }

    public void PauseGame(){
        Pause_Game_Panel.SetActive(true);
        Time.timeScale = 0f;
        Pause_Game = true;
    }

    public void ResumeGame(){
        Pause_Game_Panel.SetActive(false);
        Time.timeScale = 1f;
        Pause_Game = false;
    }

    public void Menu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Reset(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
