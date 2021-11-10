using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 0.02f;
    float camRotation = 0.0f;
    float rotation = 5.00f;
    public float rotationSpeed = 2.0f;
    public float camRotationSpeed = 3.00f;
    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
        transform.position = transform.position + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation - Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
}

// 1. All the floats at the top.
// 2. Change the + > -.
// 3. Adding another line and change forward into right and vertical into horizontal.