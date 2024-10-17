using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AlarmBehaviour : MonoBehaviour, IPointerClickHandler 
{
    public AlarmSpawn Spawner;
    public GameObject AlarmSpawner;

    // Start is called before the first frame update
    void Start()
    {
        AlarmSpawner = GameObject.Find("AlarmSpawner");
        Spawner = AlarmSpawner.GetComponent<AlarmSpawn>();

        CheckGameLoop();
    }

    void CheckGameLoop()
    {
        switch(GameManager.Instance.gameLoop)
        {
            case 0:
                break;
            case 1:
                transform.localScale = new Vector2(transform.localScale.x - 0.25f, transform.localScale.y - 0.25f);
                break;
            case 2:
                transform.localScale = new Vector2(transform.localScale.x - 0.75f, transform.localScale.y - 0.75f);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Spawner.Hit++;
        Spawner.num--;
    }
}
