using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will change camera prespectives
public class ChangeCamera : MonoBehaviour
{
    public Camera MainCamera;
    public Camera Camera;
 
    
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        Camera.enabled = false;
    }

    public void ShowMainCamera() 
    {
        MainCamera.enabled = true;
        Camera.enabled = false;
    }
   
    public void ShowCamera()
    {
        MainCamera.enabled = false ;
        Camera.enabled = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            ShowCamera();
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            ShowMainCamera();
        }
    }
}
