using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float camSpeed;
    private Vector2 lookMos;
    private float xRot;
    private float yRot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        // Finds sensitivity in the local save data
        if (PlayerPrefs.GetFloat("Sensitivity") > 0)
        {
            camSpeed = PlayerPrefs.GetFloat("Sensitivity");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Gets raw mouse input location from screen
        lookMos = camSpeed * Time.deltaTime * new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        // Moving down increases x rotation (look up), up decreases x rotation (look down)
        xRot -= lookMos.y;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        // Moving right increases y rotation (look right), left decreases y rotation (look left)
        yRot += lookMos.x;
        yRot = Mathf.Clamp(yRot, -120f, 120f);

        transform.localRotation = Quaternion.Euler(xRot, yRot, 0f);

    }
}
