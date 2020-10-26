using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5;
    private float TurnSpeedL = -1;
    private float TurnSpeedR = 1;
    private float ForwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ForwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * ForwardInput) ;

        if (Input.GetKey("d"))
            {
            transform.Rotate(0, TurnSpeedR, 0);
            }

        if (Input.GetKey("a"))
            {
            transform.Rotate(0, TurnSpeedL, 0);
            }
            
       
    }
}