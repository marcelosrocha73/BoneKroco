using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gota : MonoBehaviour
{
    //private SpriteRenderer _sprd;
    //private CapsuleCollider2D _cpsl;
    Rigidbody2D _rgb;
    public Transform _gota;
    public int _pontos;
    public GameObject prefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;


    void Start()
    {
        //Vector3 position = new Vector3(Random.Range(-0.0f, 0.0f), 0.0f, Random.Range(-0.0f, 0.0f));
        //Instantiate(prefab, position, Quaternion.identity);
        //GameObject instancia = Instantiate(prefab); 
        //instancia.transform.position = new Vector3(Random.Range(-0.0f, 0.0f), 0.0f, Random.Range(-0.0f, 0.0f));        //SceneManager.LoadScene(Random.Range(0, SceneManager.sceneCount));
        StartCoroutine(GotaSpawn());
    }

    IEnumerator GotaSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(prefab[Random.Range(0, prefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(prefab, 1f);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(_gota, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
      if (collider.gameObject.tag == "Player")
      {
             //_sprd.enabled = false;
             //_cpsl.enabled = false;
            PontosGotas.instance._totalPontos += _pontos;
            PontosGotas.instance.UpdatePontoText();
            Destroy(gameObject);
      }

      if (collider.gameObject.tag == "ground")
      {
            Debug.Log("levou o farelo");
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
    }


   // void Resetar()
    //{
    //    transform.localposition = new Vector3(0, 0, 0);
    //    _rgb.velocity = Vector3.zero;
    //    Invoke("Resetar", 1);
    //}
}