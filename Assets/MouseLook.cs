using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class MouseLook : MonoBehaviour {

    private Vector3 mousePrevious;

    void Update()
    {
        //Mouse look if VR is disabled
        if (!VRDevice.isPresent)
        {
            Vector3 mouseCurrent = Input.mousePosition;
            Vector3 mouseDelta = mouseCurrent - mousePrevious;
            mousePrevious = mouseCurrent;
            transform.RotateAround(transform.position, Vector3.up, mouseDelta.x);
            transform.RotateAround(transform.position, transform.right, -mouseDelta.y);
        }
    }
}
