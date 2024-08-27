using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{ 
     
    public Vector3 screenPos;
    public Vector3 worldPos;
    public LayerMask layerOnHit;
    public Transform aimPoint;

    private void Update()
    {
        aim();
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

}
