using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public float scoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

   public float distance;

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    GameObject player;
}
