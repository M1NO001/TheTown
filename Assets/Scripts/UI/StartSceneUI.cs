using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneUI : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(ChangeScene);
    }


    void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
