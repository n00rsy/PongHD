using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject rightWall;
    public GameObject leftWall;
    float height = 0;
    float width = 0;

    void Start () {

        topWall = GameObject.Find("topWall");
        bottomWall = GameObject.Find("bottomWall");
        rightWall = GameObject.Find("rightWall");
        leftWall = GameObject.Find("leftWall");

        height = Camera.main.orthographicSize * 2.0f;
        width = height * Screen.width / Screen.height;
        Debug.Log("height  "+height);
        Debug.Log("width  "+width);

        BoxCollider2D top = (BoxCollider2D)topWall.gameObject.AddComponent(typeof(BoxCollider2D));
        BoxCollider2D bottom = (BoxCollider2D)bottomWall.gameObject.AddComponent(typeof(BoxCollider2D));
        BoxCollider2D right = (BoxCollider2D)rightWall.gameObject.AddComponent(typeof(BoxCollider2D));
        BoxCollider2D left = (BoxCollider2D)leftWall.gameObject.AddComponent(typeof(BoxCollider2D));

        topWall.transform.localScale = new Vector3(width, 0.5F, 0);
        bottomWall.transform.localScale = new Vector3(width, 0.5F, 0);
        rightWall.transform.localScale = new Vector3(0.5F, height, 0);
        leftWall.transform.localScale = new Vector3(0.5F, height, 0);

        topWall.transform.position = new Vector3(0, (height / 2) + 0.23F, 0);
        bottomWall.transform.position = new Vector3(0, (-height / 2) - 0.23F, 0);
        rightWall.transform.position = new Vector3((width / 2) + 0.23F, 0, 0);
        leftWall.transform.position = new Vector3((-width / 2) - 0.23F, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {

        

        
    }
}
