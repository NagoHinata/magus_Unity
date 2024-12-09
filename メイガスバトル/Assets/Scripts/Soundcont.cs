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
            // ���̃I�u�W�F�N�g���V���O���g���̃C���X�^���X�Ƃ��Đݒ肳���
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ���ɃC���X�^���X�����݂���ꍇ�A���̃I�u�W�F�N�g��j��
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //�A�^�b�`����Ă���AudioSource�擾
        AudioSource audio = GetComponent<AudioSource>();
        volume = audio.volume;
        float currentValue = scrollbar.value;
        scrollbar.value = audio.volume;
        Debug.Log("Scrollbar�̌��݂̒l: " + currentValue);

    }

    public void OnChangeVolume()
    {
        Debug.Log("���ʕύX");
        float currentValue = scrollbar.value;
        Debug.Log("Scrollbar�̌��݂̒l: " + currentValue);
        AudioSource audio = GetComponent<AudioSource>();
        audio.volume = currentValue;
        
    }

}
