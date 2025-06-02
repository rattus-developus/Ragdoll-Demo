using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    [SerializeField] Transform root;

    //Toggles the ragdoll on or off
    public void ToggleRagdoll(bool on)
    {
        ToggleRagdoll_R(on, root);
    }

    //Private recursive helper function for ToggleRagdoll
    void ToggleRagdoll_R(bool on, Transform t)
    {
        //Toggle rigidbody using isKinematic and collider
        if (t.gameObject.GetComponent<Rigidbody>() != null) t.gameObject.GetComponent<Rigidbody>().isKinematic = !on;
        if (t.gameObject.GetComponent<Collider>() != null) t.gameObject.GetComponent<Collider>().enabled = on;

        //Recurse for each child
        for (int i = 0; i < t.childCount; i++)
        {
            ToggleRagdoll_R(on, t.GetChild(i));
        }
    }
}
