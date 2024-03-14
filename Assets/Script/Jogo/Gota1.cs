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

    }

    void TimeG()
    {
        Value1 = Random.Range(0, 6); //maquinas
        transform.position = _transform[Value1].localPosition;
      
        rig2.isKinematic = false;
        rig2.velocity = Vector2.zero;
        GetComponent<SpriteRenderer>().enabled = true;
        // Invoke("TimeG", Value);
    }

   
    private void OnTriggerEnter2D(Collider2D collision) //potuou
    {
        if (collision.gameObject.tag == "ground")
        {
            Value = Random.Range(3, 6);
            Vida--;
            if (Vida == 2) 
            {
                PontosGotas.instance.ShowGameOver(); //ativa painel de gameover
            }
            //Debug.Log("levou o farelo");
            Destroy(gameObject);

            textMeshProUGUIVida.text = "" + Vida;

            Invoke("TimeG", Value);
        }

        if (collision.gameObject.tag == "Cuia")
        { 
            Pontos++;
            textMeshProUGUI.text = "" + Pontos;
            rig2.isKinematic = true;
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
        }
    }
    
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
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


