using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject.transform.parent.gameObject);
    }
}
