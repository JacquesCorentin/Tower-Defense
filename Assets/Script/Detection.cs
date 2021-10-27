using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    private Tower towerParent { get; set; } = null;
    // Start is called before the first frame update
    void Start()
    {
        towerParent = GetComponentInParent<Tower>();
                
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.AddEnemy(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.RemoveEnemy(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
