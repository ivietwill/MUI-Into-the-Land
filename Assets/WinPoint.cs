using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPoint : MonoBehaviour
{
    [SerializeField] private GameObject WinMenu;
    private void Start()
    {
       WinMenu.SetActive(false);
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            WinMenu.SetActive(true);
        }
    }
}
