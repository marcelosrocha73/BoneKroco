using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _nome;
    [SerializeField] private int _tipo;
    [SerializeField] private int _valor;
    [SerializeField] MeshRenderer _textura; //textura
    [SerializeField] GameObject _partSaida; //ativar e desativar particula
    //private SpriteRenderer _sprd;
    //private CapsuleCollider2D _cpsl;
    [SerializeField] public float _objetoTime;
    [SerializeField] private TargetJoint2D _target;
    [SerializeField] private BoxCollider2D _boxColl;

    public void Start()
    {
        _target = GetComponent<TargetJoint2D>();
        _boxColl = GetComponent<BoxCollider2D>();
        //_sprd = GetComponent<SpriteRenderer>();
        // _cpsl = GetComponent<CapsuleCollider2D>();
        //_textura = GetComponent<MeshRenderer>(); //chama a textura
    }

    public virtual void DestroyItem()
    {

    }

    protected virtual void ConstroiItem()
    {

    }

    //pesquisar get set C#
    public virtual string Nome
    {
        get { return _nome; } //get - puxar
        set { _nome = value; } //set - enviar
    }
    public virtual int Tipo
    {
        get { return _tipo; } //get
        set { _tipo = value; } //set
    }
    public virtual int Valor
    {
        get { return _valor; } //get
        set { _valor = value; } //set
    }
    public virtual MeshRenderer Textura
    {
        get { return _textura; } //get
        set { _textura = value; } //set
    }
    public virtual GameObject PartSaida
    {
        get { return _partSaida; } //get
        set { _partSaida = value; } //set
    }
}