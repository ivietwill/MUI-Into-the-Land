using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public float timer = 10;
    private playerController playerCon;

    void Update()
    {
        timer -= Time.deltaTime;
    }
}
