using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            animator.SetTrigger("triggerTeleport");
            playerTeleport();
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("TeleportIn"))
        {
            this.transform.position = GameObject.FindWithTag("TPTarget").transform.position;
        }
    }
    private void playerTeleport()
    {
        GameObject crosshair = GameObject.FindWithTag("TPTarget");
        
        
    }
}
