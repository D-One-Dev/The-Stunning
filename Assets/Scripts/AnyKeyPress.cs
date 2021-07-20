using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyKeyPress : MonoBehaviour
{
    [SerializeField] private GameObject sceneManager;
    private PlayerInput pi;
    private void Awake()
    {
        pi = new PlayerInput();
        pi.Menu.AnyKey.performed += context => AnyKey();
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
    }
    void Update()
    {
    }
    private void AnyKey()
    {
        sceneManager.GetComponent<SceneChanger>().LoadScene("Menu");
    }
}
