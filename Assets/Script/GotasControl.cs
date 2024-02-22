using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotasControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChamarGotas()
    {
        GameObject bullet = GotasPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            //bullet.transform.position = turret.transform.position;
            //bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }
}
