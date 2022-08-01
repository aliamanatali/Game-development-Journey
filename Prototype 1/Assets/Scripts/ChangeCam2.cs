using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam2 : MonoBehaviour
{
        public Camera MainCam;
        public Camera Cam;


        // Start is called before the first frame update
        void Start()
        {
            MainCam.enabled = true;
            Cam.enabled = false;
        }

        public void ShowMainCam()
        {
            MainCam.enabled = true;
            Cam.enabled = false;
        }

        public void ShowCam()
        {
            MainCam.enabled = false;
            Cam.enabled = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                ShowCam();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                ShowMainCam();
            }
        }
    }
