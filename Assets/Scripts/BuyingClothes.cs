using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyingClothes : MonoBehaviour
{

    [SerializeField] private GameObject player;
    SpriteRenderer changeColor;
    [SerializeField] private Canvas canvas;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("NewShirt");
        changeColor = player.GetComponent<SpriteRenderer>();
        canvas = Canvas.FindObjectOfType<Canvas>();
        canvas.enabled = true;
    }
    public void OnClick()
    {
        {
            changeColor.color = Color.blue;
        }
    }
    public void EndBuyCanvas()
    {
        canvas.enabled = false;
    }
}
