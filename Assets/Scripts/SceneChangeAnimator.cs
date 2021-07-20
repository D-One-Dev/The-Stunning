using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChangeAnimator : MonoBehaviour
{
    [SerializeField] private GameObject sceneManager;
    [SerializeField] private Image blackScreen;
    public bool animationType;
    void Start()
    {
        blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, 1f);
    }
    void FixedUpdate()
    {
        if (!animationType && blackScreen.color.a > 0f)
        {
            blackScreen.color -= new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Time.fixedDeltaTime * 4);
        }
        else if(animationType && blackScreen.color.a < 1f)
        { 
            blackScreen.color += new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Time.fixedDeltaTime * 4);
        }
        else if (animationType && blackScreen.color.a >= 1f)
        {
            sceneManager.GetComponent<SceneChanger>().ChangeScene();
        }
    }
}
