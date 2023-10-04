using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public int Lv;
    Score score;
    public int ScoreMax;
    
    void Start()
    {
        score = FindFirstObjectByType<Score>();
    }

    private void Update()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        if (score.puntuacion >= ScoreMax)
        {
            SceneManager.LoadScene(Lv);
        }
    }
}
