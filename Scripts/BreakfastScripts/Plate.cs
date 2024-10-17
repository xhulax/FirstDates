using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plate : MonoBehaviour
{
    public static Plate Instance;
    public int foodNum;
    public GameObject Loop1;
    public GameObject Loop2;
    public GameObject Loop3;
    public Button button;


    void Awake()
    {
       /* if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }*/

    }

    // Start is called before the first frame update
    void Start()
    {
        Loop1 = GameObject.Find("FirstLoop");
        Loop2 = GameObject.Find("SecondLoop");
        Loop3 = GameObject.Find("ThirdLoop");


        if (GameManager.Instance.gameLoop == 0)
        {
            foodNum = 7;
        }
        if (GameManager.Instance.gameLoop == 1)
        {

            foodNum = 2;
        }
        if (GameManager.Instance.gameLoop == 2)
        {
            foodNum = 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.gameLoop == 0)
        {
            Loop1.SetActive(true);
            Loop2.SetActive(false);
            Loop3.SetActive(false);
        }
        if (GameManager.Instance.gameLoop == 1)
        {
            Loop1.SetActive(false);
            Loop2.SetActive(true);
            Loop3.SetActive(false);
            //foodNum = 2;
        }
        if (GameManager.Instance.gameLoop == 2)
        {
            Loop1.SetActive(false);
            Loop2.SetActive(false);
            Loop3.SetActive(true);
            button.gameObject.SetActive(true);

        }

        if (foodNum == 0)
        {
            Debug.Log("Done");
            LevelManager.Instance.NextLevel();
        }
    }

    void PlateEmpyt()
    {

    }

    
}
