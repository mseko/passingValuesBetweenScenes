using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSceneController : MonoBehaviour
{
    private int count;
    public int Count
    {
        set { this.count = value;}
        get { return this.count;}
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 100, 30), "2�Ԗڂ̃V�[��");
        GUI.Label(new Rect(50, 150, 300, 30), "�ŏ��̃V�[����������p�����J�E���g" + count);
    }
}
