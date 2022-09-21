using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingRed : MonoBehaviour
{

    [SerializeField] private GameObject player;
    SpriteRenderer changeColor;
    [SerializeField] private Canvas canvas;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("NewShirt");
        changeColor = player.GetComponent<SpriteRenderer>();
        canvas = Canvas.FindObjectOfType<Canvas>();
        canvas.enabled = false;
    }
    public void OnClick()
    {
        {
            changeColor.color = Color.red;
        }
    }
    public void EndBuyCanvas()
    {
        canvas.enabled = false;
    }
}
