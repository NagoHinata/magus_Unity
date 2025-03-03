/*
 * Soundcont
 * 
 * 鈴木
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Soundcont : MonoBehaviour
{
    private static Soundcont instance;
    public float volume;
    public Scrollbar scrollbar;


    private void Awake()
    {
        if (instance == null)
        {
            // このオブジェクトがシングルトンのインスタンスとして設定される
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既にインスタンスが存在する場合、このオブジェクトを破棄
            Destroy(gameObject);
        }

        //オブジェクトを探して取得する、スクロールバーを探して取得したい。
        /*
        GameObject target1 = GameObject.Find("Canvas");
        GameObject target2 = target1.transform.Find("Panel");
        scrollbar = target2.scrollbar.Find("scrollbar");
        */

    }

    void Start()
    {

        DontDestroyOnLoad(gameObject);
        //アタッチされているAudioSource取得
        AudioSource audio = GetComponent<AudioSource>();
        volume = audio.volume;
        float currentValue = scrollbar.value;
        scrollbar.value = audio.volume;
        Debug.Log("Scrollbarの現在の値: " + currentValue);


    }

    //サウンドをスクロールバーで変更するためのプログラム
    public void OnChangeVolume()
    {
        Debug.Log("音量変更");
        float currentValue = scrollbar.value;
        Debug.Log("Scrollbarの現在の値: " + currentValue);
        AudioSource audio = GetComponent<AudioSource>();
        audio.volume = currentValue;

    }

}
