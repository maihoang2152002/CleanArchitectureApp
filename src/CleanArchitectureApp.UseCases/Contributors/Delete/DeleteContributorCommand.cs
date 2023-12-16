using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitectureApp.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
