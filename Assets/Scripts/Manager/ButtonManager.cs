using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    [Header("세팅")]
    [SerializeField]
    private Canvas settingCanvas = null;
    [SerializeField]
    private Canvas settingButtons = null;

    [Header("타이틀")]
    [SerializeField]
    private Canvas titleCanvas = null;
    [SerializeField]
    private Canvas titleButton = null;

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
        if(isSetting)return;
        isSetting = true;
        settingCanvas.enabled = true;
        settingButtons.enabled = true;
        titleCanvas.enabled = false;
        titleButton.enabled = false;
    }
    public void OnClickStart(){
        SceneManager.LoadScene("Wasabe");
    }
    public void OnClickSettingExit(){
        isSetting = false;
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
        titleButton.enabled = true;
        titleCanvas.enabled = true;
    }
}
