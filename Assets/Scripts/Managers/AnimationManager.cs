public class AnimationManager : BaseManager
{

    public override void AddEvents()
    {
        eventManager.StartEvent += OnStart;
    }

    private void OnStart()
    {
        
    }
}
