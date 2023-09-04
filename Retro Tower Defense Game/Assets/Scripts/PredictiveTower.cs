using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredictiveTower : Tower
{
    [SerializeField] private float projectile_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tryShoot();
    }

    protected override void tryShoot() //abstract?
    {
        target = furthestTarget();
        if (Time.time - lastShotTime > cooldown && target != null)
        {
            Vector2? dir = aimPrediction(projectile_speed);
            
            
            GameObject bullet = Instantiate(bulletTypes[0], transform.position /*+ dir*/, Quaternion.identity);
            Rigidbody2D projectileRB = bullet.GetComponent<Rigidbody2D>();
            if (dir is Vector2 _dir)
            {
                projectileRB.velocity = _dir * projectile_speed;
            }
            bullet.GetComponent<Projectile>().target = target;
            lastShotTime = Time.time;
        }

    }

    
}
