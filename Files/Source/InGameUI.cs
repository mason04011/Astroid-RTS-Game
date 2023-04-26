using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.LowLevel;
using Debug = System.Diagnostics.Debug;

public class InGameUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timeTrack,SpaceRock,Workers,Polymers,Metal,Power;
    public GameObject audiosource;
    private AudioSource music;

    public void mute()
    {
        if (music.isPlaying)
        {
            music.Pause();
        }
        else
        {
            music.Play();
        }
    }
    public void Pause(){
       // Timer.TimerState = false;
    }
    public void Start()
    {
        music = audiosource.GetComponent<AudioSource>();
    }

    public void play(){
        SceneManager.LoadScene("Game2");
    }

    public void MainMenu(){
        SceneManager.LoadScene("Menu");
    }
    
    public void controls(){
        SceneManager.LoadScene("Controls");
    }

    
    public void exit(){
       Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        timeTrack.text = Timer.getTimeS();
        SpaceRock.text = string.Format("{0}", Globals.Rock());
        Workers.text = string.Format("{0}", Globals.Workers());
        Polymers.text = string.Format("{0}", Globals.Polymer());
        Metal.text = string.Format("{0}", Globals.Metal());
        Power.text = string.Format("{0}", Globals.Power());
        print(Timer.getTimeS());
    }
}
