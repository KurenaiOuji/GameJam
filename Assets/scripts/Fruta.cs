using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fruta : MonoBehaviour
{
    public int valor;
    Score score;

    void Start()
    {
        score = FindFirstObjectByType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score.puntuacion += valor;
            Destroy(this.gameObject);
        }
    }
}