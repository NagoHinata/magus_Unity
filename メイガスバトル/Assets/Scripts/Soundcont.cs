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

    public void OnChangeVolume()
    {
        Debug.Log("音量変更");
        float currentValue = scrollbar.value;
        Debug.Log("Scrollbarの現在の値: " + currentValue);
        AudioSource audio = GetComponent<AudioSource>();
        audio.volume = currentValue;
        
    }

}
