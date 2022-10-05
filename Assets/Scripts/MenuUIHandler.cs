using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public static MenuUIHandler Instance;
    public TMP_InputField inputField;
    public string input;
    public Text bestScore;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
        ScoreData data = SaveSystem.LoadScore();
    }
 


   public void SetPlayerName()
    {
       input = inputField.text;
       
    }
public void StartNew()
    {
        SceneManager.LoadScene(1);

    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}