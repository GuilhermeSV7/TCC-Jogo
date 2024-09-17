using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void mainMenu()
    {
        Debug.Log("Voltando para o menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void PlayGame()
    {
        Debug.Log("Comecando a jogar");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo");
        Application.Quit();
    }

    public void Settings()
    {
        Debug.Log("Indo para as configuracoes");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    
}
