using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Button[] buttons = null;
    [SerializeField]
    private Canvas settingCanvas = null;

    private bool isSetting = false;

    public void OnClickQuit(){
        Application.Quit();
    }
    public void OnClickSetting(){
        isSetting = true;

    }
}
