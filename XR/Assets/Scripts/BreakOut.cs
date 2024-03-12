using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BreakOut : MonoBehaviour
{
    public InputActionReference action;
    // Start is called before the first frame update
    public Vector3 start = new Vector3(0, 0, -6);
    public Vector3 second = new Vector3(0, 0, -40);
void Start()
{
    if (action != null)
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if(transform.position == start){
                transform.position = second;
            } else {
                transform.position = start;
            }
        };
    }
    else
    {
        Debug.LogError("Action is not set.");
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}
