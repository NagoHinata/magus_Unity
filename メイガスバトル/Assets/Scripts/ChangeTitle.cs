using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTitle : MonoBehaviour
{
    public void OnClick() // �^�[���G���h�{�^���ɂ��鏈��
    {
        SceneManager.LoadScene("Title");
    }
}