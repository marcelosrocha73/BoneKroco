using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] List<MenuControle> _menuControle;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _menuControle.Count; i++)
        {
            _menuControle[i].transform.localScale = Vector3.zero;
            _menuControle[i].gameObject.SetActive(false);
        }
        _menuControle[0].gameObject.SetActive(true);
        _menuControle[0].MenuOFF();
        _menuControle[0].transform.DOScale(1, 0.25f);
        _menuControle[0].ChamarMenu();
    }
    public void ChamarMenuControle(int value)
    {
        for (int i = 0; i < _menuControle.Count; i++)
        {
            _menuControle[i].transform.localScale = Vector3.zero;
            _menuControle[i].MenuOFF();
            _menuControle[i].gameObject.SetActive(false);
        }
        _menuControle[value].gameObject.SetActive(true);
        _menuControle[value].transform.DOScale(1, .25f);
        _menuControle[value].ChamarMenu();
    }
}