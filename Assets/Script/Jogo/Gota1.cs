using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gota1 : MonoBehaviour
{
    [SerializeField] Rigidbody2D rig2;

    [SerializeField] int Value;

    [SerializeField] int Value1;

    [SerializeField] Transform[] _transform;

    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    [SerializeField] TextMeshProUGUI textMeshProUGUIVida;

    [SerializeField] int Pontos;
    [SerializeField] int Vida;
    public GameObject gameOver;

    private void Start()
    {
        Value = Random.Range(3, 6); //pontos
        Invoke("TimeG", Value);
        textMeshProUGUIVida.text = "" + Vida;
        rig2.isKinematic = true;
        Invoke("gotatime", 3);
    }

    void TimeG()
    {
        Value1 = Random.Range(0, _transform.Length); //maquinas
        transform.localPosition = _transform[Value1].position;
      
        rig2.isKinematic = false;
        rig2.velocity = Vector2.zero;
      //  GetComponent<SpriteRenderer>().enabled = true;
        // Invoke("TimeG", Value);
    }

   
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "ground") //perdeu vida
        {
            Value = Random.Range(3, 6);
            Vida--;
            if (Vida == 0) 
            {
                PontosGotas.instance.ShowGameOver(); //ativa painel de gameover
            }
            //Debug.Log("levou o farelo");
        //    Destroy(gameObject);

            textMeshProUGUIVida.text = "" + Vida;

            Invoke("TimeG", Value);
        }

        if (collision.gameObject.tag == "Cuia") //pontuar
        { 
            Pontos++;
            textMeshProUGUI.text = "" + Pontos;
            rig2.isKinematic = true;
            rig2.velocity = Vector2.zero;
            //   GetComponent<SpriteRenderer>().enabled = false;
            //Destroy(gameObject);

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


