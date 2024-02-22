using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : Item
{
    // Start is called before the first frame update
    void DestroyItem()
    {
        StartCoroutine(DestruirTime());
    }
    IEnumerator DestruirTime()
    {
        Textura.enabled = false;
        PartSaida.SetActive(true);
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }

}
