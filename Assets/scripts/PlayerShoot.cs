using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    RaycastHit hit;
    public Transform fpsCamera;
    public float Range;
    public int Damge = 20;

    public Text text;
    public int Amo = 125;
    public int Bullet = 30;
    private int tempBullet;

    private float LastTime;

    public ParticleSystem Effect;
    public GameObject EffectOn;
    void Start()
    {
        tempBullet = Bullet;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Bullet > 0 && Time.time > LastTime + 0.15f ) 
        {
            Shoot();
            LastTime= Time.time;
        }
        if (Input.GetKey(KeyCode.R) && Amo > 0 && Bullet != tempBullet) 
        {
            Reload();
        }

        text.text = Bullet + "/" + Amo;
    }

    public void Shoot()
    {
        EffectOn.SetActive(true);
        Effect.Play();

        Bullet--;

        if (Physics.Raycast(fpsCamera.position, fpsCamera.forward, out hit, Range)) 
        {
           EnemyHealth _EnemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (_EnemyHealth != null)
            {
                _EnemyHealth.TakeDamage(Damge);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * 100f);
            }
        }
    }

    public void Reload()
    {
        int temp = tempBullet - Bullet;
        if( Amo > temp )
        {
            Bullet += temp;
            Amo -= temp;
        }
        else
        {
            Bullet += Amo;
            Amo = 0;
        }
    }
}
