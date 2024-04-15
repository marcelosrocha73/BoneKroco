using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NovaFase : MonoBehaviour
{
    public string novaFase;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadScene(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /*public void calllevels()
    {
        SceneManager.LoadScene(GetInt("AcaiCoolNv") + 1);
    }*/

    public void Iniciar()
    {
        SceneManager.LoadScene(novaFase);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }


    /*public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }*/
}
