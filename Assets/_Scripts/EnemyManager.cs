using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    void Start() {
        // InitializeArray();
        InitializeList();
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

        foreach (BadGuy badGuy in badGuys) {
            Debug.Log(badGuy);
        }
    }
}
