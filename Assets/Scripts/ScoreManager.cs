using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Animator spriteScoreFirst;
    public Animator spriteScoreSecond;

    private int _scoreFirst = 0;
    private int _scoreSecond = 0;

    public void ScoreIncrese() 
    { 
        _scoreSecond++;
                //  \/ Unidades \/
        switch (_scoreSecond)
        {
            case 1:
                spriteScoreSecond.SetTrigger("AddPoint");
                spriteScoreSecond.ResetTrigger("AddPointAlt");
                break;
            case 2:
                spriteScoreSecond.ResetTrigger("AddPoint");
                spriteScoreSecond.SetTrigger("AddPointAlt");
                break;
            case 3:
                spriteScoreSecond.SetTrigger("AddPoint");
                spriteScoreSecond.ResetTrigger("AddPointAlt");
                break;
            case 4:
                spriteScoreSecond.ResetTrigger("AddPoint");
                spriteScoreSecond.SetTrigger("AddPointAlt");
                break;
            case 5:
                spriteScoreSecond.SetTrigger("AddPoint");
                spriteScoreSecond.ResetTrigger("AddPointAlt");
                break;
            case 6:
                spriteScoreSecond.ResetTrigger("AddPoint");
                spriteScoreSecond.SetTrigger("AddPointAlt");
                break;
            case 7:
                spriteScoreSecond.SetTrigger("AddPoint");
                spriteScoreSecond.ResetTrigger("AddPointAlt");
                break;
            case 8:
                spriteScoreSecond.ResetTrigger("AddPoint");
                spriteScoreSecond.SetTrigger("AddPointAlt");
                break;
            case 9:
                spriteScoreSecond.SetTrigger("AddPoint");
                spriteScoreSecond.ResetTrigger("AddPointAlt");
                break;
            default:
                _scoreSecond = 0;
                _scoreFirst++;
                spriteScoreSecond.ResetTrigger("AddPoint");
                spriteScoreSecond.SetTrigger("AddPointAlt");
                break;
        }
                //  \/ Dezenas \/
        switch (_scoreFirst)
        {
            case 1:
                spriteScoreFirst.SetTrigger("AddPoint");
                spriteScoreFirst.ResetTrigger("AddPointAlt");
                break;
            case 2:
                spriteScoreFirst.ResetTrigger("AddPoint");
                spriteScoreFirst.SetTrigger("AddPointAlt");
                break;
            case 3:
                spriteScoreFirst.SetTrigger("AddPoint");
                spriteScoreFirst.ResetTrigger("AddPointAlt");
                break;
            case 4:
                spriteScoreFirst.ResetTrigger("AddPoint");
                spriteScoreFirst.SetTrigger("AddPointAlt");
                break;
            case 5:
                spriteScoreFirst.SetTrigger("AddPoint");
                spriteScoreFirst.ResetTrigger("AddPointAlt");
                break;
            case 6:
                spriteScoreFirst.ResetTrigger("AddPoint");
                spriteScoreFirst.SetTrigger("AddPointAlt");
                break;
            case 7:
                spriteScoreFirst.SetTrigger("AddPoint");
                spriteScoreFirst.ResetTrigger("AddPointAlt");
                break;
            case 8:
                spriteScoreFirst.ResetTrigger("AddPoint");
                spriteScoreFirst.SetTrigger("AddPointAlt");
                break;
            case 9:
                spriteScoreFirst.SetTrigger("AddPoint");
                spriteScoreFirst.ResetTrigger("AddPointAlt");
                break;
            default:
                _scoreFirst = 0;
                spriteScoreFirst.ResetTrigger("AddPoint");
                spriteScoreFirst.SetTrigger("AddPointAlt");
                break;
        }
    }
}
