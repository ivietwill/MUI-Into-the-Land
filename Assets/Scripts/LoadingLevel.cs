using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingLevel : MonoBehaviour
{
    [SerializeField] int loadingTime = 5;
    // Start is called before the first frame update



    private void Start()
    {
        StartCoroutine(loads());
    }
    IEnumerator loads()
    {
        yield return new WaitForSeconds(loadingTime);
        SceneManager.LoadScene("Main Menu");
    }


   
}
