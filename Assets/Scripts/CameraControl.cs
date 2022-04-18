using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //FPS kamera kontrol

    [Range(0, 300)]
    public float sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    int counter = 1;

    public GameObject panel;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void Update()
    {
        //Kamera Kontrol
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 45f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Q) && counter % 2 != 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            counter++;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && counter % 2 == 0)
        {
            Time.timeScale = 1;
            panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            counter++;
        }


    }

}