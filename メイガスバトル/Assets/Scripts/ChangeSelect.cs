using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSelect : MonoBehaviour
{
    public void OnClick() // ボタンにつける処理
    {
        SceneManager.LoadScene("Select");
    }
}