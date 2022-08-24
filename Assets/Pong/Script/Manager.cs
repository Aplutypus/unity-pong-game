using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Pontos p1;
    public Pontos p2;
    public int pointsToWin = 0;
    public GameOverScreen panel;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (p1.pontos >= pointsToWin)
        {
            panel.SetGameOverScreen(p1.pontos, p2.pontos, "1");
        }
        if (p2.pontos >= pointsToWin)
        {
            panel.SetGameOverScreen(p1.pontos, p2.pontos, "2");
        }
    }
}
