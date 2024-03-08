using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuDino : MonoBehaviour
{
    [SerializeField] private GameObject dino;
    //[SerializeField] private sceneManeger sceneManeger;
    private bool isone = false;

    public void Next()
    {
        if (isone)
        {
            SceneManager.LoadScene(1);
            return;
        }
        dino.SetActive(true);
        isone = true;        
    }
}
