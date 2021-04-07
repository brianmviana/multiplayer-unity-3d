using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Health : NetworkBehaviour {

    public bool destroyOnDeath;
    public const int maxHealth = 100;

    //public Transform[] spawns;

    [SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = maxHealth;
            

    public RectTransform healthBar;

    public void TakeDamage(int amount) {
        if (!isServer){
            return;
        }

        currentHealth -= amount;
        if (currentHealth <= 0) {
            Debug.Log("Dead!");
            currentHealth = maxHealth;
            RpcRespawn();
        }

        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    }
    void OnChangeHealth(int health) {
        healthBar.sizeDelta = new Vector2(health, healthBar.sizeDelta.y);
    }

    [ClientRpc]
    void RpcRespawn() {
        if (destroyOnDeath) {
            Destroy(gameObject);
        }
        else {
            if (isLocalPlayer) {
                transform.position = Vector3.zero;

                //transform.position = spawns[Random.Range(0, spawns.Length)].transform.position;
            }
        }
    }

}
