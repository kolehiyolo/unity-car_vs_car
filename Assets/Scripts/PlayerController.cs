using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerNum;
    public float maxSpeed;
    public float rotateSpeed;
    private int cameraModeCount = 2;
    public int cameraMode;
    public bool cameraReverseModeOn = false;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string playerInput = "P" + playerNum + "_";

        if (Input.GetButtonDown(playerInput + "CameraSwitch"))
        {
            cameraMode = cameraMode + 1;
            if (cameraMode >= cameraModeCount)
            {
                cameraMode = 0;
            }
        }

        if (Input.GetButton(playerInput + "CameraReverse"))
        {
            cameraReverseModeOn = true;
        }

        if (Input.GetButtonUp(playerInput + "CameraReverse"))
        {
            cameraReverseModeOn = false;
        }

        horizontalInput= Input.GetAxis(playerInput + "Horizontal");
        verticalInput = Input.GetAxis(playerInput + "Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * maxSpeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput * verticalInput);
    }
}
