using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class test : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (action.action.triggered) {
            if (light.color == Color.red) {
                light.color = Color.white;
            } else {
                light.color = Color.red;
            };
        };
    }
}
