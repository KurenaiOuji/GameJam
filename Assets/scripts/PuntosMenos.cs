using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuntosMenos : MonoBehaviour
{
    public int valor = -1;
    public GameManager gameManager;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            GameManager.instance.IncreaseScore(1);
            Destroy(this.gameObject);
    }
}
