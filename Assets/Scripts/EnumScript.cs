using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnumScript : MonoBehaviour
{
    enum Direction { North, East, South, West }; // 세미콜론 없어도 됨, 기본은 int형으로 작동, 값을 지정 안하면 자동으로 값이 들어감 0부터

    void Start()
    {
        Direction myDirection = Direction.North;

        int dir = (int)myDirection;
        int len = System.Enum.GetValues(typeof(Direction)).Length;
        // system에 있는 Random 이용
        var rand1 = new System.Random();
        //myDirection = (Direction)(rand1.Next() % len);

        // UnityEngine에 이쓴 Random 이용
        var rand2 = UnityEngine.Random.Range(0, len - 1);
        myDirection = (Direction)rand2; 
        Debug.Log(myDirection);

        var returnDirection = ReverseDirection(myDirection);
        Debug.Log(returnDirection);
    }

    int ReverseDirection(int dir)
    {
        switch ((Direction)dir)
        {
            case Direction.North:
                dir = (int)Direction.South;
                break;
            case Direction.South:
                dir = (int)Direction.North;
                break;
            case Direction.East:
                dir = (int)Direction.West;
                break;
            case Direction.West:
                dir = (int)Direction.East;
                break;
            default:
                break;
        }
        return dir;
    }

    Direction ReverseDirection(Direction dir)
    {
        // if (dir == Direction.North)
        //     dir = Direction.South;
        // else if (dir == Direction.South)
        //     dir = Direction.North;
        // else if (dir == Direction.East)
        //     dir = Direction.West;
        // else if (dir == Direction.West)
        //     dir = Direction.East;

        switch (dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default:
                Debug.Log("잘못된 값입니다.");
                break;
            
        }
        return dir;    
    }
}
