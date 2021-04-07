using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpanw;

    public Color playerColor;



    public override void OnStartLocalPlayer() {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }


    void Update() {
        if (!isLocalPlayer) {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space)) {
            CmdFire();
            CmdPlayerColor(playerColor);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            CmdPlayerColor(playerColor);
        }
    }

    [Command]
    void CmdFire() {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpanw.position, bulletSpanw.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        NetworkServer.Spawn(bullet);

        Destroy(bullet, 2.0f);
    }

    [Command]
    void CmdPlayerColor(Color color) {
        GetComponent<MeshRenderer>().material.color = color;
        RpcPlayerColor(color);
    }
    
    [ClientRpc]
    void RpcPlayerColor(Color color) {
        GetComponent<MeshRenderer>().material.color = color;    
    }
}
