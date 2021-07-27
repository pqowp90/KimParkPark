using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonManager : MonoBehaviour
{
    [Header("세팅")]
    [SerializeField]
    private Canvas settingCanvas = null;
    [SerializeField]
    private Canvas settingButtons = null;
    [Header("버튼")]
    [SerializeField]
    private Canvas buttonCanvas = null;
    [SerializeField]
    private Slider volumeSlider;

    private PlayerMove playerMove = null;

    private bool isSetting = false;

    private void Start(){
        playerMove = FindObjectOfType<PlayerMove>();
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
        AudioListener.pause = true;
        buttonCanvas.enabled = false;
        volumeSlider.interactable = true;
        Time.timeScale = 0f;
        playerMove.isPause = true;
    }
    public void OnClickSettingExit(){
        isSetting = false;
        settingCanvas.enabled = false;
        settingButtons.enabled = false;
        buttonCanvas.enabled = true;
        AudioListener.pause = false;
        Time.timeScale = 1f;
        playerMove.isPause = false;
        volumeSlider.interactable = false;
    }
}
