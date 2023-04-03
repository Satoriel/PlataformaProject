using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
             Instance = this;
             DontDestroyOnLoad(transform);
        }
           
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    private void Start()
    {
        LoadScene("Main Menu");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
