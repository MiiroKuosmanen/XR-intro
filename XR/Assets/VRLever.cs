using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRLever : MonoBehaviour
{
    public float deadTIme = 1.0f;
    private bool _deadTimeActive = false;
    public UnityEvent onPressed, onReleased;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lever" && !_deadTimeActive)
        {
            onPressed?.Invoke();
            Debug.Log("Lever is touched");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Lever" && !_deadTimeActive)
        {
            onReleased?.Invoke();
            Debug.Log("release");
            StartCoroutine(WaitForDeadTime());
        }
    }

    IEnumerator WaitForDeadTime()
    {
        _deadTimeActive = true;
        yield return new WaitForSeconds(deadTIme);
        _deadTimeActive = false;
    }
}
