using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPonto : MonoBehaviour
{
    [SerializeField] int _pontos;

    public void SomarPontos(int value)
    {
        _pontos += value;
    }
    
}
