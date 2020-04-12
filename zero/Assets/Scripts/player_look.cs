using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_look : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSecsivity = 100f;
    float xAxisRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSecsivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSecsivity * Time.deltaTime;

        xAxisRotation -= mouseY;
        xAxisRotation = Mathf.Clamp(xAxisRotation, -90f, 90f);

        transform.localRotation=Quaternion.Euler(xAxisRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
