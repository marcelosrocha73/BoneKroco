using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gotas : MonoBehaviour
{
    public GameObject[] gotasPrefab;
    public float secondSpawn = 0.5f;
    public float minTrans;
    public float maxTrans;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GotaSpawn());
    }

    IEnumerator GotaSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(gotasPrefab[Random.Range(0, gotasPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
