using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public ArrayLayout BoardLayout;
    int Width = 8;
    int Height = 8;
    Node[,] Board;

    System.Random Random;

    void StartGame()
    {
        Board = new Node[Width, Height];

        string Seed = GetRandomSeed();
        Random = new System.Random(Seed.GetHashCode());

        InitializerBoard();
    }
    void InitializerBoard()
    {
        Board = new Node[Width, Height];
        for(int y = 0; y < Height; y++)
        {
            for(int x = 0;x < Width; x++)
            {
                Board[x, y] = new Node(-1; new Point(x,y));
            }
        }
    }



    void Update()
    {
        
    }

    string GetRandomSeed()
    {
        string Seed = "";
        string AcceptableChar = "abcdefghijklmnopqrstuvwxyz123567890";
        for (int i = 0; i < 20; i++)
        {
            Seed += AcceptableChar[Random.Range(0, AcceptableChar.Length)];
        }
        return Seed;
    }

}

[System.Serializable]

public class Node
{
    public int Value;
    public Point Index;

    public Node(int v, Point i)
    {
        Value = v;
        Index = i;
    }
}
