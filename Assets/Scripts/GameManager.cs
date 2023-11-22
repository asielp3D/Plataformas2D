using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}

    public int vidas;

    public bool isGameOver;



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
