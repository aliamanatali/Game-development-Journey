using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will keep the vehicles coming
public class ComingVehiclesPlayerControl : MonoBehaviour
{
    public float speed=10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
