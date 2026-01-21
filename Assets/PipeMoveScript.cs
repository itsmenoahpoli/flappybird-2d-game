using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePipe();
    }

    void movePipe() {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < -32)
        {
            Destroy(gameObject);
        }
    }
}
