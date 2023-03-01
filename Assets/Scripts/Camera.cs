using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;

    void Update () {

        // Keyboard input for camera movement
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

        // Mouse input for camera rotation
        float rotateHorizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        float rotateVertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        transform.Rotate(0, rotateHorizontal, 0);

      
    }
}
