using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public Camera myCamera;
    private GameObject parent;
    private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
        parent = GameObject.Find("Defenders");
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
        if (!parent)
        {
            parent = new GameObject("Defenders");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Vector2 rawPos = calculateWorldPointOfMouseClick();
        Vector2 roundedPos = snapToGrid(rawPos);
        GameObject defender = Button.selectedDefender;
        int defenderCost = defender.GetComponent<Defender>().starCost;
        if (starDisplay.useStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            spawnDefender(roundedPos, defender);
        } else
        {
            Debug.Log("Insufficient stars to spawn");
        }
    }

    void spawnDefender(Vector2 roundedPos, GameObject defender)
    {
        Quaternion zeroRotation = Quaternion.identity;
        GameObject newDef = Instantiate(defender, roundedPos, zeroRotation) as GameObject;
        newDef.transform.parent = parent.transform;
    }

    Vector2 snapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    Vector2 calculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;
        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);
        return worldPos;
    }
}
