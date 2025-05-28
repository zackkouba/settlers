using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;

    void Start()
    {
        PlayerCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if(Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange)) {
        if(hitInfo.collider.gameObject.TryGetComponent(out EntityHandling enemy))
            {
                //hit
            }
        }
    }

}
