using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOrganization : MonoBehaviour
{
    public void OnClick() // �{�^���ɂ��鏈��
    {
        SceneManager.LoadScene("OrganizingDeckSelection");
    }
}