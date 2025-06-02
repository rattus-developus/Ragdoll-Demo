using UnityEngine;

public class DemoManager : MonoBehaviour
{
    [SerializeField] RagdollManager rm;
    [SerializeField] GameObject ragdollPrefab;
    bool on = true;

    public void Toggle()
    {
        on = !on;
        rm.ToggleRagdoll(on);
    }

    public void Reset()
    {
        Destroy(rm.gameObject);
        GameObject rd = Instantiate(ragdollPrefab);
        rm = rd.GetComponent<RagdollManager>();

        rm.ToggleRagdoll(on);
    }
}
