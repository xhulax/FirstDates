using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public Button button1;
    public Button button2;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void NextLevel()
    {
        Debug.Log("Next Level!");
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
      
        /* if (SceneManager.GetActiveScene().buildIndex == 1 && GameManager.Instance.done < 3)
        {

        }
        if (SceneManager.GetActiveScene().buildIndex == 1 && GameManager.Instance.done > 3)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 2);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 && GameManager.Instance.done > 3)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
      /*  else if (GameManager.Instance.done == 3)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }*/


    }

    public void LoadLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

    public void DateSuccess()
    {
        Application.Quit();
    }

}
