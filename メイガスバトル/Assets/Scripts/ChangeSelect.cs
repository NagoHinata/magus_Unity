using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSelect : MonoBehaviour
{
    public void OnClick() // �^�[���G���h�{�^���ɂ��鏈��
    {
        SceneManager.LoadScene("Select");
    }
}