using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveloverscript : MonoBehaviour
{

    public int smileyNum;

    public int nextLevel;
    public int currentLevel;

    private UIScript UIStuff;
    // Start is called before the first frame update
    void Start()
    {
        UIStuff = GameObject.FindObjectOfType<UIScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (UIStuff.publicScore >= smileyNum  ) {
            //index should be the next level
            SceneManager.LoadScene(nextLevel);
        }
        else {
            //index should be the current level
            SceneManager.LoadScene(currentLevel);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
