using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ProximaFase : MonoBehaviour
{
    [SerializeField] private string nomeProximaFase;
    [SerializeField] int Pontos;
    [SerializeField] Rigidbody2D rig2; //queda da gota
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    private void OntriggerEnter2D(Collider2D collision)
    {
        IrProximaFase();

        if (collision.gameObject.tag == "Cuia") //pontuar
        {
            Pontos++;
            textMeshProUGUI.text = "" + Pontos * 10;

            rig2.isKinematic = true; // capitura da gota na cuia
            rig2.velocity = Vector2.zero;
        }

            if (Pontos == 50)
        {
            Debug.Log("va tomar seu açai");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
private void IrProximaFase()
    {
        SceneManager.LoadScene(this.nomeProximaFase);
    }
}
