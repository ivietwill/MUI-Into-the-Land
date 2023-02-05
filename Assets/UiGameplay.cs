using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiGameplay : MonoBehaviour
{


    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject resumeMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject quitMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseBtn()
    {
        pauseMenu.SetActive(true);
    }

    public void ResumeBtn()
    {
        pauseMenu.SetActive(true);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
