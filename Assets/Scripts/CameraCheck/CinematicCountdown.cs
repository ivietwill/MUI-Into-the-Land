using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCountdown : MonoBehaviour
{

    [SerializeField] GameObject CineCam;
    [SerializeField] GameObject Joystick;
    [SerializeField] GameObject Btn;
    [SerializeField] GameObject JoystickLogo;

    [SerializeField] float WaitTime = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        Btn.SetActive(false);
        Joystick.SetActive(false);
        JoystickLogo.SetActive(false);
       

        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(WaitTime);
        Btn.SetActive(true);
        Joystick.SetActive(true);
        JoystickLogo.SetActive(true);
        gameObject.SetActive(false);
    }
}
