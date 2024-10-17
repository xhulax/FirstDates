using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeethChange : MonoBehaviour
{
    public Slider slide;
    public float time;

    float progress = 0f;

    private void Start()
    {
        time = Time.deltaTime * 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (slide.value == slide.maxValue)
        {
            GameManager.Instance.done++;
            LevelManager.Instance.NextLevel();
        }
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("Enter");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Stay");
        if (collision.gameObject.name == "Toothbrush")
        {
            progress++;
            slide.value = progress;
            Debug.Log(slide.value);
        }
    }


    /* private void OnCollisionStay(Collision collision)
     {
         if(collision.gameObject.name == "Toothbrush")
         {
             slide.value++;
             Debug.Log(slide.value);
         }
     }*/

}
