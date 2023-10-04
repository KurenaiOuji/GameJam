using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int puntuacion;
    Cronometro cronometro;
    Scene scene;
    [SerializeField] TextMeshProUGUI Cronometro;
    [SerializeField] TextMeshProUGUI TextPro;
    [SerializeField] TextMeshProUGUI ScoreMax;

    private void Start()
    {
        puntuacion = 0;
        cronometro = FindAnyObjectByType<Cronometro>();
        scene = FindAnyObjectByType<Scene>();
    }
    void Update()
    {
        TextPro.text = puntuacion.ToString();
        Cronometro.text = cronometro.Tiempo.ToString();
        ScoreMax.text = scene.ScoreMax.ToString();
    }
}