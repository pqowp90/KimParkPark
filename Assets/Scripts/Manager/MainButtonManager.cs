using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonManager : MonoBehaviour
{
    [Header("����")]
    [SerializeField]
    private Canvas settingCanvas = null;
    [SerializeField]
    private Canvas settingButtons = null;
    [Header("��ư")]
    [SerializeField]
    private Canvas buttonCanvas = null;

    private PlayerMove playerMove = null;

    private bool isSetting = false, isEsc =  true;

    private void Start(){
        playerMove = FindObjectOfType<PlayerMove>();
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
        AudioListener.pause = true;
        buttonCanvas.enabled = false;
        Time.timeScale = 0f;
        playerMove.isPause = true;
        isEsc = false;
    }
    public void OnClickSettingExit(){
        isSetting = false;
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
        buttonCanvas.enabled = true;
        AudioListener.pause = false;
        Time.timeScale = 1f;
        playerMove.isPause = false;
        isEsc = true;
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
