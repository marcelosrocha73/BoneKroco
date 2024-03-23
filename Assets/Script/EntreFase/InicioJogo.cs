using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class InicioJogo : MonoBehaviour
{
    public float Tempoinic = 3.0f; //contagem do tempo
    //public GameObject Imagem; //colocar a camera
    public TextMeshProUGUI textMeshProUGUI; // mostra um texto
    //public Image Imagem1; //colocar uma imagem

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tempoinic >0)
        {
            Tempoinic -= Time.deltaTime;
            textMeshProUGUI.text = Tempoinic.ToString("0");
        }
        else
        {
            textMeshProUGUI.text = "Iniciar Jogo"; // cham texto pos termino da contagem
            //Imagem.SetActive(false); // desativar a camera
            SceneManager.LoadScene("AcaiCoolNv1"); //buscar a sena
        }

    }
}
