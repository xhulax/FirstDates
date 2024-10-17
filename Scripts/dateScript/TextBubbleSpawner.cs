using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBubbleSpawner : MonoBehaviour
{
    public TextBubbleSpawner instance;
    public GameObject textPrefab;
    public float respawnTime;

    public Transform datePosition;
    public Transform playerPosition;

    public int DateCount;
    public int PlayCount;
    public float DateNum;
    public float DateNum2;
    //public float initialNum = 1f;
    public bool Hit = false;
    public bool isSpawning;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
        DateCount = 1;
        PlayCount = 1;
        DateNum = Random.Range(0.5f, 1.5f);
        DateNum2 = Random.Range(2.5f, 3.5f);
        isSpawning = true;
    }

    private void DateSpeed()
    {
        DateNum = Random.Range(0.5f, 1.5f);
        DateNum2 = Random.Range(2.5f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
     
            switch (GameManager.Instance.gameLoop)
            {
                case 0:
                DateNum -= Time.deltaTime;
                if (isSpawning == true)
                {
                    if (DateNum < 0)
                    {
                        DateSpeed();
                        DateSpeak();
                    }
                    if (Hit == true)
                    {
                        PlayerSpeak();
                    }
                }
                    break;
                case 1:
                DateNum2 -= Time.deltaTime;
                if (isSpawning == true)
                {
                    if (DateNum2 < 0)
                    {
                        DateSpeed();
                        DateSpeak();
                    }
                    if (Hit == true)
                    {
                        PlayerSpeak();
                    }
                }
                break;
                case 2:
                if (DateCount!= PlayCount)
                {
                    DateSpeak();
                }
                if (Hit == true)
                {
                    PlayerSpeak();
                }
                break;
            

        }
    }

    private void DateSpeak()
    {
        GameObject bubbles = Instantiate(textPrefab) as GameObject;
        bubbles.transform.SetParent(datePosition);
        bubbles.transform.position = datePosition.transform.position;
        bubbles.name = DateCount.ToString();
        bubbles.GetComponent<bubble>().num = DateCount;
        bubbles.GetComponent<bubble>().spawn = instance;
        bubbles.gameObject.tag = "Date";
        DateCount++;
        //DateSpeed();
    }

    private void PlayerSpeak()
    {
        GameObject bubbles = Instantiate(textPrefab) as GameObject;
        bubbles.transform.SetParent(playerPosition);
        bubbles.transform.position = playerPosition.transform.position;
        bubbles.name = PlayCount.ToString();
        bubbles.gameObject.tag = "Player";
        bubbles.GetComponent<bubble>().num = PlayCount;
        bubbles.GetComponent<bubble>().spawn = instance;
        PlayCount++;
        Hit = false;
    }
}
