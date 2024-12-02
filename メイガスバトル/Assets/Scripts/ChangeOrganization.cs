using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOrganization : MonoBehaviour
{
    public void OnClick() // ターンエンドボタンにつける処理
    {
        SceneManager.LoadScene("DeckOrganization");
    }
}