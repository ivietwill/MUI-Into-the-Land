using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLight : MonoBehaviour
{
    public float timer = 1800;
    private playerController playerCon;

    public Light lightsObj;
  //  public GameObject lightObj;



    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 1500)
        {
            lightsObj.intensity = 5;
        }

        if(timer <= 1200)
        {
            lightsObj.intensity = 4;
        }

        if (timer <= 900)
        {
            lightsObj.intensity = 3;
        }

        if(timer <= 600)
        {
            lightsObj.intensity = 2;
        }

        if(timer <= 300)
        {
            lightsObj.intensity = 1;
        }

       if(timer <= 10)
        {
            lightsObj.intensity = 0;
            //Game Over
        }

     
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


}
