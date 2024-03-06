using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public float _objetoTime;
    private TargetJoint2D _target;
    private BoxCollider2D _boxColl;

    //movimento do objeto por tempo
    public float _speed;
    //public float _moveTime;
    //private bool dirRight = true;
    //private float _timer;

    //movimento de objeto por distancia
    private Rigidbody2D _rgb;
    //public Transform _rightCol;
   //public Transform _leftCol;
    //public Transform _headPoint;
   // private bool colliding;
   // public LayerMask _layer;


    void Start ()
    {
        _rgb = GetComponent<Rigidbody2D>();
        _target = GetComponent<TargetJoint2D>();
        _boxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          //float height = collision.contacts[0].point.y - _headPoint.position.y;
           Invoke("Objetotrg", _objetoTime);
          // if(height > 0)
          // {
          //   collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 3, ForceMode2D.Impulse);
          // }
        }
    }

    void Update()
    // movimento de objeto para os lados
    {
        _rgb.velocity = new Vector2(_speed, _rgb.velocity.y);
        //colliding = Physics2D.Linecast(_rightCol.position, _leftCol.position, _layer);

       // if(colliding)
        //{
        //    transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
        //    _speed = -_speed;
        //}
    }
        //movimento de personagem por tempo
    //{
    //    if(dirRight)
    //    {
            // objeto anda para dirreita se dirRight verdadeiro
    //        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    //    }
    //    else
    //    {
            // objeto anda para esquerda se dirRight falso
    //        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    //    }

    //    _timer += Time.deltaTime;

    //    if(_timer >= _moveTime)
    //    {
    //        dirRight = !dirRight;
    //        _timer = 0f;
    //    }
    //}

    void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.gameObject.tag == "Objt")
       {
           Destroy(gameObject);
       }

       if (collider.gameObject.tag == "ground")
       {
            //Debug.Log("levou o farelo");
           Destroy(gameObject);
       }
    }

    void Objetotrg()
    {
        _target.enabled = false;
        _boxColl.isTrigger = true;
    }

    //public override void DestroyItem()
    //{
    //    StartCoroutine(DestruirTime());
    //}
    //IEnumerator DestruirTime()
    //{
    //    Textura.enabled = false;
    //    PartSaida.SetActive(true);
    //   yield return new WaitForSeconds(3f);
    //   gameObject.SetActive(false);
    //}
}
