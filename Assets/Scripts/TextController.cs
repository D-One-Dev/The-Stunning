using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private Text[] texts;
    [SerializeField] private string[] phrasesEng, phrasesRus;
    void Start()
    {
        ChangeLanguage();
    }
    void FixedUpdate()
    {
    }
    public void ChangeLanguage()
    {
        if (PlayerPrefs.GetInt("Language", 0) == 0)
        {
            for (int a = 0; a < texts.Length; a++)
            { 
                texts[a].text = phrasesEng[a];
            }
        }
        else if (PlayerPrefs.GetInt("Language", 0) == 1)
        {
            for (int a = 0; a < texts.Length; a++)
            {
                texts[a].text = phrasesRus[a];
            }
        }
    }
}
