using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderManager : MonoBehaviour
{
    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    public int value;
    public float time = 0.2f;

    private bool isIncreasing = true;

    public TextBubbleSpawner Spawn;


    // Start is called before the first frame update
    void Start()
    {
        CheckGameLoop();
    }

    void CheckGameLoop()
    {
        switch(GameManager.Instance.gameLoop)
        {
            case 0:
                slider.gameObject.SetActive(true);
                slider2.gameObject.SetActive(false);
                slider3.gameObject.SetActive(false);
                break;
            case 1:
                slider.gameObject.SetActive(false);
                slider2.gameObject.SetActive(true);
                slider3.gameObject.SetActive(false);
                break;
            case 2:
                slider.gameObject.SetActive(false);
                slider2.gameObject.SetActive(false);
                slider3.gameObject.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
