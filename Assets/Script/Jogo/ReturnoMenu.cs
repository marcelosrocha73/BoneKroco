using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ReturnoMenu : MonoBehaviour
{
    //public int _totalPontos;
    //public TextMeshProUGUI pontosText;

    //public GameObject menuPrincipal;

    //public static ReturnoMenu instance;

    // Start is called before the first frame update
    void Start()
    {
        //instance = this;
    }

    /*public void UpdatePontoText()
    {
        pontosText.text = _totalPontos.ToString();
    }*/

    /*public void ShowMenuPrincipal()
    {
       menuPrincipal = tag == menuPrincipal;
    }*/

    /*public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }*/

    public void Sair()
    {
        Application.Quit();
        Debug.Log("saiste do jogo");
        SceneManager.LoadScene("Menu");
    }
}
