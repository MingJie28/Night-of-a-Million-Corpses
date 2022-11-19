using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject Player;

    public void GameOver() 
    {
        Debug.Log("Game over");
        Player.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
