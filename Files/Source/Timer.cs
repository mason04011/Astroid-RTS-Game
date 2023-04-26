using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public double startTime;
    static float timer;
    static float Minutes;
    static int Seconds;
    static int ThirtySeconds;
    static string T;

   //static public bool TimerState = true;
    

    void start()
    {
        startTime = Time.realtimeSinceStartup;
    }
    
    void Update()
    {
        
            
            timer = Time.realtimeSinceStartup;
            Minutes = Mathf.FloorToInt(timer / 60);
            Seconds = Mathf.FloorToInt(timer - Minutes * 60);
            ThirtySeconds = Mathf.FloorToInt(timer - Minutes * 30);
            
             T = string.Format("{0:0}:{1:00}", Minutes, Seconds);;
           
        print(ThirtySeconds);
    }


    public static string getTimeS()
    {
        return T;
    }

    public static int getTime()
        {return (int)timer;}
}
