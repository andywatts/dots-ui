using Unity.Entities;
using UnityEngine.UIElements;


partial struct CanvasSetupSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<UI>();
    }

    public void OnUpdate(ref SystemState state)
    {
        // Run once to setup document reference
        state.Enabled = false;
        var ui = SystemAPI.ManagedAPI.GetSingleton<UI>();   
        ui.GO = UnityEngine.Object.Instantiate(ui.Prefab);  // Spawn GameObject
        ui.Document = ui.GO.GetComponent<UIDocument>();     // Get UIDocument component

        // documentReference.Container = document;
    }

}
