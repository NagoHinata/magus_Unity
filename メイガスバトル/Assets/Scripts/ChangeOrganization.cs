using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOrganization : MonoBehaviour
{
    public void OnClick() // �^�[���G���h�{�^���ɂ��鏈��
    {
        SceneManager.LoadScene("DeckOrganization");
    }
}