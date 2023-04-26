using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    
    static int MineWorkers = 10;
    
   
    // Update is called once per frame
    void Start()
    {
        Globals.rock = Globals.rock - 20;
        Globals.workers = Globals.workers - MineWorkers;
        InvokeRepeating("mined",1f,1f);
    }

    void mined()
    {

        Globals.rock = Globals.rock + MineWorkers/10;
        Globals.power = Globals.power - 1;
        //print(MineTime + "MineTIme");
    }
     void Update()
    {
        
        
       
    }
   
}
