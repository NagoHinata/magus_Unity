using UnityEngine;
using UnityEngine.SceneManagement;


public class change: MonoBehaviour
{
    public void OnClick() // ボタンにつける処理
    {
        SceneManager.LoadScene("DeckOrganizaition");
    }

}
