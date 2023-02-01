using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputActionManagerScript : MonoBehaviour
{
    public InputActionProperty testProp; //will **InputActionProperty** need to be changed if not working

    void Awake()
    {
        testProp.action.started += OnTrigger; //will need to be changed if not working
    }


    void OnTrigger(InputAction.CallbackContext context) //will need to be changed if not working
    {
        Debug.Log("Trigger pulled");
    }
}

//Change some things if the HTC Vive doesnt work with these controlls Inputs can be started with menu systems now 
//dont forget to drag the input maps/ select the input map in the inspector under the Player under the Main character.s
