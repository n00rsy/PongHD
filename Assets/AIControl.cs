using UnityEngine;
using System.Collections;

public class AIControl : MonoBehaviour
{


    float playerX = 0;
    float playerY = 3;

    Vector2 ballPosOne;
    Vector2 ballPosTwo;
    Vector2 rayDirection;

    public Vector2 PredictPos;
    public GameObject Ball;
    public GameObject rightWall;
    public LayerMask mask = -1;

    float height;
    float width;

    void Start()
    {
        height = Camera.main.orthographicSize * 2.0f;
        width = height * Screen.width / Screen.height;
        transform.position = new Vector3((width / 2) - (width / 25), 0, 0);
        playerX = (width / 2) - (width / 25);
        Ball = GameObject.Find("Ball");
        rightWall = new GameObject();
    }


    void Update()
    {
        float speed = 7;
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(playerX, playerY), step);
    }


    public void Predict()
    {
        Debug.Log("complete testing");
        StartCoroutine("getBallDir");

    }


    public void PredictWall()
    {
        Debug.Log("complete testing");
        StartCoroutine("getBallDirWall");
    }


    IEnumerator getBallDir()
    {
        ballPosOne = Ball.transform.position;
        yield return new WaitForSeconds(0.05F);
        ballPosTwo = Ball.transform.position;
        rayDirection = ballPosTwo - ballPosOne;
        RaycastHit2D hit = Physics2D.Raycast(ballPosTwo, rayDirection, 20F, mask);
        Debug.DrawRay(ballPosTwo, rayDirection, Color.white, 2);


        while (hit.collider.name != "rightWall")
        {
            Debug.Log("calc testing");
            Vector2 n = hit.normal;
            n.Normalize();
            rayDirection = Vector2.Reflect(rayDirection, n);
            hit = Physics2D.Raycast(hit.point + hit.normal * 0.01f, rayDirection, 20F, mask);
            Debug.DrawRay(hit.point, rayDirection, Color.white, 2);
        }
        float rand = Random.Range(-1F,1.75F);
        playerY = hit.point.y+rand;

        if (playerY>height/2)
        {
            playerY = height/2;
        }

        if (playerY < -height/2)
        {
            playerY = -height/2;
        }
    }

    IEnumerator getBallDirWall()
    {
        yield return null;
    }
}