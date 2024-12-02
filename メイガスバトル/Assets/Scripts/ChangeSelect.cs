using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSelect : MonoBehaviour
{
    public void OnClick() // ターンエンドボタンにつける処理
    {
        SceneManager.LoadScene("Select");
    }
}