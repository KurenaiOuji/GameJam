using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int puntuacion;
    [SerializeField] TextMeshProUGUI TextPro;
    void Update()
    {
        TextPro.text = puntuacion.ToString();
    }
}