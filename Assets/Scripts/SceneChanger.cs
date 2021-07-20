using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    private AsyncOperation sceneLoad;
    void Start()
    {
    }
    void Update()
    {
    }
    public void LoadScene(string sceneName)
    { 
        sceneLoad = SceneManager.LoadSceneAsync(sceneName);
        sceneLoad.allowSceneActivation = false;
        blackScreen.GetComponent<SceneChangeAnimator>().animationType = true;
    }
    public void ChangeScene()
    { 
        sceneLoad.allowSceneActivation = true;
    }
}
