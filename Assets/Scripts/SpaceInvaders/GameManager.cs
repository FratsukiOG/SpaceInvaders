using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private bool isGameOver = false;

    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            // Cargar la escena de Game Over
            SceneManager.LoadScene(1);
        }
    }

    public void RestartGame()
    {
        // Reiniciar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
