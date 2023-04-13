using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseMovement : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed;
    public Vector3 rotationAxis;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        transform.RotateAround(target.transform.position, Vector3.up, rotateHorizontal * cameraSpeed); 
    }
}
