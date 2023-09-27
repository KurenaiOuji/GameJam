using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int puntuacion;
    Cronometro cronometro;
    [SerializeField] TextMeshProUGUI Cronometro;
    [SerializeField] TextMeshProUGUI TextPro;

    private void Start()
    {
        cronometro = FindAnyObjectByType<Cronometro>();
    }
    void Update()
    {
        TextPro.text = puntuacion.ToString();
        Cronometro.text = cronometro.Tiempo.ToString();
    }
}