using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform enemyTransfom { get; set; } = null;

    // Start is called before the first frame update
    void Start()
    {
        enemyTransfom = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime*3;
    }
}
