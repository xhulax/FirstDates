using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AlarmSpawn : MonoBehaviour
{
    [SerializeField] private float PosX;
    [SerializeField] private float PosY;

    public GameObject AlarmPrefab;
    public float respawnTime;

    private int AlarmCount;
    public int num;
    public int Hit;

    public Button button;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        Hit = 0;
        num = 0;
        AlarmCount = 0;
        button.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }

    private void RandomPosition()
    {
        PosX = Random.Range(-3.7f, 3.7f);
        PosY = Random.Range(-4.7f, 4.7f);
    }

    private void SpawnAlarm()
    {
        GameObject alarm = Instantiate(AlarmPrefab) as GameObject;
        alarm.name = AlarmCount.ToString();
        alarm.transform.position = new Vector2(PosX, PosY);
        AlarmCount++;
        num++;
    }

    // Update is called once per frame
    void Update()
    {
        if(num != 1 && Hit != 3)
        {
            RandomPosition();
            SpawnAlarm();
        }

        if (Hit == 3)
        {
            button.gameObject.SetActive(true);
            if (GameManager.Instance.gameLoop == 2) panel.gameObject.SetActive(true);
        }

    }
}
