namespace TrainingBlazorApp.Shared.Infrastructure
{
    using MediatR;

    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
