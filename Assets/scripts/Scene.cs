using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    Score score;
    [SerializeField] int ScoreMax;
    
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
