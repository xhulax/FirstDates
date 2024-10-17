using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{

    public TextBubbleSpawner spawn;
    public int num;
    public string tag;

    public Sprite[] sprites;
    public Sprite CurrentSprite;

    public float countdown;

    public Rigidbody2D rb;
    public SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
        //spawn = TextBubbleSpawner.instance()
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
       tag = this.gameObject.tag;
        countdown = 40f;

    }

 

    // Update is called once per frame
    void Update()
    {

        countdown--;
        if (countdown < 0)
        {
            rb.transform.position += new Vector3(0, 1.5f, 0);
            countdown = 30f;
        }

        if (transform.position.y > 6f) Destroy(this.gameObject);
    }
}
