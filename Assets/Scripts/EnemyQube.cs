using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnemyQube : MonoBehaviour
{
    public Text amountText;
    private int amount;
    private SpriteRenderer spriteRenderer;
    public Color easyColor, mediumColor, hardColor;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetAmount();
    }

    public void SetAmount()
    {
        gameObject.SetActive(true);
        amount = Random.Range(1, 5);
        if (amount <=0)
        {
            gameObject.SetActive(false);
        }

        SetAmountText();
        //SetColor();
    }
    public void SetAmountText()
    {
        amountText.text = amount.ToString();
    }
    //public void SetColor()
    //{
    //    int playerLives = FindObjectOfType<Player>().transform.childCount;
    //    Color newColor;

    //    if (amount > playerLives)
    //    {
    //        newColor = hardColor;
    //    }
    //    else if (amount > playerLives / 2)
    //    {
    //        newColor = mediumColor;
    //    }
    //    else
    //    {
    //        newColor = easyColor;
    //    }

    //    spriteRenderer.color = newColor;

    //}
}
