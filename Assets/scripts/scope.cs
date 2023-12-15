using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class scope : MonoBehaviour
{
    private bool isScoped = false;
    InputAction Scope;
    void Start()
    {
        Scope = new InputAction("scope", binding: "<mouse>/rightButton") ;

        Scope.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Scope.triggered) 
        {
            isScoped = !isScoped;        
        }

    }
}
