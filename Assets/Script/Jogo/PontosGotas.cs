using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PontosGotas : MonoBehaviour
{
    public int totalPontos;
    public Text pontosText;

    public GameObject gameOver;
    
    public static PontosGotas instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdatePontoText()
    {
      pontosText.text = totalPontos.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}