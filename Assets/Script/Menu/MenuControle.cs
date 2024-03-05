using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControle : MonoBehaviour
{
    [SerializeField] List<Transform> _itenMenu;
    // Start is called before the first frame update
   
    public void MenuOFF()
    {
        for (int i = 0; i < _itenMenu.Count; i++)
        {
            _itenMenu[i].localScale = Vector3.zero;
        }
    }
    public void ChamarMenu() {
        _itenMenu[0].GetComponent<Button>().Select();
        StartCoroutine(TimeItens());
    }

    IEnumerator TimeItens()
    {
        for (int i = 0; i < _itenMenu.Count; i++)
        {
            yield return new WaitForSeconds(.25f);
            _itenMenu[i].DOScale(1.5f, 0.25F);
            yield return new WaitForSeconds(.25f);
            _itenMenu[i].DOScale(1f, 0.25F);
        }
    }
}
