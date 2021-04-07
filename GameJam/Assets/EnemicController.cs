using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemicController : MonoBehaviour
{
    public Rigidbody enemicRB;
    public Transform[] enemicPositions;
    public float enemicSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;


    void Update()
    {
        MoveEnemic();
    }

    void MoveEnemic()
    {
        enemicRB.MovePosition(Vector3.MoveTowards(enemicRB.position, enemicPositions[nextPosition].position, enemicSpeed * Time.deltaTime));

        if (Vector3.Distance(enemicRB.position, enemicPositions[nextPosition].position) <= 0)
        {
            actualPosition = nextPosition;
            nextPosition++;

            if (nextPosition > enemicPositions.Length - 1)
            {
                nextPosition = 0;
            }
        }
    }
}