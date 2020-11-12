using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinnin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
