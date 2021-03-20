using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float gravityModifier = 20f;
     void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityModifier;
    }

    void Update()
    {
        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    }
}
