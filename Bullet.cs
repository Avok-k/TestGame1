using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // 弾道は上に動く
    void Update()
    {
        transform.position += new Vector3(0,3f,0)*Time.deltaTime;
    }
}
