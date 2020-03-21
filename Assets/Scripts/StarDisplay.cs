using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text starText;
    public int stars = 100;
    public enum Status {SUCCESS, FAILURE};

    void Start()
    {
        starText = GetComponent<Text>();
        updateDisplay();
    }

	public void addStars(int amount)
    {
        stars += amount;
        updateDisplay();
    }

    public Status useStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            updateDisplay();
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }

    private void updateDisplay()
    {
        starText.text = stars.ToString();
    }
}
