using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitsOn : MonoBehaviour 
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    public Sprite[] outfits;
    private Sprite currentSprite;

    private Color colour;
    public Color currentColour;

    public Button button;
    public GameObject panel;

    public int random1;
    public int random2;
    public int random3;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        currentColour = Color.white;
        button.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
        //GameObject.Find("Outfit 7").SetActive(false);

        CheckGameLoop();
    }

    void CheckGameLoop()
    {
        switch(GameManager.Instance.gameLoop)
        {
            case 0:
                GameObject.Find("Outfit 7").SetActive(false);
                break;
            case 1:
                GameObject.Find("Outfit 7").SetActive(false);
                random1 = Random.Range(0, 7);
                random2 = Random.Range(0, 7);
                if (random1 == random2) random1 = Random.Range(0, 7);
                if (random1 == 0 || random2 == 0) GameObject.Find("Outfit 1").SetActive(false);
                if (random1 == 1 || random2 == 1) GameObject.Find("Outfit 2").SetActive(false);
                if (random1 == 3 || random2 == 3) GameObject.Find("Outfit 4").SetActive(false);
                if (random1 == 5 || random2 == 5) GameObject.Find("Outfit 6").SetActive(false);
                if (random1 == 4 || random2 == 4) GameObject.Find("Outfit 5").SetActive(false);
                if (random1 == 6 || random2 == 6) GameObject.Find("Outfit 3").SetActive(false);
                break;
            case 2:
                GameObject.Find("Outfit 1").SetActive(false);
                GameObject.Find("Outfit 2").SetActive(false);
                GameObject.Find("Outfit 3").SetActive(false);
                GameObject.Find("Outfit 4").SetActive(false);
                GameObject.Find("Outfit 5").SetActive(false);
                GameObject.Find("Outfit 6").SetActive(false);
                GameObject.Find("Outfit 7").SetActive(true);
                panel.gameObject.SetActive(true);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        button.gameObject.SetActive(true);
        Debug.Log("trigger");
        switch (collision.gameObject.name)
        {
            case "Outfit 1":
                // Debug.Log("Red");
                currentSprite = outfits[0];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Red";
                break;

            case "Outfit 2":
                //Debug.Log("Blue");

                currentSprite = outfits[1];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Blue";
                break;

            case "Outfit 3":
                //Debug.Log("Purple");

                currentSprite = outfits[3];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Purple";
                break;

            case "Outfit 4":
                // Debug.Log("Pink");

                currentSprite = outfits[5];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Pink";
                break;

            case "Outfit 5":
                // Debug.Log("Green");

                currentSprite = outfits[4];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Green";
                break;

            case "Outfit 6":

                //Debug.Log("Yellow");
                currentSprite = outfits[2];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Yellow";
                break;

            case "Outfit 7":
                currentSprite = outfits[6];
                sr.sprite = currentSprite;
                GameManager.Instance.colour = "Grey";
                break;

        }
    }

   
}
