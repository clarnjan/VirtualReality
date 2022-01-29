using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int time = 30;
    public TextMesh infoDisplay;
    public TextMesh timeDisplay;

    IEnumerator timer()
    {
        while (GameObject.Find("EndButton").transform.localScale.x != 0)
        {
            int min = time / 60;
            string displayText = "";
            if (min < 10)
                displayText += "0";
            displayText += min.ToString();
            int sec = time % 60;
            displayText += ":";
            if (sec < 10)
                displayText += "0";
            displayText += sec.ToString();

            timeDisplay.text = displayText;
            yield return new WaitForSeconds(1f);
            time--;
            if (time < 0)
            {
                infoDisplay.text = "GAME OVER";
                timeDisplay.text = "You didn't find the cube in time";
                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene(3);
            }
        }
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(timer());
    }
}
