using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    static public  bool isRaceBtnDown;
    static public bool isBrakeBtnDown;
    private void Start()
    {
        isRaceBtnDown = false;
        isBrakeBtnDown = false;
    }
    public void RaceBtnDown()
    {
        isRaceBtnDown = true;
    }
    public void RaceBtnUp()
    {
        isRaceBtnDown = false;
    }
    public void BrakeBtnDown()
    {
        isBrakeBtnDown = true;
    }
    public void BrakeBtnUp()
    {
        isBrakeBtnDown = false;
    }
}
