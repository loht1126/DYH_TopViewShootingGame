using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animation : MonoBehaviour
{
    public Animator animator;
    public Vector3 screenPos;
    public Vector3 worldPos;
    public LayerMask layerOnHit;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        LookAtMouse();

        if (Input.GetKeyDown(KeyCode.W)) { Anim_playrun(); }
        if (Input.GetKeyDown(KeyCode.A)) { Anim_playrun(); }
        if (Input.GetKeyDown(KeyCode.S)) { Anim_playrun(); }
        if (Input.GetKeyDown(KeyCode.D)) { Anim_playrun(); }

        if (Input.GetKeyUp(KeyCode.W)) { Anim_playidle(); }
        if (Input.GetKeyUp(KeyCode.A)) { Anim_playidle(); }
        if (Input.GetKeyUp(KeyCode.S)) { Anim_playidle(); }
        if (Input.GetKeyUp(KeyCode.D)) { Anim_playidle(); }
    }
    public void LookAtMouse()
    {
        screenPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerOnHit))
        {
            worldPos = hitInfo.point;
            worldPos.y = transform.position.y;
            transform.LookAt(worldPos);
        } 
    }
    public void Anim_playrun()
    {
        animator.SetBool("isrun", true);
    }

    public void Anim_playidle()
    {
        animator.SetBool("isrun", false);
    }
}
