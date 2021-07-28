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
    [Header("버튼")]
    [SerializeField]
    private Canvas buttonCanvas = null;

    private bool isSetting = false , isEsc = true;

    private void Start(){
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
    }
    private void Update(){
        OnClickEsc();
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
        buttonCanvas.enabled = false;
        titleCanvas.enabled = false;
        titleButton.enabled = false;
        AudioListener.pause =true;
        isEsc=false;
    }
    public void OnClickStart(){
        SceneManager.LoadScene("Wasabe");
    }
    public void OnClickSettingExit(){
        isSetting = false;
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
        buttonCanvas.enabled = true;
        titleButton.enabled = true;
        titleCanvas.enabled = true;
        AudioListener.pause =false;
        isEsc=true;
    }
    private void OnClickEsc(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isEsc){
                OnClickSetting();
            }
            else{
                OnClickSettingExit();
            }
        }
    }
}
