using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   
    static int GenWorkers = 5;
   
   
   
    // Update is called once per frame
    void PowerGen()
    {
        
        Globals.power = Globals.power + GenWorkers/5;
    }

    private void Start()
    {
        Globals.rock = Globals.rock - 25;
        Globals.workers = Globals.workers - 5;
        InvokeRepeating("PowerGen",1f,1f);
    }

    void Update()
    {
       
        
        
    }
  
}
