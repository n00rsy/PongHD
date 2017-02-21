using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour
{
    public AIControl other;
    float screenX;
    float screenY;
    float playerX = 0;

    void Start()
    {
        screenX = Screen.width;
        screenY = Screen.height;
        float height = Camera.main.orthographicSize * 2.0f;
        float width = height * Screen.width / Screen.height;
        transform.position = new Vector3((-width/2)+(width/25),0,0);
        playerX = (-width / 2) + (width / 25);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.y > screenY / 2)
            {
                transform.Translate(0, 0.2F, 0);
            }
            if (Input.mousePosition.y < screenY / 2)
            {
                transform.Translate(0, -0.2F, 0);
            }
            if(transform.position.y>4.6){
                transform.position = new Vector3(playerX, 4.6F, 0);
            }
            if (transform.position.y < -4.6)
            {
                transform.position = new Vector3(playerX,-4.6F,0);
            }
        }
        
    }

    void OnCollisionEnter2D()
    {
        Debug.Log("ball hit paddle");
        other.Predict();


    }
}



/*
  if(Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
           if (Input.GetTouch(0).position.y > screenY)
            {
                transform.Translate(0,1,0);
            }
            if (Input.GetTouch(0).position.y < screenY)
            {
                transform.Translate(0, -1, 0);
            }
        }


    if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.y > screenY/2)
            {
                transform.Translate(0,1,0);
            }
            if (Input.mousePosition.y < screenY/2)
            {
                transform.Translate(0, -1, 0);
            }
        }
 */

