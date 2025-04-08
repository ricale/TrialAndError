using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] private bool invert;
    private Transform cameraTransform;

    private void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        if(invert)
        {
            // Vector3 dirToCamera = cameraTransform.position - transform.position;
            // dirToCamera = dirToCamera.normalized;
            // transform.LookAt(transform.position + dirToCamera * - 1);
            transform.LookAt(cameraTransform.forward);
        } else {
            transform.LookAt(cameraTransform);
        }
    }
}
