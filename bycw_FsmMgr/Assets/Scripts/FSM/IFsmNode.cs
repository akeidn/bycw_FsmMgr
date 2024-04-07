

public interface IFsmNode
{
    void OnEnter();
    void OnExit();
    void OnUpdate();
    void OnFixedUpdate();
    void OnHandleMessage();
}
