using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSelect : MonoBehaviour
{
    public void OnClick() // �{�^���ɂ��鏈��
    {
        SceneManager.LoadScene("Select");
    }
}