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

        //��ʑJ�ڂ��Ă��I�u�W�F�N�g�����Ȃ��悤�ɂ���
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ButtonClick()
    {
        button_AudioSource.PlayOneShot(button_AudioSource.clip);

        //���y��炷
        audioSource.PlayOneShot(audioSource.clip);

        //��n�߂����Ƃ�\��
        Debug.Log("�J�n");
        
        

    }



}