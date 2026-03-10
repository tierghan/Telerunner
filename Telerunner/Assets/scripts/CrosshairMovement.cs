using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{
    private Camera mainCamera;
    private float currentY = 0f;

    public Animator animator;

    GameObject marker;

    void Start()
    {
        mainCamera = Camera.main;
        marker = GameObject.FindWithTag("TPTarget");
    }

    void Update()
    {
        FollowMousePosition();
        if (Input.GetMouseButton(0) && animator.GetCurrentAnimatorStateInfo(0).IsName("CrosshairIlde"))
        {
            animator.SetTrigger("triggerTeleport");
            marker.transform.position = this.transform.position;

        }
    }

    private void FollowMousePosition()
    {
        if (GetWorldPositionFromMouse().y >= 3.5f)
        {
            currentY = 3.5f;
        }
        else if (GetWorldPositionFromMouse().y <= -4.5f)
        {
            currentY = -4.5f;
        }
        else
        {
            currentY = GetWorldPositionFromMouse().y;
        }
        transform.position = new Vector3(transform.position.x, currentY, transform.position.z);
    }

    private Vector2 GetWorldPositionFromMouse()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

}
