using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //wychylenie sterowania w osi pionowej
        float vertical = Input.GetAxis("Vertical");
        //wychylenie sterowania w osi poziomej
        float horizontal = Input.GetAxis("Horizontal");

        //poka� w konsoli
        Debug.Log("Wychylenie w pionie: " + vertical.ToString() + ", w poziomie: " + horizontal);
    }
}
