using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] GameObject weaponParent;
    public GameObject Player;

    public void GameOver() 
    {
        Debug.Log("Game over");
        gameOverPanel.SetActive(true);
        weaponParent.SetActive(false);
        Player.SetActive(false);
    }
}
