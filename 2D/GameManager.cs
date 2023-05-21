using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] jellyGoldList;
    public int[] numGoldList;
    public int[] clickGoldList;
    public int[] BackGroundGold;
    public int[] BackGroundDiamond;
    public string[] BackGroundNameList;
    public Sprite[] BackGroundSpriteList;
    public Sprite[] BackGroundSpriteList2;
    public int[] numDiamondList;

    public Vector3[] PointList;
    public Vector3[] PointList2;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
