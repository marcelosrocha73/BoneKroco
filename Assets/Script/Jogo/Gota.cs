using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gota : MonoBehaviour
{
    //private SpriteRenderer _sprd;
    //private CapsuleCollider2D _cpsl;
    Rigidbody2D _rgb;
    Transform _gota;
    public int _pontos;
    
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
      if (collider.gameObject.tag == "Player")
      {
             //_sprd.enabled = false;
             //_cpsl.enabled = false;
            //PontosGotas.instance._totalPontos += _pontos;
            //PontosGotas.instance.UpdatePontoText();
            Destroy(gameObject);
      }

      if (collider.gameObject.tag == "ground")
      {
            //Debug.Log("levou o farelo");
            Destroy(gameObject);
      }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            PontosGotas.instance.ShowGameOver();
            Destroy(gameObject);
        }
        
   //     if (collision.gameObject.tag == "ground")
   //     {
   //         Debug.Log("levou o farelo");
   //     }
   //             
    }

    //void Resetar()
    //{
    //    transform.localposition = new Vector3(0, 0, 0);
    //    _rgb.velocity = Vector3.zero;
    //    Invoke("Resetar", 1);
    //}
}