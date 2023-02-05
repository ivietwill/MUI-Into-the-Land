using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class functionButton : MonoBehaviour
{
    [SerializeField] GameObject closeOrDis;
    [SerializeField] GameObject aboutUI, pauseUI, storyUI, selectClose;

    [SerializeField] GameObject uiLoader;
    public Slider barLoading;

    public static bool GameIsPaused = false;
    public static bool closeProgress = true;

    // Start is called before the first frame update
    void Update()
    {
        if (closeProgress == false)
        {
            selectClose.SetActive(true);
        }
        else
        {
            selectClose.SetActive(false);
        }
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        uiLoader.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            barLoading.value = progress;

            yield return null;
        }
    }

    public void About()
    {
        aboutUI.SetActive(true);
        closeProgress= false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseUI.SetActive(true);
        GameIsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseUI.SetActive(false);
    }

    public void Close()
    {
        closeProgress = true;
    }

    public void Story()
    {
        storyUI.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
