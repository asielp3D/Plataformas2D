using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}

    public int vidas;

    public bool isGameOver;

    public Stars counter;

    public int val = 0;






    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

   
    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over");
        Invoke("LoadScene", 2f);
        //StartCoroutine("LoadScene");
    }

    public void Win()
    {
        val += 1;

        if(val == 5)
        {
            SceneManager.LoadScene(2);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(3);
    }

    /*IEnumerator LoadScene()
    {
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(2f);
    }*/

   
    
}
