namespace TrainingBlazorApp.Shared.Infrastructure
{
    using MediatR;

    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
