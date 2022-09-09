using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 CameraOffset;

    void Update()
    {
        transform.position = targetTransform.position + CameraOffset;

    
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = GetComponent<UnityEngine.Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                string objname = hit.collider.gameObject.name;
                Debug.Log(objname);
            }
        }
    }
}

