using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // (參數1，參數2，...，參數N)
    // 類型 名稱
    public void NextLevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
