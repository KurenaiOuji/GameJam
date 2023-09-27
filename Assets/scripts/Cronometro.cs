using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public float Tiempo;
    [SerializeField] int Scene;
    [SerializeField] int MaxScore;
    Score score;

    void Start()
    {
        score = FindFirstObjectByType<Score>();
    }

    void Update()
    {
        cronometro();
    }

    public void cronometro()
    {
        Tiempo -= Time.deltaTime;
        if(Tiempo <= 0 && score.puntuacion <= MaxScore)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}