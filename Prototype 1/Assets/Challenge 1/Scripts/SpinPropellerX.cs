using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public Vector3 spin = new Vector3(0, 0, 10);
    public float speed = 150.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin * Time.deltaTime * speed);
    }
}
