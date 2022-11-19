using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameplay(string stageToPlay) 
    {
        SceneManager.LoadScene("Essential", LoadSceneMode.Single);
        SceneManager.LoadScene(stageToPlay, LoadSceneMode.Additive);
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
