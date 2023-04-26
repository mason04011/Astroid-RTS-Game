using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Globals.rock = Globals.rock - 30;
        Globals.metal = Globals.metal - 15;
        Globals.polymer = Globals.polymer - 10;
        Globals.workers = Globals.workers + 15;
        InvokeRepeating("bunks",1f,1f);
    }

    void bunks()
    {
        Globals.power--;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
