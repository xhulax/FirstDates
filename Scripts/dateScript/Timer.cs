using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float timeStart = 10;
    public TextMeshProUGUI textBox;
    private float countDown = 3;
    public TextBubbleSpawner spawn;

    // Start is called before the first frame update
    void Start()
    {
        textBox = GetComponent<TextMeshProUGUI>();
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0)
        {
            textBox.text = "Date Over!";
            countDown -= Time.deltaTime;
            spawn.isSpawning = false;
        }

        if (countDown <= 0)
        {
            countDown = 0;
            LevelManager.Instance.NextLevel();
        }
    }
}
