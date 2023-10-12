using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AObsticleView : MonoBehaviour
{
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
    }
}
