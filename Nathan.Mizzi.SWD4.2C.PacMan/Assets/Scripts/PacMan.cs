using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    [SerializeField] float startingPosY;
    [SerializeField] float startingPosX;

    [SerializeField] float newTeleportLeftPosX;
    [SerializeField] float newTeleportLeftPosY;

    [SerializeField] float newTeleportRightPosX;
    [SerializeField] float newTeleportRightPosY;

    public Animator animator;
    Vector2 movement;

    // Update is called once per frame

    void Start()
    {
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        movement.x = deltaX;
        movement.y = deltaY;

        var newXPos = transform.position.x + deltaX;
        var newYPos = transform.position.y + deltaY;

        animator.SetFloat("Horizontal", deltaX);
        animator.SetFloat("Vertical", deltaY);
        animator.SetFloat("Speed", movement.magnitude);

        transform.position = new Vector3(newXPos, newYPos, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "ghosts")
        {
            resetPos();
        }

        if (trigger.gameObject.tag == "left")
            {
                TeleportLeftPos();
            }
            else if (trigger.gameObject.tag == "right")
            {
                TeleportRightPos();
            }
    }

    public void resetPos()
    {
        transform.position = new Vector2(startingPosY, startingPosX);
    }

    public void TeleportLeftPos()
    {
        transform.position = new Vector2(newTeleportLeftPosX, newTeleportLeftPosY);
    }

    public void TeleportRightPos()
    {
        transform.position = new Vector2(newTeleportRightPosX, newTeleportRightPosY);
    }

}
