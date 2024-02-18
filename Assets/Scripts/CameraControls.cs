using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.SceneView;

public class CameraControls : MonoBehaviour
{
    public GameObject player;
    public int cameraMode;
    public bool cameraReverseModeOn = false;
    public int prevCameraMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // define cameraMode by fetching from player
        cameraMode = player.GetComponent<PlayerController>().cameraMode;
        cameraReverseModeOn = player.GetComponent<PlayerController>().cameraReverseModeOn;

        if (cameraMode != prevCameraMode || !cameraReverseModeOn)
        {
            Debug.Log("cameraMode: " + cameraMode);
            switch (cameraMode)
            {
                case 0:
                    transform.localPosition = new Vector3(0, 4.5f, -7);
                    transform.localEulerAngles = new Vector3(20, 0, 0);
                    break;
                case 1:
                    transform.localPosition = new Vector3(0, 2, 0.5f);
                    transform.localEulerAngles = new Vector3(-5, 0, 0);
                    break;
            }

            prevCameraMode = cameraMode;
        }

        if (cameraReverseModeOn)
        {
            transform.localPosition = new Vector3(0, 4.5f, 7);
            transform.localEulerAngles = new Vector3(20, 180, 0);
        }
    }
}