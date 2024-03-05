using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    public float _groundTime;
    //private TargetJoint2D _target;
    //private BoxCollider2D _boxColl;
    // Start is called before the first frame update
    void Start()
    {
        //_target = GetComponent<TargetJoint2D>();
        //_boxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Invoke("GroundDsty", _groundTime);
        }
    }

    //void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if (collider.gameObject.tag == "gota")
    //    {
    //
    //      Destroy(gameObject);
    //    }
    //}

    //void GroudDsty()
    //{
    //    _target.enabled = false;
    //    _boxColl.isTrigger = true;
    //}

    
}
