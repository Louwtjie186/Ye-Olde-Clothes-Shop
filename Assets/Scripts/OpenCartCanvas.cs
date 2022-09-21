using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCartCanvas : MonoBehaviour
{
    
    [SerializeField] Canvas canvasTwo;

    private void Awake()
    {
        canvasTwo = Canvas.FindObjectOfType<Canvas>();
    }

    private void Start()
    {
        canvasTwo.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            canvasTwo.enabled = true;
        }
    }

}


