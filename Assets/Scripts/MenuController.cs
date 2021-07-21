using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject sounds, music, mainList, SettingsList, settingsParameters;
    [SerializeField] private AudioClip tickSound;
    [SerializeField] private GameObject[] menuPoints, settingsPoints;
    [SerializeField] private Text[] settingsValues;
    private int[] PosX, maxPosX;
    private GameObject[] currentPoints;
    private int currentPosY, fullScreen;
    private PlayerInput pi;
    private void Awake()
    {
        pi = new PlayerInput();
        pi.Menu.StringUp.performed += context => StringUp();
        pi.Menu.StringDown.performed += context => StringDown();
        pi.Menu.StringLeft.performed += context => StringLeft();
        pi.Menu.StringRight.performed += context => StringRight();
        pi.Menu.Select.performed += context => Select();
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
        currentPoints = menuPoints;
        ChangeAnim(true);
        PosX = new int[]{7, 1, 5, 5, 1};
        maxPosX = new int[]{ 9, 1, 10, 10, 1 };
        int resX = PlayerPrefs.GetInt("ScreenResX", 1920);
        int resY = PlayerPrefs.GetInt("ScreenResY", 1080);
        fullScreen = PlayerPrefs.GetInt("FullScreen", 1);
        if (fullScreen == 1)
        {
            Screen.SetResolution(resX, resY, true);
            PosX[1] = 1;
            settingsValues[1].text = "Fullscreen";
        }
        else
        { 
            Screen.SetResolution(resX, resY, false);
            PosX[1] = 0;
            settingsValues[1].text = "Windowed";
        }    
        settingsValues[currentPosY].text = resX.ToString() + " x " + resY.ToString();
        if (resX == 800 && resY == 600) PosX[0] = 0;
        else if (resX == 1024 && resY == 768) PosX[0] = 1;
        else if (resX == 1280 && resY == 720) PosX[0] = 2;
        else if (resX == 1280 && resY == 1024) PosX[0] = 3;
        else if (resX == 1366 && resY == 768) PosX[0] = 4;
        else if (resX == 1600 && resY == 900) PosX[0] = 5;
        else if (resX == 1680 && resY == 1050) PosX[0] = 6;
        else if (resX == 1920 && resY == 1080) PosX[0] = 7;
        else if (resX == 2560 && resY == 1440) PosX[0] = 8;
        else if (resX == 3840 && resY == 2160) PosX[0] = 9;
        PosX[2] = Mathf.RoundToInt(PlayerPrefs.GetFloat("SoundVolume", 5f));
        settingsValues[2].text = PlayerPrefs.GetFloat("SoundVolume", 5f).ToString();
        PosX[3] = Mathf.RoundToInt(PlayerPrefs.GetFloat("MusicVolume", 5f));
        settingsValues[3].text = PlayerPrefs.GetFloat("MusicVolume", 5f).ToString();
    }
    void Update()
    {
    }
    private void StringUp()
    {
        sounds.GetComponent<SoundController>().PlaySound(tickSound);
        if (currentPosY > 0)
        {
            ChangeAnim(false);
            currentPosY--;
            ChangeAnim(true);
        }
        else
        {
            ChangeAnim(false);
            currentPosY = currentPoints.Length - 1;
            ChangeAnim(true);
        }
    }
    private void StringDown()
    {
        sounds.GetComponent<SoundController>().PlaySound(tickSound);
        if (currentPosY < currentPoints.Length - 1)
        {
            ChangeAnim(false);
            currentPosY++;
            ChangeAnim(true);
        }
        else
        {
            ChangeAnim(false);
            currentPosY = 0;
            ChangeAnim(true);
        }
    }
    private void StringLeft()
    {
        if (currentPoints == settingsPoints)
        {
            if (currentPosY < PosX.Length)
            {
                sounds.GetComponent<SoundController>().PlaySound(tickSound);
                if (PosX[currentPosY] > 0)
                {
                    PosX[currentPosY]--;
                }
                else
                {
                    PosX[currentPosY] = maxPosX[currentPosY];
                }
            }
            ChangeSetting();
        }
    }
    private void StringRight()
    {
        if (currentPoints == settingsPoints)
        { 
            if (currentPosY < PosX.Length)
            {
                sounds.GetComponent<SoundController>().PlaySound(tickSound);
                if (PosX[currentPosY] < maxPosX[currentPosY])
                {
                    PosX[currentPosY]++;
                }
                else
                {
                    PosX[currentPosY] = 0;
                }
            }
            ChangeSetting();
        }
    }
    private void ChangeAnim(bool type)
    {
        switch (type)
        {
            case false:
                currentPoints[currentPosY].GetComponent<TextAnimation>().animEnable = false;
                break;
            case true:
                currentPoints[currentPosY].GetComponent<TextAnimation>().animEnable = true;
                break;
        }
    }
    private void Select()
    {
        sounds.GetComponent<SoundController>().PlaySound(tickSound);
        switch (currentPosY)
        {
            case 0:
                {
                    if (currentPoints == menuPoints)
                    {
                        Debug.Log(PlayerPrefs.GetInt("LevelNumber", -1));
                    }
                    else if (currentPoints == settingsPoints)
                    {
                        Debug.Log("Resolution");
                    }
                }
                break;
            case 1:
                {
                    if (currentPoints == menuPoints)
                    {
                        Debug.Log("Continue");
                    }
                    else if (currentPoints == settingsPoints)
                    {
                        Debug.Log("Screen mode");
                    }
                }
                break;
            case 2:
                {
                    if (currentPoints == menuPoints)
                    {
                        ChangeAnim(false);
                        mainList.SetActive(false);
                        SettingsList.SetActive(true);
                        settingsParameters.SetActive(true);
                        currentPoints = settingsPoints;
                        currentPosY = 0;
                        ChangeAnim(true);
                    }
                    else if (currentPoints == settingsPoints)
                    {
                        Debug.Log("Sounds volume");
                    }
                    
                }
                break;
            case 3:
                {
                    if (currentPoints == menuPoints)
                    {
                        Application.Quit();
                    }
                    else if (currentPoints == settingsPoints)
                    {
                        Debug.Log("Music volume");
                    }
                }
                break;
            case 4:
                {
                    if (currentPoints == menuPoints)
                    {

                    }
                    else if (currentPoints == settingsPoints)
                    {
                        Debug.Log("Text language");
                    }
                }
                break;
            case 5:
                {
                    if (currentPoints == menuPoints)
                    {
                        
                    }
                    else if (currentPoints == settingsPoints)
                    {
                        ChangeAnim(false);
                        SettingsList.SetActive(false);
                        settingsParameters.SetActive(false);
                        mainList.SetActive(true);
                        currentPoints = menuPoints;
                        currentPosY = 0;
                        ChangeAnim(true);
                    }
                }
                break;

            default:
                break;
        }
    }
    private void ChangeSetting()
    {
        switch (currentPosY)
        { 
            case 0:
                {
                    switch (PosX[currentPosY])
                    {
                        case 0:
                            ChangeResolution(800, 600);
                            break;
                        case 1:
                            ChangeResolution(1024, 768);
                            break;
                        case 2:
                            ChangeResolution(1280, 720);
                            break;
                        case 3:
                            ChangeResolution(1280, 1024);
                            break;
                        case 4:
                            ChangeResolution(1366, 768);
                            break;
                        case 5:
                            ChangeResolution(1600, 900);
                            break;
                        case 6:
                            ChangeResolution(1680, 1050);
                            break;
                        case 7:
                            ChangeResolution(1920, 1080);
                            break;
                        case 8:
                            ChangeResolution(2560, 1440);
                            break;
                        case 9:
                            ChangeResolution(3840, 2160);
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 1:
                {
                    switch (PosX[currentPosY])
                    { 
                        case 0:
                            {
                                PlayerPrefs.SetInt("FullScreen", 0);
                                Screen.SetResolution(Screen.width, Screen.height, false);
                                settingsValues[currentPosY].text = "Windowed";
                            }
                            break;
                        case 1:
                            {
                                PlayerPrefs.SetInt("FullScreen", 1);
                                Screen.SetResolution(Screen.width, Screen.height, true);
                                settingsValues[currentPosY].text = "Fullscreen";
                            }
                            break;
                    }
                }
                break;
            case 2:
                {
                    switch (PosX[currentPosY])
                    {
                        case 0:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 0f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 1:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 1f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 2:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 2f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 3:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 3f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 4:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 4f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 5:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 5f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 6:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 6f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 7:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 7f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 8:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 8f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 9:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 9f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                        case 10:
                            {
                                PlayerPrefs.SetFloat("SoundVolume", 10f);
                                sounds.GetComponent<SoundController>().SetVolume(PlayerPrefs.GetFloat("SoundVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("SoundVolume").ToString();
                            }
                            break;
                    }
                }
                break;
            case 3:
                {
                    switch (PosX[currentPosY])
                    {
                        case 0:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 0f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 1:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 1f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 2:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 2f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 3:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 3f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 4:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 4f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 5:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 5f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 6:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 6f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 7:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 7f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 8:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 8f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 9:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 9f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                        case 10:
                            {
                                PlayerPrefs.SetFloat("MusicVolume", 10f);
                                music.GetComponent<MusicController>().SetVolume(PlayerPrefs.GetFloat("MusicVolume"));
                                settingsValues[currentPosY].text = PlayerPrefs.GetFloat("MusicVolume").ToString();
                            }
                            break;
                    }
                }
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
    }
    private void ChangeResolution(int resX, int resY)
    {
        PlayerPrefs.SetInt("ScreenResX", resX);
        PlayerPrefs.SetInt("ScreenResY", resY);
        if (PlayerPrefs.GetInt("FullScreen", 1) == 1) Screen.SetResolution(resX, resY, true);
        else Screen.SetResolution(resX, resY, false);
        settingsValues[currentPosY].text = resX.ToString() + " x " + resY.ToString();
    }
}
