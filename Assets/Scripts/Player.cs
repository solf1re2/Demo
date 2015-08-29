using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            this.transform.Translate(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right);
        }

    }
}
