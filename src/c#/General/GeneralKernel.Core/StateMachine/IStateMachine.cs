namespace GeneralKernel.Core.StateMachine;

public interface IStateMachine
{
    void Builder();

    void MoveNext();
}