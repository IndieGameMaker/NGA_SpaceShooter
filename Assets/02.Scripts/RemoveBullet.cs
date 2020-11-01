using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    /*
        OnCollisionEnter
        OnCollisionStay
        OnCollisionExit
    */

    void OnCollisionEnter(Collision coll)
    {
        // if (coll.gameObject.tag == "BULLET")
        // {
        // }
        if (coll.collider.CompareTag("BULLET"))
        {
            Destroy(coll.gameObject);
        }
    }
}
