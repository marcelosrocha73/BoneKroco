using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PosFase : MonoBehaviour
{
    // public string NomeFase;
    public float Tempoinic = 3.0f; //contagem do tempo
    //public GameObject Imagem; //colocar a camera
    public TextMeshProUGUI textMeshProUGUIAcai;
    public TextMeshProUGUI textMeshProUGUI; // mostra um texto
    //public Image Imagem1; //colocar uma imagem

        
    // Start is called before the first frame update

    void Start()
    {
        textMeshProUGUIAcai.text = "Parabéns, vamos tomar Açaí.";

    }

    // Update is called once per frame

    void Update()
    {
        
        if (Tempoinic > 0)
        {

            Tempoinic -= Time.deltaTime;
            textMeshProUGUI.text = Tempoinic.ToString("0");
        }

        else
        {

            textMeshProUGUI.text = "Iniciar Próxima Fase."; // cham texto pos termino da contagem
            //Imagem1.SetActive(true); // desativar a camera
            //SceneManager.LoadScene("AcaiCoolNv1"); //buscar a sena
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneManager.LoadScene(NomeFase);
        }

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
        //SceneManager.LoadScene(nome);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }


    /*public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }*/
}