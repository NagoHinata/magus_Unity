using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTitle : MonoBehaviour
{
    public void OnClick() // ターンエンドボタンにつける処理
    {
        SceneManager.LoadScene("Title");
    }
}