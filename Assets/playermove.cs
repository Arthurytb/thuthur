using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float movespeed;

    CharacterController ch;
    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * movespeed *  Time.deltaTime;
        ch.Move(new Vector3(x,0,z));
        
    }
}
