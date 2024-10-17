using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodItems : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public string foodName;
    public int foodClick;
    public Plate plate;
    public SpriteRenderer sr;

    public Sprite[] toast;
    public Sprite[] beans;
    public Sprite[] sausages;
    public Sprite[] eggs;
    public Sprite[] coffee;
    public Sprite[] croissant;
    public Sprite currentSprite;

    public int value;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        foodName = this.gameObject.name;
        FoodBites();
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void FoodBites()
    {
        switch(foodName)
        {
            case "Toast":
                foodClick = 3;
                break;
            case "Egg":
                foodClick = 2;
                break;
            case "Sausages":
                foodClick = 4;
                break;
            case "Beans":
                foodClick = 4;
                break;
            case "Coffee":
                foodClick = 5;
                break;
            case "Croissant":
                foodClick = 4;
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       /* switch(foodName)
        {
            case "Toast":
                Debug.Log("toast");
                transform.localScale = new Vector2(transform.localScale.x / 3,transform.localScale.y);
                break;
        }*/
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
        foodName = this.gameObject.name;
        switch (foodName)
        {
            case "Toast":
                //Debug.Log("toast");
                currentSprite = toast[value];
                sr.sprite = currentSprite;
                foodClick--;
                if (foodClick == 0) Destroy(this.gameObject);
                value++;              
                break;

            case "Egg":
               // Debug.Log("Egg");
                currentSprite = eggs[value];
                sr.sprite = currentSprite;
                foodClick--;
                value++;
                if (foodClick == 0) Destroy(this.gameObject);
                break;

            case "Sausages":
                currentSprite = sausages[value];
                sr.sprite = currentSprite;
                foodClick--;
                value++;
                if (foodClick == 0) Destroy(this.gameObject);
                break;

            case "Beans":
                currentSprite = beans[value];
                sr.sprite = currentSprite;
                foodClick--;
                value++;
                if (foodClick == 0) Destroy(this.gameObject);
                break;

            case "Coffee":
                currentSprite = coffee[value];
                sr.sprite = currentSprite;
                foodClick--;
                value++;
                if (foodClick == 0) Destroy(this.gameObject);
                break;

            case "Croissant":
                currentSprite = croissant[value];
                sr.sprite = currentSprite;
                foodClick--;
                value++;
                if (foodClick == 0) Destroy(this.gameObject);
                break;

        }
    }

    private void OnDestroy()
    {
        plate.foodNum--;
        //if (plate.foodNum == 0) GameManager.Instance.done--;
    }
}
