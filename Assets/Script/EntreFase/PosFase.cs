using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PosFase : MonoBehaviour
{
    // public string NomeFase;
    //public GameObject Imagem; //colocar a camera
    //public Image Imagem1; //colocar uma imagem
    public float Tempoinic = 3.0f; //contagem do tempo
    public TextMeshProUGUI textMeshProUGUIAcai;
    public TextMeshProUGUI textMeshProUGUI; // mostra um texto
    

        
    // Start is called before the first frame update

    void Start()
    {
        textMeshProUGUIAcai.text = "Parab�ns, vamos tomar A�a�.";

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

            textMeshProUGUI.text = "Iniciar Pr�xima Fase."; // cham texto pos termino da contagem
            //Imagem1.SetActive(true); // desativar a camera
            //SceneManager.LoadScene("AcaiCoolNv1"); //buscar a sena
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneManager.LoadScene(NomeFase);
        }

    }
    
}