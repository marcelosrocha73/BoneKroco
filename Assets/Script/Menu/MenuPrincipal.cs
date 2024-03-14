using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    //[SerializeField] private string nomeDoLevelDeJogo;
    //[SerializeField] private GameObject painelMenuInicial;
    //[SerializeField] private GameObject painelOpcoes;

   public void Sair()
    {
        Application.Quit();
        Debug.Log("saiste do jogo");
    }

   public void Jogar()
    {
        SceneManager.LoadScene("AcaiCool");
    }
}
