using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]private PlayerInput _playerInput;
    private GameControls _gameControls;

    private void OnEnable()
    {
        _playerInput.onActionTriggered += OnAction;
    }

    

    void Start()
    {
        _gameControls = new GameControls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnAction(InputAction.CallbackContext obj);
    {
        
    }
         
             
         
}

internal class GameControls
{
}
