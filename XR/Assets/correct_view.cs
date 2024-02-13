using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class correct_view : MonoBehaviour
{
    public Transform mainCamera;
    public Transform lens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       UnityEngine.Vector3 localPlayer = lens.InverseTransformPoint(mainCamera.position);
       transform.position = lens.position;UnityEngine.Vector3 lookatmirror = lens.TransformPoint(new UnityEngine.Vector3(-localPlayer.x, -localPlayer.y, -localPlayer.z));
       transform.LookAt(lookatmirror, lens.up);

    }
}
