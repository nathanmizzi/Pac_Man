using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{

    [SerializeField] List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;
    int currentWaypoint = 0;

    void Start()
    {
        transform.position = waypoints[currentWaypoint].transform.position;
    }


    void Update()
    {
            if (currentWaypoint < waypoints.Count)
            {
                var targetPosition = waypoints[currentWaypoint].transform.position;

                targetPosition.z = 0f;

                var movementThisFrame = moveSpeed * Time.deltaTime;

                transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

                if (transform.position == targetPosition)
                {
                    currentWaypoint++;

                }

                if(currentWaypoint == waypoints.Count)
            {
                currentWaypoint = 0;
                transform.position = waypoints[currentWaypoint].transform.position;
            }

            }
    }
    }
