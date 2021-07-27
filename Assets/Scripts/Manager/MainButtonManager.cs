using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    [Header("¼¼ÆÃ")]
    [SerializeField]
    private Canvas settingCanvas = null;
    [SerializeField]
    private Canvas settingButtons = null;

    private bool isSetting = false;

    private void Start(){
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
    }
    public void OnClickQuit(){
        if(isSetting)return;
        Application.Quit();
    }
    public void OnClickSettingQuit(){
        Application.Quit();
    }
    public void OnClickSetting(){
        isSetting = true;
        settingCanvas.enabled = true;
        settingButtons.enabled = true;
    }
    public void OnClickSettingExit(){
        isSetting = false;
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
    }
}
