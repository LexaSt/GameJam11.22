using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject WinImage;
    public GameObject FallImage;
    public BulletTime BulletTime;

    private void Start()
    {
       // BulletTime = FindObjectOfType<BulletTime>();
    }

    public void GameOverWin()
    {
        BulletTime.gameObject.SetActive(false);
        Time.timeScale = 0f;
        WinImage.SetActive(true);
    }

    public void GameOverFall()
    {
         BulletTime.gameObject.SetActive(false);
        Time.timeScale = 0f;
        FallImage.SetActive(true);
    }
}
