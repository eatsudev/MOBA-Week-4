using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharChoose : MonoBehaviour
{
    public void Chara1Button()
    {
        SceneManager.LoadScene("Scene1");
        Time.timeScale = 1;
    }

    public void Chara2Button()
    {
        SceneManager.LoadScene("Scene2");
        Time.timeScale = 1;
    }
}
