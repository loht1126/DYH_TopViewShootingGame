using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{

    public GameObject bullet;
    private void Update()
    {
        aim();
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    private void aim()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y = transform.position.y;
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.green);
    }

    private void shoot()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y = transform.position.y;

        GameObject _bullet = Instantiate(bullet, transform.position, Quaternion.identity);
        _bullet.transform.LookAt(mousePos - transform.position);
    }
}
