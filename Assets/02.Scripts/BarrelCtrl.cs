using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl : MonoBehaviour
{
    public GameObject expEffect;
    private int hitCount = 0;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("BULLET"))
        {
            //hitCount = hitCount + 1;
            if (++hitCount == 3)
            {
                //드럼통 폭발효과
                ExpBarrel();
            }
        }
    }

    void ExpBarrel()
    {
        Rigidbody rb = this.gameObject.AddComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 1800.0f);
        Destroy(this.gameObject, 2.0f);        
    }
}
