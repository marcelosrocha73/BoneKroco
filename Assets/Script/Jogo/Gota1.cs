using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gota1 : MonoBehaviour
{
    [SerializeField] Rigidbody2D rig2; //queda da gota

    [SerializeField] int Value; // vida

    [SerializeField] int Value1; // gota

    [SerializeField] Transform[] _transform; //posicao da queda das gotas

    [SerializeField] TextMeshProUGUI textMeshProUGUI; //pontos

    [SerializeField] TextMeshProUGUI textMeshProUGUIVida; //vida

    [SerializeField] int Pontos;
    [SerializeField] int Vida;
    public GameObject gameOver;
    public GameObject novaFase;
    
    private void Start()
    {
        Value = Random.Range(0, 3); //vida
        Invoke("TimeG", Value);
        textMeshProUGUIVida.text = "" + Vida;
        rig2.isKinematic = true;
        Invoke("gotatime", 3); //tempo para iniciar a queda da gota
    }

    void TimeG()
    {
        Value1 = Random.Range(0, _transform.Length); //maquinas
        transform.localPosition = _transform[Value1].position;
      
        rig2.isKinematic = false;
        rig2.velocity = Vector2.zero;
      
    }

   
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "ground") //perdeu vida
        {
            Value = Random.Range(0, 3);
            Vida--;
            if (Vida == 0) 
            {
                PontosGotas.instance.ShowGameOver(); //ativa painel de gameover
             
            }
            
            textMeshProUGUIVida.text = "" + Vida;

            Invoke("TimeG", Value);
        }

        if (collision.gameObject.tag == "Cuia") //pontuar
        { 
            Pontos = Pontos + 10; // soma pontos de 10 em 10
            textMeshProUGUI.text = "" + Pontos;

            rig2.isKinematic = true; // capitura da gota na cuia
            rig2.velocity = Vector2.zero;


            if (collision.gameObject.tag == "Cuia") //passar de fase
            {
                if (Pontos == 20)
                {
                    //Debug.Log("va tomar seu açai");
                    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    PontosGotas.instance.ShowNovaFase();
                    //SceneManager.LoadScene("PosFases");
                    
                }
            }

                Invoke("TimeG", Value);
        }

    }
    
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void gotatime()
    {
        rig2.isKinematic = false;
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "groundestroy")
        {
            //Debug.Log("levou o farelo");
            //PontosGotas.instance.ShowGameOver();
            Destroy(gameObject);
            
        }
    }*/
}


