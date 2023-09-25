using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    Score score;
    
    void Start()
    {
        score = FindFirstObjectByType<Score>();
    }

    public void LoadScene()
    {
        if (score.puntuacion >= 150)
        {
            SceneManager.LoadScene("lv2", LoadSceneMode.Additive);
        }
    }
}
