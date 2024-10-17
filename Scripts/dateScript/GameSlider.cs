using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameSlider : MonoBehaviour //IPointerDownHandler
{
    public Slider slider;
    public float value;
    public float time = 0.2f;

    private bool isIncreasing = true;

    public TextBubbleSpawner Spawn;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isIncreasing == true)
        {
            time--;
            if (time < 0)
            {
                value++;
                slider.value = Mathf.Round(value);
                time = 0.2f;
            }
            if (slider.value == slider.maxValue)
            {
                isIncreasing = false;
            }
        }
        if (isIncreasing == false)
        {
            time--;
            if (time < 0)
            {
                value--;
                slider.value = Mathf.Round(value);
                time = 0.2f;
            }
            if (slider.value == slider.minValue)
            {
                isIncreasing = true;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (GameManager.Instance.gameLoop == 0)
            {
                if (value > 45 && value < 55)
                {
                    Spawn.Hit = true;
                }
            }
            if (GameManager.Instance.gameLoop == 1)
            {
                if (value > 25 && value < 75)
                {
                    Spawn.Hit = true;
                }
            }
            if (GameManager.Instance.gameLoop == 2)
            {

                Spawn.Hit = true;

            }
        }
    }

    /*public void OnPointerDown(PointerEventData eventData)
    {
        if (GameManager.Instance.gameLoop == 0)
        {
            if (value > 45 && value < 55)
            {
                Spawn.Hit = true;
            }
        }
        if (GameManager.Instance.gameLoop == 1)
        {
            if (value > 25 && value < 75)
            {
                Spawn.Hit = true;
            }
        }
        if (GameManager.Instance.gameLoop == 2)
        {

                Spawn.Hit = true;
            
        }
    }*/
}
