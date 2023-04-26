using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Solar : MonoBehaviour
{
    public static int workers = 5;

    // Start is called before the first frame update
    void Start()
    {
        Globals.metal = Globals.metal - 10;
        Globals.polymer = Globals.polymer - 10;
        Globals.workers = Globals.workers - workers;
        InvokeRepeating("powergain",2f,1f);
    }

    void powergain()
    {
        Globals.power = Globals.power + (workers*2)/5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
