using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOrganization : MonoBehaviour
{
    public void OnClick() // ボタンにつける処理
    {
        SceneManager.LoadScene("OrganizingDeckSelection");
    }
}