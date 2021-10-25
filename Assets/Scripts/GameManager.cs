using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public int score;
  public Text scoreUI;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void addPoint(int point = 1)
  {
    score += point;
    scoreUI.text = "Score: " + score.ToString();
  }
}
