using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    } 
    
    public void Win()
    {
        SceneManager.LoadScene(2);
    }

    public void Lose()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
