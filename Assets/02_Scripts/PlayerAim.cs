using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{ 
     
    public Vector3 screenPos;
    public Vector3 worldPos;
    public LayerMask layerOnHit;
    public Transform aimPoint;
    public GameObject prefab_bullet;

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
        screenPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        if(Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerOnHit))
        {
            worldPos = hitInfo.point;
            worldPos.y = transform.position.y;
        }
        aimPoint.transform.position = worldPos;
    }

    private void shoot()
    {
        screenPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerOnHit))
        {
            worldPos = hitInfo.point;
            worldPos.y = transform.position.y;
        }
        GameObject _obj = Instantiate(prefab_bullet, transform.position, Quaternion.identity);
        _obj.transform.LookAt(worldPos);
    }

}
