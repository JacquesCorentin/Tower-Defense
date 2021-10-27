using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;
    private GameObject upgrade { get { return _upgrade; } }

    private List<Enemy> enemies { get; set; } = null;

    public float _fireRate = 0.1f;

    private float fireRate { get { return _fireRate; } set { _fireRate = value; } }


    public int _value = 10;
    private int value {  get { return _value; } }

    private float currentFireRate { get; set; } = 0;
    public bool canShoot { get; set; } = true;

    // Start is called before the first frame update
    private void Start()
    {
        enemies = new List<Enemy>();
    }

    // Update is called once per frame
    private void Update()
    {


        if (!canShoot)
        {
            currentFireRate += Time.deltaTime;
            if (currentFireRate >= fireRate)
            {
                canShoot = true;
                currentFireRate = 0;
            }
            return;
        }

        if (enemies != null && enemies.Count > 0)
        {
            if(canShoot)
            {
                //Shoot on Enemy
                //Debug.Log("Shoot");
                canShoot = false;
                Destroy(enemies[0].gameObject);
                enemies.RemoveAt(0);
                GameManager.instance.AddGold(1);
            }
        }
        
    }

    public void Upgrade()
    {
        

        if (upgrade ==null)
        {
            return;
        }
        if (GameManager.instance.gold < value)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        GameManager.instance.AddGold(-10);
        Destroy(gameObject);
    }

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
    }
}
