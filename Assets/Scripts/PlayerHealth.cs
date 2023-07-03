using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverHandeler gameOverHandeler;
    public void Crash()
    {
        gameOverHandeler.EndGame();
        gameObject.SetActive(false);
        
    }
}
