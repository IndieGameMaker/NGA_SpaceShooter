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
            if (++hitCount == 3)
            {
                //드럼통 폭발효과
                ExpBarrel();
            }
        }
    }

    void ExpBarrel()
    {
        
    }
}
