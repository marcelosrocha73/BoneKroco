using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class ItemControl : MonoBehaviour
{
    [SerializeField] int _numberGota;
    [SerializeField] int _numberObjeto;
    [SerializeField] List<Transform> _posGota;
    [SerializeField] List<Transform> _posObjeto;

    private void Start()
    {
        Invoke("ItemOn", 1);
    }

    void ItemOn()
    {
        Shuffle(_posGota);
        for (int i = 0; i < 5; i++)
        {
            GotaOn(i);
        }

        Shuffle(_posObjeto);
        for (int i = 0; i < 3; i++)
        {
            ObjetoOn(i);
        }
    }

    void GotaOn(int value)
    {
        GameObject bullet = GotaPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = _posGota[value].transform.position;
            //bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }

    void ObjetoOn(int value)
    {
        GameObject bullet = ObjetoPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = _posObjeto[value].transform.position;
            //bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }

    public void Shuffle(List<Transform> lists)
    {
        for (int j = lists.Count - 1; j > 0; j--)
        {
            int rnd = UnityEngine.Random.Range(0, j + 1);
            Transform temp = lists[j];
            lists[j] = lists[rnd];
            lists[rnd] = temp;
        }
    }
}
