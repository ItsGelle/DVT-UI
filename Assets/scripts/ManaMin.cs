using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaMin : MonoBehaviour {

    public void OnClickActionMin()
    {
        if (transform.localScale.x >= 0)
        {
            transform.localScale -= new Vector3(0.1f, 0, 0);
        }
    }
}
