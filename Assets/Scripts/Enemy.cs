//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class enemy : MonoBehaviour
//{
//    public float speed;
//    public float startWaitTime;
//    public float deltaTime;
//    private float waitTime;

//    public Transform[] moveSpots;
//    private int randomSpot;

//    void Start()
//    {
//        waitTime = startWaitTime;
//        randomSpot = Random.Range(0, moveSpots.Length);
//    }
//    void Update()
//    {
//        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * waitTime.deltaTime);

//        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
//        {
//            if (waitTime <= 0)
//            {
//                randomSpot = Random.Range(0, moveSpots.Length);
//                waitTime - startWaitTime
//            }
//            else
//            {
//                waitTime -= Time.deltaTime;
//            }
//        }
//    }
//}