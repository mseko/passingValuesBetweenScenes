using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneController : MonoBehaviour
{
    private int count= 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 100, 30), "最初のシーン");
        GUI.Label(new Rect(50, 150, 200, 30), "カウント" + count);

        if (GUI.Button(new Rect(50, 200, 200, 30), "カウントするボタン"))
        {
            count++;
        }

        if (GUI.Button(new Rect(50, 250, 200, 30), "遷移するボタン"))
        {
            SceneManager.sceneLoaded += GameSceneLoaded;
            SceneManager.LoadScene("SecondScene");
        }
    }

    private void GameSceneLoaded(Scene next, LoadSceneMode mode)
    {
        var gameManager = GameObject.FindWithTag("Controller").GetComponent<SecondSceneController>();
        gameManager.Count = count;
        SceneManager.sceneLoaded -= GameSceneLoaded;
    }
}
