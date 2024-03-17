using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager2 : MonoBehaviour
{
   InputManager2 inputManager;
   PlayerLocomotion2 playerLocomotion;

   private void Awake()
   {
        inputManager = GetComponent<InputManager2>();
        playerLocomotion = GetComponent<PlayerLocomotion2>();
   }

   private void Update()
   {
        inputManager.HandleAllInputs();
   }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
