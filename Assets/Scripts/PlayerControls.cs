using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rigidbodyPlayer;
    private SceneLoading scene;

    private void Start()
    {
        
        rigidbodyPlayer = GetComponent<Rigidbody2D>();      
    }

    private void Update()
    {
        Walk(); 
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void Walk()
    {
        rigidbodyPlayer.velocity = movement;
    }

    private void OnExit()
    {
        SceneManager.LoadScene(0);
    }
}
