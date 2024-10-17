using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateManager : MonoBehaviour
{
    public GameObject date1;
    public GameObject date2;
    public GameObject date3;
    //public GameObject player;
    //private SpriteRenderer sr;
    //private Color Colour;

    // Start is called before the first frame update
    void Start()
    {
       // player = GameObject.Find("Player");
        date1 = GameObject.Find("Date");
        date2 = GameObject.Find("Date2");
        date3 = GameObject.Find("Date3");
        LoopCheck();
    }

    void LoopCheck()
    {
        switch (GameManager.Instance.gameLoop)
        {
            case 0:
                date1.SetActive(true);
                date2.SetActive(false);
                date3.SetActive(false);
                break;
            case 1:
                date1.SetActive(false);
                date2.SetActive(true);
                date3.SetActive(false);
                break;
            case 2:
                date1.SetActive(false);
                date2.SetActive(false);
                date3.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*switch (GameManager.Instance.colour)
        {
            case "Red":
                break;
            case "Blue":
                break;
            case "Green":
                break;
            case "Yellow":
                break;
            case "Purple":
                break
        }*/
    }
}
