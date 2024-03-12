using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gota : MonoBehaviour
{
    //(0)
    //private SpriteRenderer _sprd;
    //private CapsuleCollider2D _cpsl;
    Rigidbody2D _rgb;
    public Transform _gota;
    public int _pontos;
    public GameObject prefab;

    //(1) www.youtube.com/watch?v=E7gmylDS1C4
    //public GameObject objetoPrefab;
    //public float respawnTime = 1.0f;
    //private Vector2 screenBounds;

    //(2) www.youtube.com/watch?v=j6p5Nh7JvmY
    //public GameObject[] gotasPrefab;
    //public float secondSpawn = 0.5f;
    //public float minTrans;
    //public float maxTrans;


    void Start()
    {
        //(1)
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(objetoWave());

        //Vector3 position = new Vector3(Random.Range(-0.0f, 0.0f), 0.0f, Random.Range(-0.0f, 0.0f));
        //Instantiate(prefab, position, Quaternion.identity);
        //GameObject instancia = Instantiate(prefab); 
        //instancia.transform.position = new Vector3(Random.Range(-0.0f, 0.0f), 0.0f, Random.Range(-0.0f, 0.0f));        //SceneManager.LoadScene(Random.Range(0, SceneManager.sceneCount));
        
        //(2)
        //StartCoroutine(GotaSpawn()); //trava o jogo

    }

    /*(1)
    private void spawnEnemy()
    {
        GameObject a = Instantiate(objetoPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator objetoWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
            Destroy(gameObject, 5f);
        }
    }*/

    /*(2)
    IEnumerator GotaSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(gotasPrefab[Random.Range(0, gotasPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
    */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(_gota, transform.position, Quaternion.identity);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            PontosGotas.instance.ShowGameOver();
            Destroy(gameObject);
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

    


    //void Resetar()
    //{
    //   transform.position = new Vector3(0, 0, 0);
    //   _rgb.velocity = Vector3.zero;
     //  Invoke("Resetar", 1);
    //}
}