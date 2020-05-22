using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    

    public void Scene2()
    {
        SceneManager.LoadScene("Bridge scene");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Scene3");
    }

}
