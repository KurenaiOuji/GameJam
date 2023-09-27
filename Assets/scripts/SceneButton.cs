using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneButton : MonoBehaviour
{
    private void Update()
    {
        
    }
    public void SceneName(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
