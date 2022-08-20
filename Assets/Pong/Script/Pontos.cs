using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public int pontos;
    public TextMeshPro placar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pontos += 1;
        placar.SetText(pontos.ToString("00"));
    }
}
