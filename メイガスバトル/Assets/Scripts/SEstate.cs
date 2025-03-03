using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SEstate : MonoBehaviour
{
    private AudioSource button_AudioSource;
    [SerializeField] AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        button_AudioSource = GetComponent<AudioSource>();

        //画面遷移してもオブジェクトが壊れないようにする
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ButtonClick()
    {
        button_AudioSource.PlayOneShot(button_AudioSource.clip);

        //音楽を鳴らす
        audioSource.PlayOneShot(audioSource.clip);

        //鳴り始めたことを表示
        Debug.Log("開始");
        
        

    }



}