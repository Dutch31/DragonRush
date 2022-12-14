using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text ProgressText;
    
    public void LoadLevel (string sceneLevel)
    {
        StartCoroutine(LoadAsynchronously(sceneLevel));
        
    }

    IEnumerator LoadAsynchronously (string sceneLevel)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneLevel);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            slider.value = progress;
            ProgressText.text = progress * 100f + "%";

            yield return null;
        }


    }
    
}
