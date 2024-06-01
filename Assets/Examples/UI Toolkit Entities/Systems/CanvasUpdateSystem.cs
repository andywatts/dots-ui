using Unity.Entities;


partial struct CanvasUpdateSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<UI>();
    }

    public void OnUpdate(ref SystemState state)
    {
        var UI = SystemAPI.ManagedAPI.GetSingleton<UI>();   
        // UI.Document.rootVisualElement.Q<Label>("MyLabel").text = SystemAPI.Time.ElapsedTime.ToString();
    }

}
