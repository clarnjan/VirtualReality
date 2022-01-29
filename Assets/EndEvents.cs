using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndEvents : MonoBehaviour
{
    float entered = -1F;
    bool has_entered = false;
    public TextMesh infoDisplay;
    public TextMesh timeDisplay;

    public void enter()
    {
        has_entered = true;
        entered = Time.time;
        Debug.Log("Entered");
    }

    public void exit()
    {
        has_entered = false;
        Debug.Log("Exited");
    }

    // Update is called once per frame
    void Update()
    {
        if (has_entered && Time.time - entered > 1.5)
        {
            Debug.Log(entered);
            Debug.Log(Time.time);
            has_entered = false;
            infoDisplay.text = "YOU WON";
            timeDisplay.text = "You found the cube in time";
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            StartCoroutine(timer());
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(3);
    }
}
