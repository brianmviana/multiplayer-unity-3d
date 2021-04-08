using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    void Start() {
        // InitializeArray();
        // InitializeList();
        // InitializeDictionary();
        // InitializeStack();
        InitializeQueue();
    }

    void InitializeArray() {
        BadGuy[] badGuys = new BadGuy[] {
            new BadGuy("Robotnik", 20),
            new BadGuy("Thanos", 1000),
            new BadGuy("Rugal", 200),
            new BadGuy("Freeza", 800)
        };

        Debug.Log("-- while --");
        int index = 0;
        while (index < badGuys.Length) {
            Debug.LogFormat("[{0}] {1}", index, badGuys[index]);
            index++;
        }

        Debug.Log("-- for --");
        for (int i = 0; i < badGuys.Length; i++) {
            Debug.LogFormat("[{0}] {1}", i, badGuys[i]);
        }

        Debug.Log("-- foreach --");
        foreach (BadGuy badGuy in badGuys) {
            Debug.Log(badGuy);
        }

    }

    void InitializeList() {
        List<BadGuy> badGuys = new List<BadGuy>();

        badGuys.Add(new BadGuy("Robotnik", 20));
        badGuys.Add(new BadGuy("Thanos", 1000));
        badGuys.Add(new BadGuy("Rugal", 200));
        badGuys.Add(new BadGuy("Freeza", 800));

        badGuys.Add(new BadGuy("Malevola", 333));

        badGuys.RemoveAt(badGuys.Count - 1);

        badGuys.Sort();

        foreach (BadGuy badGuy in badGuys) {
            Debug.Log(badGuy);
        }
    }


    void InitializeDictionary() {
        Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Robotnik", 20);
        BadGuy bg2 = new BadGuy("Thanos", 1000);
        BadGuy bg3 = new BadGuy("Rugal", 200);
        BadGuy bg4 = new BadGuy("Freeza", 800);

        badGuys.Add(bg1.name, bg1);
        badGuys.Add(bg2.name, bg2);
        badGuys.Add(bg3.name, bg3);
        badGuys.Add(bg4.name, bg4);

        Debug.Log(badGuys["Thanos"]);

        string bg = "Malevola";

        if (badGuys.TryGetValue(bg, out BadGuy someGuy)) {
            Debug.Log(someGuy);
        }
        else {
            Debug.LogFormat("{0} {1}", bg, "não existe nesse dicionario");
        }

        foreach (var pair in badGuys) {
            Debug.LogFormat("[{0}] - {1}", pair.Key, pair.Value);
        }
    }

    void InitializeStack() {
        Stack<BadGuy> badGuys = new Stack<BadGuy>();

        badGuys.Push(new BadGuy("Robotnik", 20));
        badGuys.Push(new BadGuy("Thanos", 1000));
        badGuys.Push(new BadGuy("Rugal", 200));
        badGuys.Push(new BadGuy("Freeza", 800));


        while (badGuys.Count > 0) {
            Debug.LogFormat("Contagem da da pilha = {0}", badGuys.Count);
            Debug.Log(badGuys.Pop());
        }

    }

    void InitializeQueue() {
        Queue<BadGuy> badGuys = new Queue<BadGuy>();

        badGuys.Enqueue(new BadGuy("Robotnik", 20));
        badGuys.Enqueue(new BadGuy("Thanos", 1000));
        badGuys.Enqueue(new BadGuy("Rugal", 200));
        badGuys.Enqueue(new BadGuy("Freeza", 800));


        while (badGuys.Count > 0) {
            BadGuy nextGuy = badGuys.Dequeue();
            Debug.Log(nextGuy);
            Debug.LogFormat("Contagem da da pilha = {0}", badGuys.Count);
        }


    }
}
