using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManeger : MonoBehaviour
{
    public void EnterScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
