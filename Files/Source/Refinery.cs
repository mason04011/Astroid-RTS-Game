using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refinery : MonoBehaviour
{
   
    static int workers = 5;
   
    public static int PCount,MCount;
   
    // Update is called once per frame
    void usage()
    {
        Globals.rock = Globals.rock - 2;
        Globals.power = Globals.power - 2;

    }
    void resources()
    {
        Globals.polymer = Globals.polymer + workers/5;
        Globals.metal = Globals.metal + workers/5;
    }

    private void Start()
    {
        Globals.rock = Globals.rock - 25;
        Globals.workers = Globals.workers - 5;
        InvokeRepeating("usage",2f,1f);
        InvokeRepeating("resources",1f,1f);
        
    }

    void Update()
    {
   
       
    }
  
}
