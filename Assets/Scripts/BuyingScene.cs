using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingScene : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    private void Awake()
    {
        canvas = Canvas.FindObjectOfType<Canvas>();
        
    }
    private void Start()
    {
        canvas.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canvas.enabled = true;
        }
    }
}
