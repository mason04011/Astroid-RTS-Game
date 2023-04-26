using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub : MonoBehaviour
{
   
    static int MineWorkers = 5;
    public Transform surfaceRock;
   
    // Update is called once per frame
    void minerock()
    {
        Globals.rock = Globals.rock + MineWorkers/5;
        Globals.power++;
    }

    private void Start()
    {
        InvokeRepeating("minerock",1f,1f);
    }

    void Update()
    {

        
            
        print(Globals.rock + " rocks");
        
       
    }

}
